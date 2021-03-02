using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using System.IO;
using System.Windows.Forms;

namespace Q3Editor
{
    /// <summary>
    /// Lógica de interacción para MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private bool guardado;

        public MainWindow()
        {
            InitializeComponent();

            guardado = true;

            RoutedCommand Ctrl_N = new RoutedCommand();
            Ctrl_N.InputGestures.Add(new KeyGesture(Key.N, ModifierKeys.Control));
            CommandBindings.Add(new CommandBinding(Ctrl_N, mArchivoNuevo_Click));

            RoutedCommand Ctrl_O = new RoutedCommand();
            Ctrl_O.InputGestures.Add(new KeyGesture(Key.O, ModifierKeys.Control));
            CommandBindings.Add(new CommandBinding(Ctrl_O, mArchivoAbrir_Click));

            RoutedCommand Ctrl_S = new RoutedCommand();
            Ctrl_S.InputGestures.Add(new KeyGesture(Key.S, ModifierKeys.Control));
            CommandBindings.Add(new CommandBinding(Ctrl_S, mArchivoGuardar_Click));

            RoutedCommand Alt_F4 = new RoutedCommand();
            Alt_F4.InputGestures.Add(new KeyGesture(Key.F4, ModifierKeys.Alt));
            CommandBindings.Add(new CommandBinding(Alt_F4, mArchivoSalir_Click));

            RoutedCommand Ctl_B = new RoutedCommand();
            Ctl_B.InputGestures.Add(new KeyGesture(Key.B, ModifierKeys.Control));
            CommandBindings.Add(new CommandBinding(Ctl_B, mFuenteNegrita_Click));

            RoutedCommand Ctl_K = new RoutedCommand();
            Ctl_K.InputGestures.Add(new KeyGesture(Key.K, ModifierKeys.Control));
            CommandBindings.Add(new CommandBinding(Ctl_K, mFuenteCursiva_Click));

            RoutedCommand Ctl_U = new RoutedCommand();
            Ctl_U.InputGestures.Add(new KeyGesture(Key.U, ModifierKeys.Control));
            CommandBindings.Add(new CommandBinding(Ctl_U, mFuenteSubrayado_Click));

            RoutedCommand Ctl_Mas = new RoutedCommand();
            Ctl_Mas.InputGestures.Add(new KeyGesture(Key.Add, ModifierKeys.Control));
            CommandBindings.Add(new CommandBinding(Ctl_Mas, mFuenteAumentar_Click));

            RoutedCommand Ctl_Menos = new RoutedCommand();
            Ctl_Menos.InputGestures.Add(new KeyGesture(Key.Add, ModifierKeys.Control));
            CommandBindings.Add(new CommandBinding(Ctl_Menos, mFuenteDisminuir_Click));

            txtTexto.Focus();
        }

        private MessageBoxResult ConfirmacionBox(string texto)
        {
            return System.Windows.MessageBox.Show(texto, "Confirmación", MessageBoxButton.YesNo, 
                MessageBoxImage.Question);
        }

        private void Guardar()
        {
            if (!guardado)
            {
                if (panelNombre.Content.ToString()=="<Sin nombre>")
                {
                    GuardarComo();
                }
                else
                {
                    File.WriteAllText(panelNombre.Content.ToString(), txtTexto.Text);

                    guardado = true;

                    panelEstado.Content = "Guardado";
                }
            }

        }
        private void SeGuarda()
        {
            if (txtTexto.Text !="" && !guardado)
            {
                if(ConfirmacionBox("¿Desea guardar el texto?") == MessageBoxResult.Yes)
                {
                    Guardar();
                }
            }

        }

        private void mArchivoNuevo_Click(object sender, RoutedEventArgs e)
        {
            SeGuarda();
            txtTexto.Clear();

            panelNombre.Content = "<Sin nombre>";
        }

        private void txtTexto_TextChanged(object sender, TextChangedEventArgs e)
        {
            if (guardado == true)
            {
                guardado = false;

                panelEstado.Content = "No guardado";
            }
        }

        private void mArchivoGuardar_Click(object sender, RoutedEventArgs e)
        {
            Guardar();
        }

        private void VentanaPrincipal_Closing(object sender, System.ComponentModel.CancelEventArgs e)
        {
            SeGuarda();
        }

        private void mArchivoSalir_Click(object sender, RoutedEventArgs e)
        {
            Close();
        }

        private void mArchivoAbrir_Click(object sender, RoutedEventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();

            var path = System.Environment.GetFolderPath(System.Environment.SpecialFolder.MyDocuments);

            openFileDialog.InitialDirectory = path;
            openFileDialog.Filter = "Archivo de texto (*.txt)|*.txt|Todoslos archivos (*.*)|*.*";
            openFileDialog.FilterIndex = 1;

            if (openFileDialog.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                var fileStream = openFileDialog.OpenFile();
            

                using (StreamReader reader = new StreamReader(fileStream))
                {
                    txtTexto.Text = reader.ReadToEnd();
                }

                panelNombre.Content = openFileDialog.FileName;

                guardado = true;

                panelEstado.Content = "Guardado";
            }
        }
        private void mArchivoImprimir_Click(object sender, RoutedEventArgs e)
        {

        }

        private void mEditarCortar_Click(object sender, RoutedEventArgs e)
        {
            if (txtTexto.SelectedText != "")
                txtTexto.Cut();
        }

        private void mEditarCopiar_Click(object sender, RoutedEventArgs e)
        {
            if (txtTexto.SelectedText != "")
                txtTexto.Copy();
        }

        private void GuardarComo()
        {
            SaveFileDialog saveFileDialog = new SaveFileDialog();

            var path = System.Environment.GetFolderPath(System.Environment.SpecialFolder.MyDocuments);

            saveFileDialog.InitialDirectory = path;
            saveFileDialog.Filter = "Arvhicos de texto (*.txt)|*.txt|Todos los archivos (*.*)|*.*";
            saveFileDialog.FilterIndex = 1;
            

            if (saveFileDialog.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                panelNombre.Content = saveFileDialog.FileName;

                File.WriteAllText(panelNombre.Content.ToString(), txtTexto.Text);

                guardado = true;

                panelEstado.Content = "Guardado";
            }
        }

        private void mArchivoGuardiarComo_Click(object sender, RoutedEventArgs e)
        {
            GuardarComo();
        }

        private void mEditarPegar_Click(object sender, RoutedEventArgs e)
        {
            txtTexto.Paste();
        }

        private void mFuenteCursiva_Click(object sender, RoutedEventArgs e)
        {
            if (mFuenteCursiva.IsChecked)
            {
                txtTexto.FontStyle = FontStyles.Normal;
                mFuenteCursiva.IsChecked = false;
            }
            else
            {
                txtTexto.FontStyle = FontStyles.Italic;
                mFuenteCursiva.IsChecked = true;
            }
        }

        private void mFuenteNegrita_Click(object sender, RoutedEventArgs e)
        {
            if (mFuenteNegrita.IsChecked)
            {
                txtTexto.FontWeight = FontWeights.Normal;
                mFuenteNegrita.IsChecked = false;
            }
            else
            {
                txtTexto.FontWeight = FontWeights.Bold;
                mFuenteNegrita.IsChecked = true;
            }
        }

        private void mFuenteSubrayado_Click(object sender, RoutedEventArgs e)
        {
            if (mFuenteSubrayado.IsChecked)
            {
                txtTexto.TextDecorations = null;

                mFuenteSubrayado.IsChecked = false;
            }
            else
            {
                txtTexto.TextDecorations = TextDecorations.Underline;
                mFuenteSubrayado.IsChecked = true;
            }
        }

        private void mFuenteAumentar_Click(object sender, RoutedEventArgs e)
        {
            txtTexto.FontSize++;
        }

        private void mFuenteDisminuir_Click(object sender, RoutedEventArgs e)
        {
            if(txtTexto.FontSize > 1)   
                txtTexto.FontSize--;
        }

        private void mFuenteFuentes_Click(object sender, RoutedEventArgs e)
        {
            var fontDialog = new FontDialog();
            fontDialog.ShowDialog();
        }
    }
}

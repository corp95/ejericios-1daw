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

namespace ejemplo_1
{
    /// <summary>
    /// Lógica de interacción para MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void btnSalir_Click(object sender, RoutedEventArgs e)
        {
            if(txtNombre.Text=="")
            {
                txtNombre.Background = Brushes.Red;
                txtNombre.Focus();
                
                return;
            }

            if(txtApellido.Text=="")
            {
                txtApellido.Background = Brushes.Red;
                txtApellido.Focus();

                return;
            }

            MessageBox.Show("Adiós " + txtNombre.Text + " "+ txtApellido.Text);

            Close();
        }

        private void VentanaPrincipal_Closing(object sender, System.ComponentModel.CancelEventArgs e)
        {
            if(MessageBox.Show("¿Estás seguro de salir de la APP?",
                                "Salir",
                                MessageBoxButton.YesNo,
                                MessageBoxImage.Question) == MessageBoxResult.No)

            {
                e.Cancel = true;
            }
        }

        private void rbCoche_Click(object sender, RoutedEventArgs e)
        {
            lbMotos.IsEnabled = false;
            combCoches.IsEnabled = true;

        }

        private void rbMoto_Click(object sender, RoutedEventArgs e)
        {
            lbMotos.IsEnabled = true;
            combCoches.IsEnabled = false;
        }

        private void rbMoto_Checked(object sender, RoutedEventArgs e)
        {

        }

        private void txtNombre_KeyUp(object sender, KeyEventArgs e)
        {
            btnSalir.IsEnabled = true;

            if (e.Key == Key.Back)
            {
                if (txtNombre.Text=="")
                {
                    btnSalir.IsEnabled = false;
                }
            }
        }
    }
}

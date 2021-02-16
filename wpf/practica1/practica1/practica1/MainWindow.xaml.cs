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

namespace practica1
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

        private void WindowInicio_Closing(object sender, System.ComponentModel.CancelEventArgs e)
        {
               if (MessageBox.Show("¿Estás seguro de salir de la APP?",
                                    "Salir",
                                    MessageBoxButton.YesNo,
                                    MessageBoxImage.Question) == MessageBoxResult.No)

                {
                    e.Cancel = true;
                }
            
        }

        private void btnDistribuidor_Click(object sender, RoutedEventArgs e)
        {
            cbProvincia.Items.Clear();
            cbProvincia.Items.Add("Castellón");
            cbProvincia.Items.Add("Alicante");
            cbProvincia.Items.Add("Valencia");
        }

        private void btnCliente_Click(object sender, RoutedEventArgs e)
        {
            cbProvincia.Items.Clear();
            cbProvincia.Items.Add("Castellón");
            cbProvincia.Items.Add("Alicante");
            cbProvincia.Items.Add("Valencia");
            cbProvincia.Items.Add("Murcia");
            cbProvincia.Items.Add("Albacete");
            cbProvincia.Items.Add("Cuenca");
            cbProvincia.Items.Add("Teruel");
        }

        private void btnAceptar_Click(object sender, RoutedEventArgs e)
        {
            if (txtblckNombre.Text == "")
            {
                txtblckNombre.Background = Brushes.Red;
                txtblckNombre.Focus();

                return;
            }

            if (txtblckPrimerApellido.Text == "")
            {
                txtblckPrimerApellido.Background = Brushes.Red;
                txtblckPrimerApellido.Focus();

                return;
            }

            if (txtblckDNI.Text == "")
            {
                txtblckDNI.Background = Brushes.Red;
                txtblckDNI.Focus();

                return;
            }

            if (txtblckTlfn1.Text == "")
            {
                txtblckTlfn1.Background = Brushes.Red;
                txtblckTlfn1.Focus();

                return;
            }

            if (txtblckEmail.Text == "")
            {
                txtblckEmail.Background = Brushes.Red;
                txtblckEmail.Focus();

                return;
            }

            if (txtblckDireccion.Text == "")
            {
                txtblckDireccion.Background = Brushes.Red;
                txtblckDireccion.Focus();

                return;
            }

            if (txtblckCP.Text == "")
            {
                txtblckCP.Background = Brushes.Red;
                txtblckCP.Focus();

                return;
            }

            if (txtblckPoblacion.Text == "")
            {
                txtblckPoblacion.Background = Brushes.Red;
                txtblckPoblacion.Focus();

                return;
            }

            MessageBox.Show("Bienvenid@ " + txtblckNombre.Text + " " + txtblckPrimerApellido.Text + " con DNI: " + txtblckDNI.Text);
            MessageBox.Show("Tus datos son: \n" +
                "Número de teléfono: " + txtblckTlfn1.Text + "\n" +
                "Correo electrónico: " + txtblckEmail.Text + "\n" +
                "Dirección: " + txtblckDireccion.Text + "\n" +
                "CP: " + txtblckCP.Text + "\n" +
                "Población: " + txtblckPoblacion.Text);

            Close();
        }
    }
}

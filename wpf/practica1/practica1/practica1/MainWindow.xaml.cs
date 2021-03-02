// --------------------------------------------
// Daniel Santonja Gosálbez
// DAW
// Modalidad Presencial
// Práctica nº 3
// --------------------------------------------



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
using System.Text.RegularExpressions;

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

        private void WindowInicio_Closing(object sender, System.ComponentModel.CancelEventArgs e) //El mensaje que te indica cuando vas a salir de la aplicación
        {
               if (MessageBox.Show("¿Estás seguro de salir de la APP?",
                                    "Salir",
                                    MessageBoxButton.YesNo,
                                    MessageBoxImage.Question) == MessageBoxResult.No)

                {
                    e.Cancel = true;
                }
            
        }

        private void btnDistribuidor_Click(object sender, RoutedEventArgs e) //Si le das distribuidor se borran todos y se añaden los requeridos.
        {
            ComboBoxItem cbiPlaceholder = new ComboBoxItem();
            cbiPlaceholder.Content = "-- Elige una provincia --";
            cbiPlaceholder.IsEnabled = false;
            cbiPlaceholder.IsSelected = true;

            cbProvincia.Items.Add(cbiPlaceholder);

            cbProvincia.Items.Add("Castellón");
            cbProvincia.Items.Add("Alicante");
            cbProvincia.Items.Add("Valencia");
        }

        private void btnCliente_Click(object sender, RoutedEventArgs e)
        {
            ComboBoxItem cbiPlaceholder = new ComboBoxItem();
            cbiPlaceholder.Content = "-- Elige una provincia --";
            cbiPlaceholder.IsEnabled = false;
            cbiPlaceholder.IsSelected = true;

            cbProvincia.Items.Add(cbiPlaceholder);

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
            Regex regex = new Regex(@"^([\w\.\-]+)@([\w\-]+)((\.(\w){2,9}))+$"); //Aqui marcamos como debe ser el formato del correo electrónico a introducir.
            Match match = regex.Match(txtblckEmail.Text);

            if(!match.Success) //En el caso de que el correo sea incorrecto saltará este aviso.
            {
                MessageBox.Show("El email " + txtblckEmail.Text + " es incorrecto.",
                    "Error",
                    MessageBoxButton.OK,
                    MessageBoxImage.Error);
                return;
            }

            if(btnCliente.IsChecked == true) //Si le damos a aceptar sale este mensaje con el INSERT TO.
            { 
                MessageBox.Show("INSERT INTO clientes (Nombre, Primer_Apellido, Segundo_Apellido" + //Este mensaje es el de cliente
                " , Telefono1, Telefono2, Correo, Dirección, CP, Población, Provincia)" +
                " VALUES('" + txtblckNombre.Text + "','" + txtblckPrimerApellido.Text + "','" + txtblckSegundoApellido.Text +
                "','" + txtblckTlfn1.Text + "','" + txtblckTlfn2.Text + "','" + txtblckEmail.Text + "','" + txtblckDireccion.Text +
                "','" + txtblckCP.Text + "','" + txtblckPoblacion.Text + "','" + cbProvincia.Text + "')");
            }
            else
            {
                MessageBox.Show("INSERT INTO distribuidor (Nombre, Primer_Apellido, Segundo_Apellido" + //Este mensaje es el de distribuidor
               " , Telefono1, Telefono2, Correo, Dirección, CP, Población, Provincia)" +
               " VALUES('" + txtblckNombre.Text + "','" + txtblckPrimerApellido.Text + "','" + txtblckSegundoApellido.Text +
               "','" + txtblckTlfn1.Text + "','" + txtblckTlfn2.Text + "','" + txtblckEmail.Text + "','" + txtblckDireccion.Text +
               "','" + txtblckCP.Text + "','" + txtblckPoblacion.Text + "','" + cbProvincia.Text + "')");
            }
            Close();
        }

        private void VerificarAceptar() //Aqui comprobamos que se puede activar el botón de aceptar si se cumplen una serie de condiciones.
        {
            btnAceptar.IsEnabled = true; 

            if (txtblckNombre.Text == "")
            {
                btnAceptar.IsEnabled = false;
                

                return;
            }

            if (txtblckPrimerApellido.Text == "")
            {
                btnAceptar.IsEnabled = false;
                

                return;
            }

            if (txtblckDNI.Text == "")
            {
                btnAceptar.IsEnabled = false;
                

                return;
            }

            if (txtblckTlfn1.Text == "")
            {
                btnAceptar.IsEnabled = false;
                

                return;
            }

            if (txtblckEmail.Text == "")
            {
                btnAceptar.IsEnabled = false;
                

                return;
            }

            if (txtblckDireccion.Text == "")
            {
                btnAceptar.IsEnabled = false;
                

                return;
            }

            if (txtblckCP.Text == "")
            {
                btnAceptar.IsEnabled = false;
                

                return;
            }

            if (txtblckPoblacion.Text == "")
            {
                btnAceptar.IsEnabled = false;
                

                return;
            }
        }

        //Comprobamos que se cumplen todas las condiciones y llamamos a la función de vuelta.
        private void txtblckNombre_TextChanged(object sender, TextChangedEventArgs e)
        {
            VerificarAceptar();
        }

        private void txtblckPrimerApellido_TextChanged(object sender, TextChangedEventArgs e)
        {
            VerificarAceptar();
        }

        private void txtblckDNI_TextChanged(object sender, TextChangedEventArgs e)
        {
            VerificarAceptar();
        }

        private void txtblckTlfn1_TextChanged(object sender, TextChangedEventArgs e)
        {
            VerificarAceptar();
        }

        private void txtblckEmail_TextChanged(object sender, TextChangedEventArgs e)
        {
            VerificarAceptar();
        }

        private void txtblckDireccion_TextChanged(object sender, TextChangedEventArgs e)
        {
            VerificarAceptar();
        }

        private void txtblckCP_TextChanged(object sender, TextChangedEventArgs e)
        {
            VerificarAceptar();
        }

        private void txtblckPoblacion_TextChanged(object sender, TextChangedEventArgs e)
        {
            VerificarAceptar();
        }

        private void btnCancelar_Click(object sender, RoutedEventArgs e)
        {
            Close();
        }

        private void NumberValidationTextBox(object sender, TextCompositionEventArgs e) //Esto nos sirve para comprobar que introducimos sólo números donde queramos.
        {
            Regex regex = new Regex("[^0-9]+");
            e.Handled = regex.IsMatch(e.Text);
        }
    }
}

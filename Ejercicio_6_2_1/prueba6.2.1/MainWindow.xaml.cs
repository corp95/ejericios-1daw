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

namespace prueba6._2._1
{
    public class Persona
    {
        string nombre;

        public void SetNombre(string nombre)
        {
            this.nombre = nombre; //el this está explicado en el apartado 7.5
        }
        public string GetNombre()
        {
            return this.nombre;
        }

        public void Saludar()
        {
            MessageBox.Show("Hola soy " + this.nombre);
        }
    }

    /// <summary>
    /// Lógica de interacción para MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        Persona persona1;
        Persona persona2;

        public MainWindow()
        {
            InitializeComponent();

            persona1 = new Persona();
            persona2 = new Persona();
        }

        private void btnAsignar_Click(object sender, RoutedEventArgs e)
        {
            persona1.SetNombre(tbNombre1.Text);
            persona2.SetNombre(tbNombre2.Text);

            persona1.SetNombre(persona1.GetNombre());
            persona2.SetNombre(persona2.GetNombre());
        }

        private void btnSaludar_Click(object sender, RoutedEventArgs e)
        {
            persona1.Saludar();
            persona2.Saludar();
        }
    }
}

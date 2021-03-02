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

namespace Ejercicio_6_2_2
{
    public class Juego
    {
        public void Lanzar()
        {
            MessageBox.Show("Bienvenido a Console Invaders. Pulse Intro para salir");
        }
    }
    public partial class MainWindow : Window
    {
        Juego juego1;
        public MainWindow()
        {
            InitializeComponent();

            juego1 = new Juego();

            juego1.Lanzar();
        }
    }
}

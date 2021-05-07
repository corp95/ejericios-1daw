using Microsoft.Win32;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Reflection;
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

// --------------------------------------------
// Daniel Santonja Gosálbez
// 1º DAW
// Modalidad Presencial
// Práctica nº 4
// --------------------------------------------

namespace AppTextos
{
	/// <summary>
	/// Interaction logic for MainWindow.xaml
	/// </summary>
	public partial class MainWindow : Window
	{
		// Estructura de datos de una provincia
		public struct InfoProvincia
		{
			public string provincia;
			public List<string> clientes;
		}
		
		private List<InfoProvincia> infoProvincias = new List<InfoProvincia>();
		private string filePath = string.Empty;

		public MainWindow()
		{
			InitializeComponent();
			organizar_btn.Click += Button_Click;
		}

		private void Button_Click(object sender, RoutedEventArgs e)
		{
			// Conseguimos los datos de los clientes
			string datosClientes = AbrirFicheroClientes();
			
			// Los clasificamos
			ClasificarDatos(datosClientes);
			
			// Los metemos en ficheros individuales por provincia
			foreach (InfoProvincia info in infoProvincias)
			{
				GuardarFicheroNuevo(info);
			}

			MessageBox.Show("Clientes organizados por provincia.", "Información",
							MessageBoxButton.OK, MessageBoxImage.Information);
		}

		private string AbrirFicheroClientes()
		{
			string textoFichero = string.Empty;

			// El OpenFileDialog nos permite buscar el archivo que queramos
			OpenFileDialog dialogoAbrir = new OpenFileDialog();
			dialogoAbrir.Filter = "Text files (*.txt)|*.txt|All files (*.*)|*.*"; //Filtro para seleccionar .txt
			dialogoAbrir.Title = "Selecciona el fichero de clientes"; //Título de la ventana
			
			if (dialogoAbrir.ShowDialog() == true)
			{
				// Leemos el texto del fichero y nos lo guardamos
				textoFichero = File.ReadAllText(dialogoAbrir.FileName);

				// Nos guardamos el path donde vamos a meter todos los ficheros nuevos
				// basicamente es el path total del fichero (FileName) - la terminacion (SafeFileName), que sustituimos por string.Empty (equivalente a "")
				filePath = dialogoAbrir.FileName.Replace(dialogoAbrir.SafeFileName, string.Empty);
			}

			return textoFichero;
		}

		private void ClasificarDatos(string datosClientes)
		{
			// Separamos todos los datos por nueva linea (equivalente a "/r/n")
			String[] clientes = datosClientes.Split(new[] { Environment.NewLine }, StringSplitOptions.None);
			
			// Vamos linea por linea separando los datos del cliente y colocandolo donde toca
			foreach (string cliente in clientes)
			{
				String[] datosCliente = cliente.Split(new[] { '#' });
				if (datosCliente.Length == 3)
				{
					string nombreCliente = datosCliente[0] + '#' + datosCliente[1];
					string provinciaCliente = datosCliente[2];
					ColocarUsuarioEnProvincia(nombreCliente, provinciaCliente);
				}
			}
		}

		private void ColocarUsuarioEnProvincia(string nombreCliente, string provinciaCliente)
		{
			bool provinciaEncontrada = false;
			
			// Buscamos la provincia y si la encontramos metemos al nuevo cliente
			foreach (InfoProvincia infoProvincia in infoProvincias)
			{
				if (infoProvincia.provincia == provinciaCliente)
				{
					provinciaEncontrada = true;
					infoProvincia.clientes.Add(nombreCliente);
				}
			}

			// Si no la encontramos, creamos una nueva provincia y metemos al cliente tambien
			// (y luego nos guardamos esa provincia en nuestra lista de provincias)
			if (provinciaEncontrada == false)
			{
				InfoProvincia nuevaProvincia = new InfoProvincia();
				nuevaProvincia.provincia = provinciaCliente;
				nuevaProvincia.clientes = new List<string>();
				nuevaProvincia.clientes.Add(nombreCliente);
				infoProvincias.Add(nuevaProvincia);
			}
		}

		private void GuardarFicheroNuevo(InfoProvincia infoProvincia)
		{
			// Creamos fichero de texto en el path con el nombre de la provincia y acabando en .txt
			StreamWriter writer = File.CreateText(filePath + infoProvincia.provincia + ".txt");
			
			// Escribimos cliente a cliente, metiendo newline despues de cada uno
			foreach (string cliente in infoProvincia.clientes)
			{
				writer.Write(cliente + Environment.NewLine);
			}
			writer.Close();
		}

	}
}

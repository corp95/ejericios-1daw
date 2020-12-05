using System;
using System.Text;

// --------------------------------------------
// Daniel Santonja Gosálbez
// 1º DAW
// Modalidad Presencial
// Práctica nº 2
// --------------------------------------------

namespace practica_2
{
	class Program
	{
		static void Main(string[] args)
		{
			string cadena = "0";
			char letra = '▄'; //Le asignamos ese valor raro porque así nos aseguramos que nadie lo va a introducir.
			int contadorIntentos = 0;
			bool letraEncontrada = false;

			Console.Write("Cadena: ");
			cadena = Convert.ToString(Console.ReadLine());

			StringBuilder cadOculta = new StringBuilder(cadena);

			for (int i = 0; i < cadOculta.Length; i++) //Esto es para convertir la palabra en guiones.
			{
				cadOculta[i] = '_';
			}

			do //Aquí vamos sumando los intentos para adivinar.
			{
				letra = '▄'; //Volvemos a ponerlo para inicializarlo.

				while (letra== '▄') //Este while me va a servir por si el usuario introduce un valor vacío.
                {
					Console.Write("Letra: ");

					try
					{
						letra = Console.ReadLine()[0];	/*Con esta línea cogemos sólo la primera letra introducida, 
														 *así no se nos rompe el programa*/
					}
					catch (Exception)
                    {
						Console.WriteLine("Tienes que introducir al menos una letra.");	//En el caso de que ponga un valor vacío, me lo pide de nuevo.					
                    }
				}

				for (int i = 0; i < cadena.Length; i++)  /*Este for se utiliza para recorrer la cadena y 
														  * el if para sustituir  los '_' por la letra introducida
														  * si coincide*/
				{
					if (cadena[i] == char.ToUpper(letra) || cadena[i] == char.ToLower(letra)) /* Compruebo mayuscula y
																							* minuscula y pongo la
																							* letra original*/
					{
						letraEncontrada = true;
						cadOculta[i] = cadena[i];
					}
				}

				if (letraEncontrada == false) //Si no hemos encontrado ninguna letra, sumamos.
				{

					switch(contadorIntentos) //Utilizamos un switch para ir dibujando y sumando intentos fallidos.
                    {
						case 0:
							Console.WriteLine("┌───┐\n│   o\n│\n│\n│\n┴───────\n");
							break;
						case 1:
							Console.WriteLine("┌───┐\n│   o\n│  /\n│\n│\n┴───────\n");
							break;
						case 2:
							Console.WriteLine("┌───┐\n│   o\n│  /|\n│\n│\n┴───────\n");
							break;
						case 3:
							Console.WriteLine("┌───┐\n│   o\n│  /|\\\n│\n│\n┴───────\n"); 
							break;
						case 4:
							Console.WriteLine("┌───┐\n│   o\n│  /|\\\n│  /\n│\n┴───────\n");
							break;
						case 5:
							Console.WriteLine("┌───┐\n│   o\n│  /|\\\n│  / \\\n│\n┴───────\n");
							break;
					}

					contadorIntentos++;

				}

				letraEncontrada = false; //Tenemos que volver a ponerlo en 'false' para volver a inicializarlo.

				for (int i = 0; i < cadOculta.Length; i++) //Este for es para mostrar los '_' con espacios entre si.
				{
					Console.Write("{0} ", cadOculta[i]);

				}
				Console.WriteLine();

			}

			while ((contadorIntentos < 6) && (cadOculta.ToString() != cadena));
			{
				if (cadOculta.ToString() == cadena)
					Console.WriteLine("¡¡¡ENHORABUENA!!!");

				else
					Console.WriteLine("R.I.P. La palabra era: {0}", cadena);
			}

		}
	}
}
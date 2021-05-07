using System.IO;
using System;
namespace Ejercicio_8_1_1
{
    class Program
    {
        static void Main(string[] args)
        {
            StreamWriter fichero;
            String texto;

            using (fichero = new StreamWriter("registroDeUsuario.txt"))
            {
                Console.Write("Texto: ");
                texto = Console.ReadLine();

                while (texto.ToLower() != "fin")
                {
                    fichero.WriteLine(texto);

                    Console.Write("Texto: ");
                    texto = Console.ReadLine();
                }
            }
        }
    }
}

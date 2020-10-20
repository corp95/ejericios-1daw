using System;

namespace Ejercicio_2_2_2_4
{
    class Program
    {
        static void Main(string[] args)
        {
            string password;
            string identificador;

            do
            {
                Console.WriteLine("Introduce tu ID: ");
                identificador = Console.ReadLine();

                Console.WriteLine("Introduce la contraseña: ");
                password = Console.ReadLine();

                if ((identificador == "Pedro") && (password == "Peter"))

                    Console.WriteLine("Contraseña e ID correctos.");
                else
                    Console.WriteLine("ID y contraseña incorrectos.");

            }
            while ((identificador != "Pedro") && (password != "Peter"));


        }
    }
}


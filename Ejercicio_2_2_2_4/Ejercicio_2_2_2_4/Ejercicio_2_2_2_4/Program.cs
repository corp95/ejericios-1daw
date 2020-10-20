using System;

namespace Ejercicio_2_2_2_4
{
    class Program
    {
        static void Main(string[] args)
        {
            int password;
            int identificador;

            do
            {
                Console.WriteLine("Introduce tu ID: ");
                identificador = Convert.ToInt32(Console.ReadLine());

                Console.WriteLine("Introduce la contraseña: ");
                password = Convert.ToInt32(Console.ReadLine());

                if ((identificador == 1234)&&(password==1111))

                    Console.WriteLine("Contraseña e ID correctos.");
                else
                    Console.WriteLine("ID y contraseña incorrectos.");

            }
            while ((identificador!= 1234) && (password != 1111));
            

        }
    }
}

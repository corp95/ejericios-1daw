using Microsoft.VisualBasic;
using System;

namespace Ejercicio_2_1_9_3
{
    class Program
    {
        static void Main(string[] args)
        {
            string letra;

            Console.WriteLine("Pulsa cualquier tecla: ");
            letra = Console.ReadLine();

            switch (letra)
            {
                case ("a"):
                case ("e"):
                case ("i"):
                case ("o"):
                case ("u"): Console.WriteLine("{0} es una vocal.", letra);
                    break;
                case ("1"):
                case ("2"):
                case ("3"):
                case ("4"):
                case ("5"):
                case ("6"):
                case ("7"):
                case ("8"):
                case ("9"):
                case ("0"): Console.WriteLine("{0} es una cifra numérica.", letra);
                    break;

                default: Console.WriteLine("{0} es una consonante.",letra);
                    break;

            }
        }
    }
}

using System;

namespace Ejercicio_1_11_4
{
    class Program
    {
        static void Main(string[] args)
        {
            double celsius;
            double fahrenheit;
            double kelvin;
          
            Console.WriteLine("Introduce los grados celsius a conversionar: ");
            celsius = Convert.ToInt32(
                Console.ReadLine());

                kelvin = celsius + 273;
                fahrenheit = celsius * 18 / 10 + 32;

            Console.WriteLine("{0} grados celsius son {1} kelvin y {2} fahrenheit", celsius, kelvin, fahrenheit);
        }
    }
}

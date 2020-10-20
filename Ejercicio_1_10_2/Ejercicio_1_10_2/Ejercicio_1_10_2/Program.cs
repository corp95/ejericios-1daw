using System; //si pongo esta linea de codigo no hace falta poner System mas adelante

namespace Ejercicio_1_10_2
{
    class Program
    {
        static void Main(string[] args)
        {
            int numero1;
            int numero2;
            int division;
            int resto;

            Console.Write("Introduce el primer número: ");
            numero1 = Convert.ToInt32(
                Console.ReadLine());
            Console.Write("Introduce el segundo número: ");
            numero2 = Convert.ToInt32(
                Console.ReadLine());
            division = numero1 / numero2;
            resto = numero1 % numero2;

            Console.WriteLine("El resultado de {0} entre {1} es: {2} y su resto es {3}", numero1, numero2, division, resto);
            
        }
    }
}

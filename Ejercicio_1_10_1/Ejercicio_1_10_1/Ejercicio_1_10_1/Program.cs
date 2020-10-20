using System; //si pones esta linea de comando no tendremos que poner system luego

namespace Ejercicio_1_10_1
{
    class Program
    {
        static void Main(string[] args)
        {
            int numero1;
            int numero2;
            int resultado;

            Console.WriteLine("Introduce el primer número:");
            numero1 = Convert.ToInt32(
                Console.ReadLine());
            Console.WriteLine("Introduce el segundo número:");
            numero2 = Convert.ToInt32(
                Console.ReadLine());
            resultado = numero1 * numero2;
            Console.WriteLine("El resultado de {0} * {1} es {2}", numero1, numero2, resultado);
        }
    }
}

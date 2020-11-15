using System;

namespace practica1
{
    class Program
    {
        // --------------------------------------------
        // Daniel Santonja Gosálbez
        // DAW
        // Modalidad Presencial
        // Práctica nº 1
        // --------------------------------------------

        static void Main(string[] args)
        {
            double numero=0; //El número con el que operar
            double numeroInicial=0; //Es el primer número que introduces, también da el resultado final de la operación.
            string operacion="s"; //Para introducir las operaciones del switch


            Console.Write("Introduce un número: ");
            numeroInicial  = Convert.ToDouble(Console.ReadLine()); //Aquí se introduce el primer número
          

            do
            {
                try //Aqui iniciamos el try
                {
                    Console.Write("Introduce una operación: ");
                    operacion = Convert.ToString(Console.ReadLine()); //Aqui introducimos el carácter para operar


                    switch (operacion) //switch con las operaciones según el char que introduzcamos
                    {
                        case "+":      //Suma

                            Console.Write("Introduce un número: ");
                            numero = Convert.ToDouble(Console.ReadLine());
                            numeroInicial += numero;
                            break;

                        case "-":      //Resta

                            Console.Write("Introduce un número: ");
                            numero = Convert.ToDouble(Console.ReadLine());
                            numeroInicial -= numero;
                            break;

                        case "*":      //Multiplicación

                            Console.Write("Introduce un número: ");
                            numero = Convert.ToDouble(Console.ReadLine());
                            numeroInicial *= numero;
                            break;

                        case "/":      //División

                            Console.Write("Introduce un número: ");
                            numero = Convert.ToDouble(Console.ReadLine());
                            numeroInicial /= numero;
                            break;

                        case "=":      //El resultado
                            Console.Write("El resultado es {0}", numeroInicial);
                            Console.WriteLine();
                            Console.WriteLine();

                            Console.Write("Introduce un número: "); //El programa pide otro número para hacer una nueva operación.
                            numeroInicial = Convert.ToDouble(Console.ReadLine());
                            break;

                        case "s":
                            Console.Write("El resultado es {0}", numeroInicial); /*Ponemos este case para que cuando pulses "s" no solo te saque del programa
                                                                                   sino que te de el resultado de la operación.*/
                            break;

                        default:
                            Console.Write("--> Operación incorrecta");
                            Console.WriteLine();

                            break;
                    }
                }
                catch (FormatException) //Salta la excepción
                {
                    Console.Write("--> Número incorrecto");
                    Console.WriteLine();
                    Console.Write("Introduce un número: ");
                    numero = Convert.ToDouble(Console.ReadLine());
                    
                }
            }
           while (operacion!="s"); //Si pulsamos una "s" en operación sale el mensaje: FIN DE PROGRAMA 
                {
                Console.WriteLine();
                    Console.Write("FIN DEL PROGRAMA");
                }
            
        }
    }
}

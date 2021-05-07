using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace dia1pablo
{
    class persona
    {
        string nombre;


        public void SetNombre(string NuevoNombre)
        {
            nombre = NuevoNombre;
        }

        public void Saludar()
        {
            Console.WriteLine("Hola, soy {0}", nombre); // Como hacerlo en wpf
        }
    }

    class PruebaPersona
    {
        // como acabar el puto ejercicio
    }
}

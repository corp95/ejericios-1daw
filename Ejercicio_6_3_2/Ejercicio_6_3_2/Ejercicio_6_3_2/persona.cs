using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_6_3_2
{
    class persona
    {
        private string nombre;

        public void SetPersona(string nombre)
        {
            this.nombre = nombre;   
        }

        public string GetPersona()
        {
            return this.nombre;
        }
        
        public string Saludar()
        {
            return "Hola, soy " + this.nombre;
        }
    }
}

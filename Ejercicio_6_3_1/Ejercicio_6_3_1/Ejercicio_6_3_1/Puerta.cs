using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_6_3_1
{
    class Puerta
    {
        public int alto;
        private int Ancho;
        private string color;


        public void SetColor(string color)
        {
            this.color = color;
        

        }
        public string GetColor()
        {
            return this.color;
        }
        /// <summary>
        /// Poner ancho. Si es menor de 75 y mayor de 120 saltará una excepción.
        /// </summary>
        public void SetAncho(int ancho)
        {
            if (Ancho < 75 || Ancho > 120)
            {
                throw new ArgumentException("Error. Ancho incorrecto.");
            }
            else
                this.Ancho =  ancho;
        }
    }
}

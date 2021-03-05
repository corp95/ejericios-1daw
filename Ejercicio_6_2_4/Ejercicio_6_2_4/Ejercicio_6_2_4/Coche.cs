using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_6_2_4
{
    class Coche
    {
        string marca;
        string modelo;
        int cilindrada;
        double potencia;

        public string GetMarca()
        {
            return marca;
        }

        public void SetMarca(string nuevaMarca)
        {
            marca = nuevaMarca;
        }

        public string GetModelo()
        {
            return modelo;
        }

        public void SetModelo(string nuevoModelo)
        {
            modelo = nuevoModelo;
        }

        public int GetCilindrada()
        {
            return cilindrada;
        }

        public void SetCilindrada(int nuevaCilindrada)
        {
            cilindrada = nuevaCilindrada;
        }

        public double GetPotencia()
        {
            return potencia;
        }

        public void SetPotencia(double nuevaPotencia)
        {
            potencia = nuevaPotencia;
        }

        public string MostrarEstado()
        {
            return "Marca: " + this.marca + "\n" + "Modelo: " + this.modelo + "\n" +
                   "Cilindrada " + this.cilindrada + "\n" + "Potencia: " + this.potencia;            
        }

    }
}

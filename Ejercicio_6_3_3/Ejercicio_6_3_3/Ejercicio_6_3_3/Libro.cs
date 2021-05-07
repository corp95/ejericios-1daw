using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_6_3_3
{
    class Libro
    {
        string autor;
        string titulo;
        string ubicacion;

        public string GetAutor()
        {
            return autor;
        }

        public void SetAutor(string nuevoAutor)
        {
            autor = nuevoAutor;
        }

        public string GetTitulo()
        {
            return titulo;
        }

        public void SetTitulo(string nuevoTitulo)
        {
            titulo = nuevoTitulo;
        }

        public string GetUbicacion()
        {
            return ubicacion;
        }

        public void SetUbicacion(string nuevaUbicacion)
        {
            ubicacion = nuevaUbicacion;
        }

        public string MostrarEstado()
        {
            return "Autor: " + this.autor + "\n" + "Título: " + this.titulo + "\n" +
                   "Ubicación: " + this.ubicacion;
        }
    }
}

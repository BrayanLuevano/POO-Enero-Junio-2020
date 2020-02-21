using System;
using System.Collections.Generic;
namespace Peliculas
{
    class Peliculas
    {
        public string Titulo;
        public Int16 Año;
        public string  Pais;
        public string Director;

        public void SetTitulo(string Titulo)
        {
            this.Titulo = Titulo;
        }
        public string GetTitulo()
        {
            return this.Titulo;
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            
        }
    }
}

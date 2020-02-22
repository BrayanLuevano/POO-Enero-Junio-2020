using System;
using System.Collections.Generic;

namespace Peliculas
{
    class Peliculas
    {
        private string Titulo;
        private Int16 Año;
        private string  Pais;
        private string Director;

        public void SetTitulo(string Titulo)
        {
            this.Titulo = Titulo;
        }
        public string GetTitulo() => Titulo;

        public void SetAño(Int16 Año)
        {
            this.Año = Año;
        }
        public Int16 GetAño() => Año;

        public void SetPais(string Pais)
        {
            this.Pais = Pais;
        }
        public string GetPais() => Pais;

        public void SetDirector(string Director) 
        {
            this.Director = Director;
        }
        public string GetDirector() => Director;

        public Peliculas()
        {

        }
        public Peliculas(string Titulo, Int16 Año, string Pais, string Director)
        {
            this.Titulo = Titulo;
            this.Año = Año;
            this.Pais = Pais;
            this.Director = Director;
        }
        public void Imprime()
        {
            Console.WriteLine("{0}, {1}, {2}, {3}", this.Titulo, this.Año, this.Director, this.Pais);
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Peliculas Pelicula1 = new Peliculas();
            Pelicula1.SetTitulo("Peppermint");
            Pelicula1.SetAño(2018);
            Pelicula1.SetPais("Estados Unidos");
            Pelicula1.SetDirector("Pierre Morel");
            Console.WriteLine("{0}, ({1}), {2}, {3}", Pelicula1.GetTitulo(), Pelicula1.GetAño(), Pelicula1.GetPais(), Pelicula1.GetDirector());

            Peliculas Pelicula2 = new Peliculas();
            Pelicula2.SetTitulo("No manches frida 2");
            Pelicula2.SetAño(2019);
            Pelicula2.SetPais("Mexico");
            Pelicula2.SetDirector("Nacho G. Velilla");
            Console.WriteLine("{0}, ({1}), {2}, {3}", Pelicula2.GetTitulo(), Pelicula2.GetAño(), Pelicula2.GetPais(), Pelicula2.GetDirector());
        }
    }
}
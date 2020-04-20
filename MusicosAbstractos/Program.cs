using System;
using System.Collections.Generic;

namespace MusicosAbstractos
{

    abstract class Musico
    {
        protected string nombre;

        public Musico(string n)
        {
            nombre = n;
        }

        public abstract void Afina();

        public abstract void Saluda();

        public abstract void Toca();

        public void printMusico()
        {
            Console.WriteLine(nombre);
        }
    }

    class Baterista:Musico
    {
        protected string Bateria;
        public Baterista(string nombre, string Bateria):base(nombre)
        {
            this.Bateria = Bateria;
        }

        public override void Afina()
        {
            Console.WriteLine("{0}: Esta afinando su instrumento {1}", nombre, Bateria);
        }
        public override void Saluda()
        {
            Console.WriteLine("Hola, Yo soy el Baterista {0}, y mi Bateria es una {1}", nombre, Bateria);
        }
        
        public override void Toca()
        {
            Console.WriteLine("{0}: Esta tocando su instrumento {1}", nombre, Bateria);
        }
    }

    class Bajista:Musico
    {
        protected string Bajo;
        public Bajista(string nombre, string Bajo):base(nombre)
        {
            this.Bajo = Bajo;
        }
        public override void Afina()
        {
            Console.WriteLine("{0}: Esta afinando su instrumento {1}", nombre, Bajo);
        }
        public override void Saluda()
        {
            Console.WriteLine("Hola, Yo soy el Bajista {0}, y mi Bajo es un {1}", nombre, Bajo);
        }
        public override void Toca()
        {
            Console.WriteLine("{0}: Esta tocando su instrumento {1}", nombre, Bajo);
        }
    }

    class Guitarrista:Musico
    {
        protected string Guitarra;
        public Guitarrista(string nombre, string Guitarra):base(nombre)
        {
            this.Guitarra = Guitarra;
        }
        public override void Afina()
        {
            Console.WriteLine("{0}: Esta afinando su instrumento {1}", nombre, Guitarra);
        }
        public override void Saluda()
        {
            Console.WriteLine("Hola, Yo soy el Guitarrista {0}, y mi Guitarra es una {1}", nombre, Guitarra);
        }
        public override void Toca()
        {
            Console.WriteLine("{0}: Esta tocando su instrumento {1}", nombre, Guitarra);
        }
    }
    class Pianista:Musico
    {
        protected string Piano;
        public Pianista(string nombre, string Piano):base(nombre)
        {
            this.Piano = Piano;
        }
        public override void Afina()
        {
            Console.WriteLine("{0}: Esta afinando su instrumento {1}", nombre, Piano);
        }
        public override void Saluda()
        {
            Console.WriteLine("Hola, Yo soy el Pianista {0}, y mi Piano es un {1}", nombre, Piano);
        }
        public override void Toca()
        {
            Console.WriteLine("{0}: Esta tocando su instrumento {1}", nombre, Piano);
        }
    }
    class Violinista:Musico
    {
        protected string Violin;
        public Violinista(string nombre, string Violin):base(nombre)
        {
            this.Violin = Violin;
        }
        public override void Afina()
        {
            Console.WriteLine("{0}: Esta afinando su instrumento {1}", nombre, Violin);
        }
        public override void Saluda()
        {
            Console.WriteLine("Hola, Yo soy el Violinista {0}, y mi Violin es un {1}", nombre, Violin);
        }
        public override void Toca()
        {
            Console.WriteLine("{0}: Esta tocando su instrumento {1}", nombre, Violin);
        }
    }
    class Saxofonista:Musico
    {
        protected string Saxofon;
        public Saxofonista(string nombre, string Saxofon):base(nombre)
        {
            this.Saxofon = Saxofon;
        }
        public override void Afina()
        {
            Console.WriteLine("{0}: Esta afinando su instrumento {1}", nombre, Saxofon);
        }
        public override void Saluda()
        {
            Console.WriteLine("Hola, Yo soy el Saxofonista {0}, y mi Saxofon es un {1}", nombre, Saxofon);
        }
        public override void Toca()
        {
            Console.WriteLine("{0}: Esta tocando su instrumento {1}", nombre, Saxofon);
        }
    }
    class Trompetista:Musico
    {
        protected string Trompeta;
        public Trompetista(string nombre, string Trompeta):base(nombre)
        {
            this.Trompeta = Trompeta;
        }
        public override void Afina()
        {
            Console.WriteLine("{0}: Esta afinando su instrumento {1}", nombre, Trompeta);
        }
        public override void Saluda()
        {
            Console.WriteLine("Hola, Yo soy el Trompetista {0}, y mi Trompeta es una {1}", nombre, Trompeta);
        }
        public override void Toca()
        {
            Console.WriteLine("{0}: Esta tocando su instrumento {1}", nombre, Trompeta);
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            List<Musico> Musicos = new List<Musico>();
            Musicos.Add(new Baterista("Joseph", "DW Drums"));
            Musicos.Add(new Bajista("Brayan", "Fender"));
            Musicos.Add(new Guitarrista("Raul", "Gibson"));
            Musicos.Add(new Pianista("Arath", "Schimmel"));
            Musicos.Add(new Violinista("Alberto", "Yamaha"));
            Musicos.Add(new Saxofonista("Ignacio", "Selmer"));
            Musicos.Add(new Trompetista("Luis", "Kaizer"));


            foreach(var M in Musicos)
            {
                M.Afina();
            }


            foreach(var M in Musicos)
            {
                M.Saluda();
            }


            foreach(var M in Musicos)
            {
                M.Toca();
            }
        }
    }
}
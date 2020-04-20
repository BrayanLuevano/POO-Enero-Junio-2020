using System;
using System.Collections.Generic;

namespace Ilustrador
{
    abstract class Figura 
    {
        protected int x;
        protected int y;
        protected string color;

        public Figura(int x, int y, string c)
        {
            this.x = x; this.y = y; color = c;
        }

        public abstract void dibuja();
        

        public void printColor() 
        {
            Console.WriteLine(color);
        }
    }

    class Circulo : Figura 
    {
        public Circulo(int x, int y, string c):base(x , y, c)
        {

        }

        public override void dibuja()
        {
            Console.WriteLine("Se dibuja un Circulo {0}", color);
        }
    }

    class Rectangulo : Figura 
    {
        public Rectangulo(int x, int y, string c):base(x , y, c)
        {

        }

        public override void dibuja()
        {
            Console.WriteLine("Se dibuja un Rectangulo {0}", color);
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            List<Figura> figuras = new List<Figura>();
            figuras.Add(new Circulo(12,13,"Verde"));
            figuras.Add(new Rectangulo(12,13,"Azul"));
            figuras.Add(new Rectangulo(12,13,"Rojo"));
            figuras.Add(new Circulo(12,13,"Rojo"));
            foreach (var item in figuras)
            {
                item.dibuja();
            }    
            Circulo r = new Circulo(10,10,"Rojo");
            r.dibuja();
        }
    }
}
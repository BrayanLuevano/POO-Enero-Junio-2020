using System;

namespace Domino
{
    class Domino
    {
        public int Do1;
        public int Do2;

        public Domino (int Do1, int Do2)
        {
            this.Do1 = Do1;
            this.Do2 = Do2;
        }

        public static int operator + (Domino Do1, Domino Do2) => (Do1.Do1 + Do1.Do2 + Do2.Do1 + Do2.Do2);
    }
    class Program
    {
        static void Main(string[] args)
        {
            Domino Do1 = new Domino (5,6);
            Domino Do2 = new Domino (4,3);
            
            Console.WriteLine("La suma de los 2 Dominos es: " + (Do1 + Do2));
        }
    }
}
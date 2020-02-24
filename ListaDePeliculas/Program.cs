using System;
using System.Collections.Generic;
namespace ListaDePeliculas
{
    class ListaDePeliculas
    {
        
    }
    class Program
    {
        static void Main(string[] args)
        {
            List <String> Lista = new List<String>();
            Lista.Add("1-. Peppermint");
            Lista.Add("2-. No manches frida 2");
            Lista.Add("3-. Me gusta, pero me asusta");
            Lista.Add("4-. Que culpa tiene el niño");
            Lista.Add("5-. Avengers End Game");

            foreach (String ListaDePeliculas in Lista)
            Console.WriteLine(ListaDePeliculas);
        }
    }
}
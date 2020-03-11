using System;

namespace PasoDeParametros
{
    class TarjetaCredito
    {
        public string Num;
        public string NIP;
        public TarjetaCredito()
        {
            Num =  "4356785432189054";
            NIP = "093";
        }
        class Oculto
        {
            public static void Ocultos(TarjetaCredito tc)
            {
                tc.Num = "XXXXXXXXXXXXXXXX";
                tc.Num = "NEW";
            }
        }

        public static void cambiar(ref TarjetaCredito tc)
        {
            tc = new TarjetaCredito();
            tc.Num = "NEW";
        }
    class Program
    {
        static void Main(string[] args)
        {
            
        }
    }
}

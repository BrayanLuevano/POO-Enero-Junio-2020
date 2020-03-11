using System;

namespace PasoDeParametros
{
    class TarjetaDebito
    {
        public string NumTar;
        public string NIP;
        public TarjetaDebito()
        {
            NumTar =  "4356785432189054";
            NIP = "093";
        }
    }
        class Oculto
        {
            public static void Ocultos(TarjetaDebito TD)
            {
                TD.NumTar = "XXXXXXXXXXXXXXXX";
                TD.NIP = "XXX";
            }
            public static void Cambiar(ref TarjetaDebito TD)
            {
                TD = new TarjetaDebito();
                TD.NumTar = "NEW";
            }
        }
    class Program
    {
        static int Suma(int Saldo, int IVA) => Saldo + IVA;
        static void Suma(int Saldo, int IVA, out int Resultado) => Resultado = Saldo + IVA;

        static void Main(string[] args)
        {
            Console.WriteLine("Numero de Tarjeta: ");
            TarjetaDebito TD = new TarjetaDebito();
            Console.WriteLine(TD.NumTar);
            Oculto.Ocultos(TD);
            Console.WriteLine(TD.NIP);
            Oculto.Ocultos(TD);
            int Saldo = 800;
            int Deposito = 500;
            int Resultado;
            Console.WriteLine("Saldo Total Disponible: ");
            Suma(Saldo, Deposito, out Resultado);
            Console.WriteLine(Resultado);
        }
    }
}
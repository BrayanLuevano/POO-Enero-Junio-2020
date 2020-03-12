using System;

namespace PasoDeParametros
{
    class TarjetaDebito
    {
        public string Titular;
        public string NumTar;
        public string NIPTar;
        public string TipoDeTarjeta;
        public string BancoTarjeta;
        public TarjetaDebito()
        {
            Titular = "Brayan Luevano";
            NumTar =  "4356 7854 3218 9054";
            NIPTar = "272";
            TipoDeTarjeta = "VISA";
            BancoTarjeta = "HSBC";
        }
    }
        class Oculto
        {
            public static void Ocultos(TarjetaDebito TD)
            {
                TD.NumTar = "**** **** **** ****";
                TD.NIPTar = "***";
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
            Console.WriteLine("NIP de Tarjeta: ");
            Console.WriteLine(TD.NIPTar);
            Oculto.Ocultos(TD);
            Console.WriteLine("Nombre titular de Tarjeta: ");
            Console.WriteLine(TD.Titular);
            Console.WriteLine("Tipo de tarjeta y Banco de tarjeta: ");
            Console.WriteLine(TD.TipoDeTarjeta);
            Console.WriteLine(TD.BancoTarjeta);
            int SaldoCuenta = 800;
            int DepositoCuenta = 500;
            int Resultado;
            Console.WriteLine("Saldo Total Disponible: ");
            Suma(SaldoCuenta, DepositoCuenta, out Resultado);
            Console.WriteLine(Resultado);
        }
    }
}
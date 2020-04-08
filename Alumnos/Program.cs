using System;

namespace Alumnos
{
    class Alumnos
    {
        protected string Nombre;
        protected string Carrera;

        public Alumnos(string Nombre, string Carrera)
        {
            this.Nombre = Nombre;
            this.Carrera = Carrera;
        }

        public virtual void Print()
        {
            Console.WriteLine("Mi nombre es: {0}. , Estudio la Carrera de: {1}", Nombre, Carrera);
        }
    }

    class Licenciatura:Alumnos
    {
        protected string ServicioSocial;
        protected string Residencia;

        public Licenciatura(string Nombre, String Carrera, string ServicioSocial, string Residencia):base(Nombre, Carrera)
        {
            this.ServicioSocial = ServicioSocial;
            this.Residencia = Residencia;
        }

        public override void Print()
        {
            Console.WriteLine("Mi nombre es: {0}. ,Estudio en la Carrera de: {1}, Hare mi Servicio Social en: {2}, La Residencia Profesional la hare en: {3}", Nombre, Carrera, ServicioSocial, Residencia);
        }
    }    

    class Posgrado:Alumnos
    {
        protected string TemaInvestigacion;

        public Posgrado(string Nombre, string Carrera, string TemaInvestigacion):base(Nombre, Carrera)
        {
            this.TemaInvestigacion = TemaInvestigacion;
        }

        public new void Print()
        {
            Console.WriteLine("Mi nombre es: {0}. , Estudio en la Maestria de: {1}, Mi Tema de Investigacion es: {2},", Nombre, Carrera, TemaInvestigacion);
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Alumnos Jose = new Alumnos("Jose", "ING. Sistemas");
            Licenciatura Sofia = new Licenciatura("Sofia", "ING. Sistemas", "ITT", "SONY");
            Posgrado Ernesto = new Posgrado("Ernesto", "Ciencias en Tecnologias Avanzadas", "Inteligencia Artificial" );

            Jose.Print();
            Sofia.Print();
            Ernesto.Print();

        }
    }
}
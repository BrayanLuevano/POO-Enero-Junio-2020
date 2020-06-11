using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace ProyectoFinalProducto
{
	//Se crea la clase Producto
	class Producto
	{
		public string Codigo;
		public string Descripcion;
		public decimal Precios;
		public int Departamento;
		public int Likes;

		//Se muestra el Constructor
		public Producto(string Code, string Descrip, decimal Prc, int Dep, int Lks)
		{
			Codigo = Code;
			Descripcion = Descrip;
			Precios = Prc;
			Departamento = Dep;
			Likes = Lks;
		}
		
	}
	//Se crea la clase ProductoDB
	class ProductoDB
	{
		//Se crea una Lista de producto
		public List<Producto> Productos = new List<Producto>();
		//Aqui escribe en el documento de Texto
		public void WriteToTXT(string Archivo)
		{
			//Se encarga de llevar a cabo todas las operaciones
			try
			{
				List<Producto> Productos = new List<Producto>();
				//Clase que abre archivo
				FileStream FS = new FileStream(Archivo, FileMode.OpenOrCreate, FileAccess.Write);
				using(StreamWriter txtOut = new StreamWriter(FS))
				//Transcribe
				{
					foreach(Producto P in Productos)
					{
						txtOut.WriteLine("{0}|{1}|{2}|{3}|{4}", P.Codigo, P.Descripcion, P.Precios, P.Departamento, P.Likes);
					}
				}			
			}
			//Cuando atrapa los errores o captura el error.
			catch(Exception Ex)
			{
                Console.WriteLine("Se ha producido un error");
                Console.WriteLine(Ex.Message);
            }
		}

		class PrecioFecha
		{
			DateTime FechaInicio;
			DateTime FechaFinal;
			Decimal Precio;
		}
		
		//Aqui lee en el documento de texto
		public void ReadToTXT(string Archivo)
		{
			//Se encarga de llevar a cabo todas las operaciones
			try
			{

				List<Producto> Productos = new List<Producto>();
				//Clase que abre archivo
				FileStream FS1 = new FileStream(Archivo, FileMode.Open, FileAccess.Read);
				using(StreamReader txtOut = new StreamReader(FS1))

				{
					string Line;
					//Va verificando desde el primer hasta el ultimo renglon
					while((Line = txtOut.ReadLine()) != null)
					{
						//Aqui divide el Constructor
						string[] Columnas = Line.Split("|");
						Productos.Add(new Producto(Columnas[0], Columnas[1], Decimal.Parse(Columnas[2]), int.Parse(Columnas[3]), int.Parse(Columnas[4])));
					}
				}
			}
			//Cuando atrapa los errores o captura el error.
			catch(Exception Ex)
			{
                Console.WriteLine("Se ha producido un error");
                Console.WriteLine(Ex.Message);
            }
		}

		//Aqui escribe en el Archivo BIN
		public void WriteToBIN(string Archivo)
		{
			//Se encarga de llevar a cabo todas las operaciones
			try
			{
				List<Producto> Productos = new List<Producto>();
				//Clase que abre archivo 
				FileStream FS = new FileStream(Archivo, FileMode.OpenOrCreate, FileAccess.Write);
				//Transcribe a archivo BIN
				using (BinaryWriter BinOut = new BinaryWriter(FS))
				{
					foreach(Producto P in Productos)
					{
						BinOut.Write(P.Codigo);
						BinOut.Write(P.Descripcion);
						BinOut.Write(P.Precios);
						BinOut.Write(P.Departamento);
						BinOut.Write(P.Likes);
					}
				}
			}
			//Cuando atrapa los errores o captura el error.
			catch(Exception Ex)
			{
                Console.WriteLine("Se ha producido un error");
                Console.WriteLine(Ex.Message);
            }
		}
		//Aqui lee en el Archivo BIN
		public void ReadToBIN(string Archivo)
		{
			//Se encarga de llevar a cabo todas las operaciones
			try
			{
				List<Producto> Productos = new List<Producto>();
				FileStream FS1 = new FileStream(Archivo, FileMode.Open, FileAccess.Read);
				using(BinaryReader BinIn = new BinaryReader(FS1))
				{
					//Regresa los productos en producto
					while(BinIn.PeekChar() != -1)
					{
						Productos.Add(new Producto(BinIn.ReadString(), BinIn.ReadString(), BinIn.ReadDecimal(), BinIn.ReadInt32(), BinIn.ReadInt32()));
					}
				}
			}
			//Cuando atrapa los errores o captura el error.
			catch(Exception Ex)
			{
                Console.WriteLine("Se ha producido un error");
                Console.WriteLine(Ex.Message);
            }
		}

		public void GetDepartment(int Depto)
		{
			//Enumera los productos
			IEnumerable <Producto> Q =
			from P in Productos
			//Compara los productos
			where P.Departamento == Depto
			select P;
			Console.WriteLine("Departamento: " + Depto);
			foreach(Producto P in Q)
			{
				Console.WriteLine("{0},{1},{2},{3},{4}", P.Codigo, P.Descripcion, P.Precios, P.Departamento, P.Likes);
			}
		}		
		//Aqui se imprimen los productos
		public void Imprime()
		{
			Console.WriteLine("Los productos son: ");
			foreach(Producto P in Productos)
			{
                Console.WriteLine("{0},|{1},|{2},|{3},|{4}", P.Codigo, P.Descripcion, P.Precios, P.Departamento, P.Likes);
            }
		}
	}
	class Program
	{
		static void Main(string[] args)
		{
			//Aqui se muestra la lista de los productos
			ProductoDB PA = new ProductoDB();
			PA.Productos.Add(new Producto("AUDI431" , "Audifonos", 320, 2, 510));
			PA.Productos.Add(new Producto("SSD4355" , "SSD", 720, 4, 35));
			PA.Productos.Add(new Producto("TV17893" , "Television", 2000, 2, 100));
			PA.Productos.Add(new Producto("CAR2578" , "Cargador", 407, 5, 77));
			//Se imprimen los productos
            PA.Imprime();
			//Nombres de los archivos .txt y .bin
			PA.WriteToTXT("Productos.txt");
			PA.WriteToBIN("Productos.bin");
			//Departamento en el que se encuentra el producto
            PA.GetDepartment(2);			
		}
	}
}
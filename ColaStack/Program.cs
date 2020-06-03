using System;

namespace Cola
{
	public class Cola <T>
	{
		readonly int TamañoCola;
		int PunteroCola = 0;
		T[] Items;
		public Cola() : this(100)
        {

        }
		public Cola(int TamCol)
		{
			TamañoCola = TamCol;
			Items = new T[TamañoCola];
		}
		public void Push(T item)
		{
			if (PunteroCola >= TamañoCola)
				throw new StackOverflowException();
			Items[PunteroCola] = item;
			PunteroCola++;
		}
		public T Pop()
		{			
			if (PunteroCola > 0)
			{
				T item = Items[0];
				for (int i=1; i < PunteroCola; i++)
				{
					Items[i-1]=Items[i];					
				}
				PunteroCola--;
				return item;
			}
			else
			{
				PunteroCola = 0;
				throw new InvalidOperationException("Stack Vacio");
			}
		}
	}
	class Program
	{
		static void Main(string[] args)
		{
			Cola<string> Lista = new Cola<string>(3);
			Lista.Push("Luevano");
			Lista.Push(" ");
			Lista.Push("Gomez");
			for(int i = 0; i < 3; i++)
			{
				Console.Write(Lista.Pop());
			}
		}
	}
}
using System;

namespace ProgVisual
{
	class Program
	{
		static void ImprimaFibonacciIngenuo(int valor)
		{
			int[] valores = new int[valor];
			if(valor >= 0)
			{
				valores[0] = 0;
			}
			if(valor >= 1)
			{
				valores[1] = 1;
			}
			for(int i = 2; i < valores.Length; i++)
			{
				valores[i] = valores[i-1] + valores[i-2];
			}
			for(int i = 0; i < valores.Length; i++)
			{
				Console.WriteLine(valores[i]);
			}
		}
		
		static void ImprimaFibonacciEsperto(int valor)
		{
			int penultimo = 0;
			int ultimo = 1;
			if(valor >= 0)
			{
				Console.WriteLine(penultimo);
			}
			if(valor >= 1)
			{
				Console.WriteLine(ultimo);
			}
			for(int i = 2; i < valor; i++)
			{
				int temp = penultimo;
				penultimo = ultimo;
				ultimo = ultimo + temp;
				Console.WriteLine(ultimo);
			}
		}
		
		static int FibonacciRecursivo(int valor)
		{
			if(valor == 0 || valor == 1)
			{
				return valor;
			}
			else
			{
				return FibonacciRecursivo(valor - 1) + FibonacciRecursivo(valor - 2);	
			}
		}
		
		public static void Main(string[] args)
		{
			Console.WriteLine("Sequencia de Fibonacci");
			int valor = 0;
			while(true)
			{
				try
				{
					Console.WriteLine("Insira um numero inteiro positivo:");
					valor = int.Parse(Console.ReadLine());
					if(valor < 0)
					{
						throw new Exception("Valor precisa ser maior ou igual a zero");
					}
					break;
				}
				catch(Exception e)
				{
					Console.WriteLine(e.Message);
				}
			}
			ImprimaFibonacciEsperto(valor);
			Console.Write("Pressione 'enter' para sair ");
			Console.ReadLine();
		}
	}
}
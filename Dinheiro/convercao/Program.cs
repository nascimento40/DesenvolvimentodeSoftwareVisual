using System;

namespace ProgVisual
{
	class Program
	{
		public static void Main(string[] args)
		{
			Console.WriteLine("Conversor de moedas");
			double valor = 0.0;
			while(true)
			{
				try
				{
					Console.WriteLine("Insira um valor em reais:");
					valor = double.Parse(Console.ReadLine());
					break;
				}
				catch(Exception e)
				{
					Console.WriteLine(e.Message);
				}
			}
			Console.WriteLine("Valor em reais: "   + valor);
			Console.WriteLine("Valor em dolares: " + (valor / 5.17));
			Console.WriteLine("Valor em euros: "   + (valor / 6.14));
			Console.WriteLine("Valor em pesos: "   + (valor / 0.05));
			Console.Write("Pressione 'enter' para sair");
			Console.ReadLine();
		}
	}
}

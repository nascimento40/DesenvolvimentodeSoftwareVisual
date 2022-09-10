using System;

namespace calculadora
{
	class Program
	{
		static double CalculaArea(double largura, double altura)
		{
			return largura * altura;
		}
		
		public static void Main(string[] args)
		{
			double largura = 0.0;
			double altura = 0.0;
			Console.WriteLine("Bem vindo a calculadora de area! :v");
			while(true)
			{
				try
				{
					Console.WriteLine("Insira uma largura:");
					largura = double.Parse(Console.ReadLine());
					break;
				}
				catch(Exception e)
				{
					Console.WriteLine(e.Message);
				}
			}
			while(true)
			{
				try
				{
					Console.WriteLine("Agora insira uma altura:");
					altura = double.Parse(Console.ReadLine());
					break;
				}
				catch(Exception e)
				{
					Console.WriteLine(e.Message);
				}
			}
			Console.WriteLine("A area eh " + CalculaArea(largura, altura));
			Console.Write("Pressione 'enter' para sair");
			Console.ReadLine();
		}
	}
}

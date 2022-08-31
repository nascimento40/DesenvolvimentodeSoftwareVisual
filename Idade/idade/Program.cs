using System;

namespace idade
{
	class Program
	{
		
		public static void Main(string[] args)
		{
            Console.WriteLine("Digite a idade: ");
            int idade = 0;
            
            if (idade <= 13) {
            Console.WriteLine("Criança");
            } else if (idade > 13 && idade <= 18) {
            Console.WriteLine("Adolescente");
            } else if (idade > 18 && idade <= 60) {
            Console.WriteLine("Adulto");
            } else if (idade > 60) {
            Console.WriteLine("Idoso");
            }
		}
	}
}

using System;

namespace aula2
{
    class Program
    {
        static void calcularMedia(double[] numeros)
        {
            double soma = 0;
            for(int i = 0; i < numeros.Length; i++){
                soma += numeros [i];
            }
            double media = soma / numeros.Length;
            Console.WriteLine("A média dos números é: " + media);
        }

        static void calcularMediana(double[] numeros)
        {
            Array.Sort(numeros);
            int meio = numeros.Length / 2;
            Console.WriteLine("A mediana dos números é: " + numeros[meio]);
        }

        static void Main(string[] args)
        {
            Console.WriteLine("Quantos números?");
            int quantidade = Convert.ToInt32(Console.ReadLine());
            double[] numeros = new double[quantidade];
            Console.WriteLine("Digite os números:");
            for(int i = 0; i < quantidade; i++)
            {
                numeros[i] = Convert.ToDouble(Console.ReadLine());
            }

            calcularMedia(numeros);
            calcularMediana(numeros);
        }
    }
}

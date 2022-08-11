using System;

namespace hello
{
    class Program
    {
        static double calculaArea (double largura, double altura) {
            return largura * altura;
        }
        static void Main(string[] args)
        {
            try {
            Console.WriteLine("Digite uma largura:");
            double largura = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Digite uma altura:");
            double altura = Convert.ToDouble(Console.ReadLine());

            Console.Write("A area é: ");
            double area = calculaArea(largura, altura);
            Console.WriteLine(area);
            }
            catch(Exception execao) {
                Console.WriteLine(execao.Message);
                //Console.WriteLine("Numero invalido");
            }
        }
    }
}

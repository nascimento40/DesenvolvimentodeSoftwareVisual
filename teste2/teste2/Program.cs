using System;

namespace teste2
{
    class Program
    {
    static void Main(string[] args)
    {
    Console.WriteLine("Digite o primeiro numero: ");
    int x = int.Parse(Console.ReadLine());
    Console.WriteLine("Digite o segundo numero: ");
    int y = int.Parse(Console.ReadLine());

    if (x > y)
    {
        Console.WriteLine(x + " é maior do que " + y);
    }
    else
    {
        Console.WriteLine(y + " é maior do que " + x);
    }
    //https://sites.google.com/site/inflp2009/2--instrucoes-compostas/if-else/maior-de-dois-numeros        
    }
    }
}

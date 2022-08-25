using System;
using System.IO;

namespace aula3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Olá! Bem vindo ao sistema de login");
            Console.WriteLine("Digite 1 para logar");
            Console.WriteLine("Digite 2 para cadastrar");
            Console.WriteLine("Digite 3 para sair");
            bool sair = false;
            while(!sair){
                int opcao = 0;
                try{
                    opcao = int.Parse(Console.ReadLine());
                }
                catch(Exception e){
                    //Console.WriteLine("valor invalido, tente novamente");
                }
                switch(opcao){
                    case 1:
                        //todo logar
                    break;
                    case 2:
                        //todo cadastrar
                    break;
                    case 3:
                        sair = true;
                    break;
                    default:
                        Console.WriteLine("opcao invalida! tente novamente");
                    break;
                }
            }
        }
    }
}

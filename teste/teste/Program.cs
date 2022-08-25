using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace teste
{
    class Program
    {
        static void Main(string[] args)
        {
            string numero = string.Empty;
            string milhar = string.Empty;
            string centena = string.Empty;
            string dezena= string.Empty;
            string unidade = string.Empty;
            string extenso = string.Empty;
            Console.Write("Digite um número: ");
            numero = Console.ReadLine();
            numero = numero.PadLeft(4, '0');
           
            // DECLARANDO A STRING ZERO
           
             string zero = "0000";
                if (numero == zero)
                 {
                    Console.Write("Zero");
                 }

            // ESCREVER POR EXTENSO MILHAR

            if (numero[0] != '0')
            {
                switch (numero[0])
                {
                    case '1': milhar = "Um Mil"; break;
                    case '2': milhar = "Dois Mil"; break;
                    case '3': milhar = "Três Mil"; break;
                    case '4': milhar = "Quatro Mil"; break;
                    case '5': milhar = "Cinco Mil"; break;
                    case '6': milhar = "Seis Mil"; break;
                    case '7': milhar = "Sete Mil"; break;
                    case '8': milhar = "Oito Mil"; break;
                    case '9': milhar = "Nove Mil"; break;

                }
            }

            // ESCREVER POR EXTENSO CENTENA
          
            if (numero[1] != '0')
            {
              
                switch (numero[1])
                {
                    case '1': centena = "Cento "; break;
                    case '2': centena = "Duzentos "; break;
                    case '3': centena = "Trezentos "; break;
                    case '4': centena = "Quatrocentos "; break;
                    case '5': centena = "Quinhentos "; break;
                    case '6': centena = "Seiscentos "; break;
                    case '7': centena = "Setecentos "; break;
                    case '8': centena = "Oitocentos "; break;
                    case '9': centena = "Novecentos "; break;

                }
                if(numero[1] == '1' && numero[2] == '0' && numero[3] == '0')
                {
                    centena = "Cem";
                }
             
            }

            //ESCREVER POR EXTENSO DEZENA

            if (numero[2] == '1')
            {
                switch (numero.Substring(2))
                {
                    case "10": dezena = "e Dez"; break;
                    case "11": dezena = "e Onze"; break;
                    case "12": dezena = "e Doze"; break;
                    case "13": dezena = "e Treze"; break;
                    case "14": dezena = "e Quatorze"; break;
                    case "15": dezena = "e Quinze"; break;
                    case "16": dezena = "e Dezesseis"; break;
                    case "17": dezena = "e Dezessete"; break;
                    case "18": dezena = "e Dezoito"; break;
                    case "19": dezena = "e Dezenove"; break;
                }
            }
            else if (numero[2] != '0')
            {
                switch (numero[2])
                {
                    case '2': dezena = "e Vinte "; break;
                    case '3': dezena = "e Trinta "; break;
                    case '4': dezena = "e Quarenta "; break;
                    case '5': dezena = "e Cinquenta "; break;
                    case '6': dezena = "e Secenta "; break;
                    case '7': dezena = "e Setenta "; break;
                    case '8': dezena = "e Oitenta "; break;
                    case '9': dezena = "e Noventa "; break;
                }
            }

            //ESCREVER POR EXTENSO UNIDADE

            if (numero[3] != '0' && numero[2] != '1')
            {
                switch (numero[3])
                {
                    case '1': unidade = "e Um"; break;
                    case '2': unidade = "e Doiz"; break;
                    case '3': unidade = "e Três"; break;
                    case '4': unidade = "e Quatro"; break;
                    case '5': unidade = "e Cinco"; break;
                    case '6': unidade = "e Seis"; break;
                    case '7': unidade = "e Sete"; break;
                    case '8': unidade = "e Oito"; break;
                    case '9': unidade = "e Nove"; break;
                }
            }

            // CRIAR EXTENSO
            extenso = milhar + centena + dezena + unidade;

            // COMANDO DE SAIDA
           
            if (extenso[0] == 'e')
            {
                extenso = extenso.Substring(2);
            }

           Console.WriteLine(extenso);

           Console.ReadKey(true);
        }
    }
}

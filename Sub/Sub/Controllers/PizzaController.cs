using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;

namespace Sub.Controllers
{

[ApiController]
[Route("[controller]")]
public class PizzaController : ControllerBase
{
	[HttpGet]
    public List<string> Get()
    {
    	var sabores = new List<string>();
		sabores.Add("Aliche");
		sabores.Add("Calabresa");
		sabores.Add("Califórnia");
		sabores.Add("Corn Bacon");
		sabores.Add("Frango com Catupiry");
		sabores.Add("Marguerita");
		sabores.Add("Muçarela");
		sabores.Add("Napolitana");
		sabores.Add("Portuguesa");
		sabores.Add("Quatro Queijos");
		sabores.Add("Vegetariana");
		return sabores;
    }
    
    [HttpPost]
    public string Post(Pizza pizza)
    {
		//TODO
		string mensagem = "Olá" + pizza.cliente + "! Você pediu uma pizza metade " + pizza.sabor1 + ",metade " 
		+ pizza.sabor2 + ",tamanho " + pizza.tamanho + " " + pizza.borda + " borda.";

		

		var p = pizza.tamanho;
		if (p != null){
			if (p == "pequena"){
				pizza.tamanho = "30 minutos";
			}
			else if (p == "media"){
				pizza.tamanho = "40 minutos";
			}
			else if (p == "grande"){
				pizza.tamanho = "50 minutos";
			}
			else if (p == "gigante"){
				pizza.tamanho = "60 minutos";
			}
		}

		//(0.6)
		//essa funcao deve retornar a seguinte mensagem
		//"Olá NOME! Você pediu uma pizza metade SABOR1, metade SABOR2, tamanho TAMANHO, COM/SEM borda recheada. Ela custará PRECO reais e ficará pronta em TEMPO minutos para retirada no balcão"
		//onde as palavras em maiusculo devem ser substituidas pelos valores corretos
		
		//(0.6)
		//regras para calcular o tempo:
		//pequena: 30 minutos
		//media:   40 minutos
		//grande:  50 minutos
		//gigante: 60 minutos
		//se o tiver dois sabores diferentes, adicionar 20% de tempo
		
		//(0.6)
		//regras para calcular o preco de cada sabor:
		//pequena: 15 reais
		//media:   20 reais
		//grande:  25 reais
		//gigante: 30 reais
		//os sabores que tem qualquer tipo de carne tem um adicional de 5 reais
		
		//(1.2)
		//regras para calcular o preco final:
		//o preco final eh a soma dos dois sabores
		//se tiver borda recheada tem um custo adicional de 7 reais sobre o preco final
		//se os dois sabores forem iguais ha um desconto de 8% sobre o preco final
		//se um dos sabores comecar com a mesma letra que o nome do cliente, ele ganha um desconto de 5 reais sobre o preco final
		
		return mensagem;
    }
}
}
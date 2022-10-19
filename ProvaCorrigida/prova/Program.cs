/*
	Curitiba, 2022/1
	Universidade Positivo
	Desenvolvimento de Software Visual
	Prof Jean Diogo
	
	PROVA 1
	
	REGRAS
	
	Analise o codigo abaixo e implemente as quatro funcoes que faltam para que os testes feitos na funcao Main tenham o resultado esperado
	Para testar, crie um projeto ("dotnet new console"), substitua o "Program.cs" por este codigo e compile ("dotnet run")
	Voce pode adicionar linhas de codigo a vontade (inclusive novas funcoes), mas nada do que ja esta escrito pode ser apagado
	A interpretacao do codigo faz parte da avaliacao
	A prova eh individual e deve ser submetida no blackboard ate o final da aula
	Apenas este arquivo precisa ser submetido
	O valor total da prova eh 4 pontos e o valor parcial de cada funcao a ser implementada esta comentado nela
	Mesmo que seu codigo nao esteja funcionando totalmente, ele sera analisado e podera receber uma pontuacao proporcional ao que tiver sido feito
	O horario para realizacao da prova eh exatamente o horario da aula
	Voce pode realizar a prova no seu proprio computador ou nos computadores do laboratorio
	Eh permitida consulta a internet e ao material de aula, mas nao eh permitida comunicacao entre os alunos e alunas, nem uso de celular durante a prova
	Plagio e cola implicarao na anulacao da nota dos alunos e alunas envolvidos
	
	ESPECIFICACAO
	
	A universidade positivo esta desenvolvendo uma API em C# para controlar a alocacao de quioesques nos blocos do campus ecoville
	As entidades do sistema sao "Quioesque", "Bloco" e "Alocacao"
	Soh existe um bloco de cada cor e soh um quiosque por empresa, portanto podemos usar cor e empresa como "chaves primarias"
	Os tipos de alimento servidos pelos quiosques sao "Salgado", "Doce" ou "Bebida"
	Os horarios de funcionamento dos blocos e quiosques sao "Manha", "Noite" ou "Ambos"
	A universidade fez uma pesquisa em cada bloco registrando qual tipo de alimento eh preferido pela maioria dos discentes daquele bloco
	Os blocos e quoisques foram cadastrados na funcao Main
	Falta implementar a funcao que aloca os quioesques nos blocos e mais algumas funcoes complementares
	O que cada funcao faz esta escrito no comentario acima dela
	As alocacoes devem cumprir as regras especificadas no comentario da funcao de alocacao
	
	DICAS
	
	Comece olhando quais sao os atributos de cada classe e os tipos deles
	Depois va para a funcao Main entender o que esta sendo feito la
	Por fim va para a classe controle ver quais funcoes devem ser implementadas (sao as marcadas com "TODO")
	
	Boa sorte! Nao tenha medo! De o seu melhor que o professor vai ser generoso na correcao. No comeco eh dificil, mas você consegue! \o/
*/

/*
	<Emiliano do Nascimento>
	<Quarta noite, dia 28/09/2022>
*/

using System;
using System.Collections.Generic;

namespace Prova1
{
	class Quiosque
	{
		public string Empresa;
		public bool   ServeBebida;
		public bool   ServeSalgado;
		public bool   ServeDoce;
		public string Horario;
		
		public Quiosque(string empresa, bool serveBebida, bool serveSalgado, bool serveDoce, string horario)
		{
			Empresa      = empresa;
			ServeBebida  = serveBebida;
			ServeSalgado = serveSalgado;
			ServeDoce    = serveDoce;
			Horario      = horario;
		}
	}
	
	class Bloco
	{
		public string Cor;
		public string AlimentoPreferido;
		public string Horario;
		public int    NumeroQuiosques;
		
		public Bloco(string cor, string alimentoPreferido, string horario)
		{
			Cor               = cor;
			AlimentoPreferido = alimentoPreferido;
			Horario           = horario;
			NumeroQuiosques   = 0;
		}
	}
	
	class Alocacao
	{
		public string EmpresaQuiosque;
		public string CorBloco;
		
		public Alocacao(string empresaQuiosque, string corBloco)
		{
			EmpresaQuiosque = empresaQuiosque;
			CorBloco        = corBloco;
		}
	}
	
	class Controle
	{
		public List<Quiosque> Quiosques;
		public List<Bloco>    Blocos;
		public List<Alocacao> Alocacoes;
		
		public Controle()
		{
			Quiosques = new List<Quiosque>();
			Blocos    = new List<Bloco>();
			Alocacoes = new List<Alocacao>();
		}
		
		//(0.5 pontos) 
		//retorna numero de quiosques que abrem apenas a noite
		public int GetNumeroQuiosquesApenasNoite()
		{
			int numeroQuiosquesApenasNoite = 0;
			
			//TODO
			foreach (var quiosque in Quiosques){
				if(quiosque.Horario == "Noite") {
					numeroQuiosquesApenasNoite++;
				}
			}
			
			return numeroQuiosquesApenasNoite;
		}
		
		//(0.5 pontos)
		//retorna string com os nomes dos quiosques (separados por virgula) que servem salgados pela manha
		public string GetEmpresasSalgadoManha()
		{
			string empresasSalgadoManha = "";
			
			//TODO
            foreach (var quiosque in Quiosques){
				if((quiosque.Horario == "Manha" || quiosque.Horario == "Ambos") && quiosque.ServeSalgado) {
					empresasSalgadoManha += quiosque.Empresa + ",";
				}
			}

			// empresasSalgadoManha = empresasSalgadoManha.Substring(0, empresasSalgadoManha.Length - 1);

			return empresasSalgadoManha;
		}
		
		//(1 ponto)
		//retorna o tipo de alimento que foi o mais escolhido como o preferido dentre todos os blocos
		public string GetAlimentoMaisPreferido()
		{
			string alimentoMaisPreferido = "";
			
			//TODO
			int doce = 0;
			int salgado = 0;
			int bebida = 0;

			foreach(var bloco in Blocos) {
				if(bloco.AlimentoPreferido == "Doce") doce++;
				else if(bloco.AlimentoPreferido == "Salgado") salgado++;
				else if(bloco.AlimentoPreferido == "Bebida") bebida++;
			}

			if(doce > salgado && doce > bebida) alimentoMaisPreferido = "Doce";
			else if(salgado > doce && salgado > bebida) alimentoMaisPreferido = "Salgado";
			else if(bebida > salgado && bebida > doce) alimentoMaisPreferido = "Bebida";
			
			return alimentoMaisPreferido;
		}
		
		//(2 pontos)
		//aloca os quiosques nos blocos obedecendo as seguintes condicoes:
		//	- no maximo dois quiosques por bloco
		//	- o quiosque deve servir o alimento preferido do bloco
		//	- o bloco tem que estar aberto em todo horario de funcionamento do quiosque (mas nao tem problema se o quiosque estiver fechado em parte do horario do bloco)
		//	(se quiser, faca funcoes separadas pra testar cada uma dessas condicoes)
		//	(se nao conseguir testar a terceira condicao, tente alocar corretamente seguindo pelo menos as duas primeiras)
		//	(nao eh necessario lancar excecao caso algum quiosque nao possa ser alocado)
		bool deuMath(Quiosque quiosque, Bloco bloco){
			if(bloco.NumeroQuiosques >= 2) {
				return false;
			}

			if(bloco.AlimentoPreferido == "Salgado" && !quiosque.ServeSalgado) {
				return false;
			}

			if(bloco.AlimentoPreferido == "Bebida" && !quiosque.ServeBebida) {
				return false;
			}

			if(bloco.AlimentoPreferido == "Doce" && !quiosque.ServeDoce) {
				return false;
			}

			if(quiosque.Horario != bloco.Horario && bloco.Horario != "Ambos") {
				return false;
			}

			return true;
		}

		public void AlocarTodoMundo()
		{
			//TODO
			foreach (var quiosque in Quiosques){
				foreach(var bloco in Blocos) {
					if(deuMath(quiosque, bloco)) {
						Alocacoes.Add(new Alocacao(quiosque.Empresa, bloco.Cor));
						bloco.NumeroQuiosques++;
						break;
					}
				}
			}
		}
	}
	
	class Program
	{
		static void Main(string[] args)
		{
			var controle = new Controle();
			
			controle.Quiosques.Add(new Quiosque("Bobs"        , true , true , false, "Manha"));
			controle.Quiosques.Add(new Quiosque("Burger King" , true , true , false, "Ambos"));
			controle.Quiosques.Add(new Quiosque("Cabra Café"  , true , false, false, "Manha"));
			controle.Quiosques.Add(new Quiosque("Cacau Show"  , false, false, true , "Noite"));
			controle.Quiosques.Add(new Quiosque("Freddo"      , false, false, true , "Manha"));
			controle.Quiosques.Add(new Quiosque("Giraffas"    , true , true , false, "Manha"));
			controle.Quiosques.Add(new Quiosque("McDonalds"   , true , true , false, "Ambos"));
			controle.Quiosques.Add(new Quiosque("Pizza Hut"   , false, true , false, "Noite"));
			controle.Quiosques.Add(new Quiosque("Ultra Coffee", true , false, true , "Ambos"));
			controle.Quiosques.Add(new Quiosque("Zuka"        , false, false, true , "Noite"));
			
			controle.Blocos.Add(new Bloco("Amarelo" , "Salgado", "Ambos"));
			controle.Blocos.Add(new Bloco("Azul"    , "Doce"   , "Noite"));
			controle.Blocos.Add(new Bloco("Bege"    , "Salgado", "Noite"));
			controle.Blocos.Add(new Bloco("Branco"  , "Salgado", "Manha"));
			controle.Blocos.Add(new Bloco("Cinza"   , "Doce"   , "Ambos"));
			controle.Blocos.Add(new Bloco("Laranja" , "Salgado", "Ambos"));
			controle.Blocos.Add(new Bloco("Marrom"  , "Salgado", "Manha"));
			controle.Blocos.Add(new Bloco("Verde"   , "Bebida" , "Manha"));
			controle.Blocos.Add(new Bloco("Vermelho", "Doce"   , "Manha"));
			controle.Blocos.Add(new Bloco("Roxo"    , "Bebida" , "Noite"));
			
			controle.AlocarTodoMundo();
			
			Console.WriteLine("O numero de quiosques que abrem apenas a noite eh: " + controle.GetNumeroQuiosquesApenasNoite());
			Console.WriteLine("Os quiosques que servem salgados pela manha sao: "   + controle.GetEmpresasSalgadoManha()      );
			Console.WriteLine("O tipo de alimento mais preferido pelos blocos eh: " + controle.GetAlimentoMaisPreferido()     );
			Console.WriteLine("Lista de alocacoes:");
			foreach(var alocacao in controle.Alocacoes)
			{
				Console.WriteLine($"O quiosque {alocacao.EmpresaQuiosque} foi alocado no bloco {alocacao.CorBloco}.");
			}
		}
	}
}

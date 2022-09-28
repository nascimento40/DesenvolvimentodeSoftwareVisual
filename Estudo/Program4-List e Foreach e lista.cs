// See https://aka.ms/new-console-template for more information
// Este aqui é sobre o list, ou gerenciar coleções de dados usando o tipo de lista genérico

// 1 - Criar listas:
// (Curio: Para você um List no VS, abaixo do using System, você precisa colocar using System.Collections.Generic)

// (Curio: Var é o que você coloca quando não sabe o que a variavel vai ser, você pode apenas começar a digitar e ver no que vai dar
// Ex do video:
// se eu colocar var i = 0, o programa pensa que é um int
// se eu colocar var i = "Emiliano", o programa pensa que é uma string
// O var seria, eu não sei, eu não me importo, vamos lá, <- frase do vídeo)

// tradução: para cada -> foreach (var item in collection)

// [(var name in names) name e names é só uma formalidade, eles podiam ter qualquer outro nome, é apenas um nome,
// nesse exercicio names é o list, e quando ele passa pelo loop foreach, e o name é a varial que armazena essa lista
// e que você usa no Console.WriteLine, em loop do foreach ele pega um item e armazena e depois pega o próximo)

// var names = new List<string> { "Emiliano", "Ana", "Felipe" };
// foreach (var name in names)
// {
//   Console.WriteLine($"Olá {name.ToUpper()}!");
// }

// - Você criou uma lista de cadeias de caracteres, adicionou três nomes a essa lista e imprimiu os nomes em MAIÚSCULAS. 
// Você está usando conceitos que aprendeu em tutoriais anteriores para executar um loop pela lista.
// - Você pode adicionar mais nomes, ex:

// var names = new List<string> { "Emiliano", "Katia", "Sander", "Lucas", "Tonho" };
// foreach (var name in names)
// {
//  Console.WriteLine($"Olá {name.ToUpper()}!");
// }

// - O código para exibir nomes utiliza o recurso de interpolação de cadeia de caracteres. 
// Quando você precede um string com o caractere $, pode inserir o código C# na declaração da cadeia de caracteres. 
// A cadeia de caracteres real substitui esse código C# pelo valor gerado. 
// Neste exemplo, ela substitui o {name.ToUpper()} por cada nome, convertido em letras maiúsculas, pois você chamou o método String.ToUpper.

// 2 - Modificar contéudo da lista

// A coleção que você criou usa o tipo List<T>. Esse tipo armazena sequências de elementos. 
// Especifique o tipo dos elementos entre os colchetes.

// var names = new List<string> { "Emiliano", "Katia", "Sander", "Lucas", "Tonho" };
// names.Add("Maria");
// names.Add("Bill");
// names.Remove("Katia");
// foreach (var name in names)
// {
//   Console.WriteLine($"Hello {name.ToUpper()}!");
// }

// - No exemplo acima, você usou o names.add para adicionar mais dois nomes ao names que é a list, e usando o 
// names.remove você removeu um dos nomes que já estava na lista
// e existe outro exemplo que seria esse:

// var names = new List<string> { "Emiliano", "Katia", "Sander", "Lucas", "Tonho" };
// foreach (var name in names)
// {
//   Console.WriteLine($"Hello {name.ToUpper()}!");
// }
// Console.WriteLine();
// names.Add("Maria");
// names.Add("Bill");
// names.Remove("Katia");
// foreach (var name in names)
// {
//   Console.WriteLine($"Hello {name.ToUpper()}!");
// }

// - No caso desse exemplo, no console ele mostra o conteudo inicial, que só tinha 5 nomes e não tinha adicionado
// e nem removido nenhum, e depois ele mostra uma linha em branco, que acontece por causo do Console.WriteLine e depois
// mostra o novo conteudo, com os novos nomes adicionados e o nome que foi removido

// - O List<T> também permite fazer referência a itens individuais por índice. Acesse itens usando os tokens [ e ].

// var names = new List<string> { "Emiliano", "Katia", "Sander", "Lucas", "Tonho" };
// foreach (var name in names)
// {
//   Console.WriteLine($"Hello {name.ToUpper()}!");
// }
// Console.WriteLine();
// names.Add("Maria");
// names.Add("Bill");
// names.Remove("Katia");
// foreach (var name in names)
// {
//   Console.WriteLine($"Hello {name.ToUpper()}!");
// }
// Console.WriteLine($"My name is {names[0]}.");
// Console.WriteLine($"I've added {names[2]} and {names[3]} to the list.");

// - Nesse exemplo é utilizado o conceito do vetor, que é o seguinte, tudo em lista, e em vetor, começa em indice 0,
// ou seja, se tem 6 elementos, o primeiro elemento está no indice 0 e o sexto está no indice 5,
// no caso do exemplo acima o primeiro nome é Emiliano, então ele está no indice 0, agora no caso do indice 2 e 3,
// os nomes são Lucas e Tonho, isto porque ele pega o list que os Add e o Remove, como o Katia foi removido, Sander foi
// para o indice 1, e Lucas e Tonho foram para o indice 2 e 3

// - Count, é o número de elementos contidos no List<T>

// var names = new List<string> { "Emiliano", "Katia", "Sander", "Lucas", "Tonho" };
// Console.WriteLine();
// names.Add("Maria");
// names.Add("Bill");
// names.Remove("Katia");
// foreach (var name in names)
// {
//   Console.WriteLine($"Olá {name.ToUpper()}!");
// }
// Console.WriteLine($"Meu nome é {names[0]}.");
// Console.WriteLine($"Eu adicionei {names[2]} e {names[3]} a lista.");

// Console.WriteLine($"A lista tem {names.Count} pessoas nela");

// - No caso do exemplo acima, o Count diz que a list possui 6 nomes, elementos, na lista, e são 6 por causa do remove,
// e se você retirar o remove vão ser 7, e se adicinar mais nomes ou mais removes, o numero de elementos na lista vai 
// aumentar ou diminuir, depende de você

// ex 2:
// var names = new List<string> { "Emiliano", "Katia", "Sander", "Lucas", "Tonho" };
// foreach (var name in names)
// {
//   Console.WriteLine($"Olá {name.ToUpper()}!");
// }
// Console.WriteLine();
// names.Add("Maria");
// names.Add("Bill");
// names.Remove("Katia");
// foreach (var name in names)
// {
//   Console.WriteLine($"Olá {name.ToUpper()}!");
// }
// Console.WriteLine($"Meu nome é {names[0]}.");
// Console.WriteLine($"Eu adicionei {names[2]} e {names[3]} a lista.");

// Console.WriteLine($"A lista tem {names.Count} pessoas nela");

// Os nomes só estão em maiusculo por causa do To Upper

// 3 - Pesquisar e classificar lista

// - Nossos exemplos usam listas relativamente pequenas, mas seus aplicativos podem criar listas com muitos outros elementos, chegando, às vezes, a milhares. 
// Para localizar elementos nessas coleções maiores, pesquise por itens diferentes na lista. 
// O método IndexOf procura um item e retorna o índice do item. 
// Se o item não estiver na lista, IndexOf retornará -1.

// ex 1(tutorial):
// var names = new List<string> { "Emiliano", "Katia", "Sander", "Lucas", "Tonho" };
// foreach (var name in names)
// {
//   Console.WriteLine($"Olá {name.ToUpper()}!");
// }
// Console.WriteLine();
// names.Add("Maria");
// names.Add("Bill");
// names.Remove("Katia");
// foreach (var name in names)
// {
//   Console.WriteLine($"Olá {name.ToUpper()}!");
// }
// Console.WriteLine($"Meu nome é {names[0]}.");
// Console.WriteLine($"Eu adicionei {names[2]} e {names[3]} a lista.");

// Console.WriteLine($"A lista tem {names.Count} pessoas nela");

// var index = names.IndexOf("Sander");
// if (index != -1)
//   Console.WriteLine($"O nome {names[index]} está no indice {index}");

// var notFound = names.IndexOf("Não encontrado");
// Console.WriteLine($"Quando um item não é encontrado, IndexOf retorna {notFound}");

// - Nesse exemplo o names[index] irá te dizer o indice do nome que você escreveu no IndexOf, nesse caso, como você escreveu
// Sander, ele ira te dizer que o nome está no indice 0, e se você escrever um nome que não está na lista ou escrever
// o nome katia que foi removido ele vai retornar -1, e neste exemplo o responsável pelo -1 é o var notFound
// (Ponto de diferença, no if (index tem o sinel de != -1, e se você mudar aparece -1 no console, mesmo que você escreva
// um nome que está na lista)

// ex 2(versão local, VS):
// var names = new List<string> { "Emiliano", "Katia", "Sander", "Lucas", "Tonho" };
// foreach (var name in names)
// {
//   Console.WriteLine($"Olá {name.ToUpper()}!");
// }
// Console.WriteLine();
// names.Add("Maria");
// names.Add("Bill");
// names.Remove("Katia");
// foreach (var name in names)
// {
//   Console.WriteLine($"Olá {name.ToUpper()}!");
// }
// Console.WriteLine($"Meu nome é {names[0]}.");
// Console.WriteLine($"Eu adicionei {names[2]} e {names[3]} a lista.");

// Console.WriteLine($"A lista tem {names.Count} pessoas nela");

// var index = names.IndexOf("Sander");
// if (index == -1)
// {
//     Console.WriteLine($"Quando um item não é encontrado, IndexOf retorna {index}");
// }
// else
// {
//     Console.WriteLine($"O nome {names[index]} está no índice {index}");
// }

// index = names.IndexOf("Não encontrado");
// if (index == -1)
// {
//     Console.WriteLine($"Quando um item não é encontrado, IndexOf retorna {index}");
// }
// else
// {
//     Console.WriteLine($"O nome {names[index]} está no índice {index}");

// }
// - Nesse exemplo o names[index] irá te dizer o indice do nome que você escreveu no IndexOf, nesse caso, como você escreveu
// Sander, ele ira te dizer que o nome está no indice 0, e se você escrever um nome que não está na lista ou escrever
// o nome katia que foi removido ele vai retornar -1, e neste exemplo o responsável pelo -1 é o else
// (Lembrando,if traduzido é se e else é senão, então se index == -1, o item não é encontrado e retorna -1
// senão, o nome está no incice tal, ex; sander está no indice 1 e emiliano está no indice 0)

// (Ponto de diferença, no if (index tem o sinel de == -1, eu chuto que isso acontece porque nesse exemplo
// tem o else, que faz o papel do notFound, e o notFound, eu não sei porque ele está presente, eu chuto que está no
// exemplo só para dar uma exemplo dinamino, ou visual do que acontece)
// (Ponto importante: o {names[index]} funciona se você colocar o apenas o name, porém, no console, vai ser imprimido
// apenas a seguinte frase: O nome System.Collections.Generic.List`1[System.String] está no índice ?, ele até diz
// o indice que está a palavra que você escreveu, se ela está na lista diz o indice dela ou se não está diz que no indice
// -1, eu não sei explicar o motivo, mais você precisa colocar names, nesse caso ou nome que você deu a sua list e entre
// [] o, [index], ou o nome que você deu para o var usar o IndexOf)

// - Os itens em sua lista também podem ser classificados. 
// O método Sort classifica todos os itens na lista na ordem normal (em ordem alfabética para cadeias de caracteres). 
// ex:
// var names = new List<string> { "Emiliano", "Katia", "Sander", "Lucas", "Tonho" };
// foreach (var name in names)
// {
//   Console.WriteLine($"Olá {name.ToUpper()}!");
// }
// Console.WriteLine();
// names.Add("Maria");
// names.Add("Bill");
// names.Remove("Katia");
// foreach (var name in names)
// {
//   Console.WriteLine($"Olá {name.ToUpper()}!");
// }
// Console.WriteLine($"Meu nome é {names[0]}.");
// Console.WriteLine($"Eu adicionei {names[2]} e {names[3]} a lista.");

// Console.WriteLine($"A lista tem {names.Count} pessoas nela");

// var index = names.IndexOf("Sander");
// if (index == -1)
// {
//     Console.WriteLine($"Quando um item não é encontrado, IndexOf retorna {index}");
// }
// else
// {
//     Console.WriteLine($"O nome {names[index]} está no índice {index}");
// }

// index = names.IndexOf("Não encontrado");
// if (index == -1)
// {
//     Console.WriteLine($"Quando um item não é encontrado, IndexOf retorna {index}");
// }
// else
// {
//     Console.WriteLine($"O nome {names[index]} está no índice {index}");
// }
// names.Sort();
// foreach (var name in names)
// {
//   Console.WriteLine($"Olá {name.ToUpper()}!");
// }

// - Nesse exemplo não tem muito o que falar, o que vai acontecer aqui é que vai aparecer no terminal todos as outras coisas
// que você já colocou e no final vai aparecer os nomes que você colocou na lista, porém, em ordem alfabética,
// tipo assim, o Bill que até então era o ultimo da lista vira o primeiro, ou seja, deça vez ele está no indice 0
// e Emiliano que ero primeiro foi rebaixado para segundo e está no indice 1

// 4 - Lista de outros tipos

// - Você usou o tipo string nas listas até o momento. Vamos fazer um List<T> com um tipo diferente, vamos fazer um 
// conjunto de números, com o tipo int.

// ex1:
// var fibonacciNumbers = new List<int> {1, 1};

// - Isso cria uma lista da números inteiros e defino os primeiros dois numeros como 1, a sequência de Fibonnaci, uma
// sequência de número, funciona da seguinta maneira, é o numero seguinte é encontrado somando o ultimo numero com o numero
// anterior a ele, ex: 1, 1, o proximo numero é dois, porque o ultimo numero 1 e o anterior a ele é 1 também, 1 + 1 = 2
// , e o proximo 3, porque 2 + 1 = 3, e por vai, 3 + 2 = 5, 5 + 3 = 8 e etc
// - E para se fazer essa sequencia funcionar, para fazer com que ela apareça no console.writeline, você faz isso aqui:

// ex2:
// var fibonacciNumbers = new List<int> {1, 1};

// var previous = fibonacciNumbers[fibonacciNumbers.Count - 1];
// var previous2 = fibonacciNumbers[fibonacciNumbers.Count - 2];

// fibonacciNumbers.Add(previous + previous2);

// foreach(var item in fibonacciNumbers) {
//     Console.WriteLine(item);
// }

// - Eu não sei explicar como isso aqui funciona, principalmente está parte fibonacciNumbers[fibonacciNumbers.Count - 1 e -2]
// eu não sei, eu só sei que é assim, pelo que deu para entender através dessa coisa ele faz a soma dos numeros e forma a 
// sequência de fibonacci,
// se eu fosse chutar eu diria que, a sequência é essa 1 e 1, o -1 é o segundo ou o primeiro 1 e o -2 é o segundo ou o primeiro 1,
// e através disso a sequência vira isso 1, 1, 2, e depois fica 1, 1, 2, 3, e denovo, se eu fosse chutar eu diria que
// o -1 é o 2 ou o 1 que vem antes dele e o -2 é o 2 ou o 1 que vem antes dele, e isso resula nisso, 1, 1, 2, 3
// o foreach você meio que já sabe, o item é basicamente aonde é depositado os valores da list e é o que você coloca
// no Console.WriteLine, nesse caso o list é o fibonacciNumbers
// (Curio do vídeo: fibonacciNumbers.Count é o tamanho da lista)
// - Assim pelo o que deu para entender, tanto no video quanto no tutorial é que para fazer a soma dos fibonacci você
// pega os dois numeros anteriores, ou o ultimo e o penultimo e soma, e previous é anterior em inglês

// Exercicio proposto pelo tutorial:

// Veja se você consegue combinar alguns dos conceitos desta lição e de lições anteriores. 
// Expanda o que você compilou até o momento com números Fibonacci. 
// Tente escrever o código para gerar os 20 primeiros números na sequência. 
// (Como uma dica, o vigésimo número Fibonacci é 6765.)

// var fibonacciNumbers = new List<int> {1, 1};

// while (fibonacciNumbers.Count < 20) {
//     var previous = fibonacciNumbers[fibonacciNumbers.Count - 1];
//     var previous2 = fibonacciNumbers[fibonacciNumbers.Count - 2];

//     fibonacciNumbers.Add(previous + previous2);
// }

// foreach(var item in fibonacciNumbers) {
//     Console.WriteLine(item);
// }

// Com cada iteração do loop, você está pegando os últimos dois inteiros na lista, somando-os e adicionando esse valor à lista. 
// O loop será repetido até que você tenha adicionado 20 itens à lista.

// (Relembrando: Count diz quantos elementos tem na lista, então a lista aumenta até ter 20 elementos na lista, no caso
// 20 numeros, e dane-se o valor desses numeros, não importa se eles não maiores ou menores que 20, o que importa é quantos
// elementos tem na lista)
// (While traduzido é enquanto, ou seja, enquando o fibonacciNumbers.Count for menor que 20 ele vai fazer o loop e adicionar
// mais elementos até não poder mais)
// (Curio do video: para esse exercico funcionar você tem que colocar <(menor que) 20 para funcionar, porque se você
// colocar <=(menor ou igual) a 20 vai dar um numero maior, porque pelo o que eu acho, não tenho certeza, é que o 
// count tem uma certa ligação com o indice, ou seja 20 elementos é igual a 19 indices e 21 elementos é igual a 20
// indices, então eu chuto que é por isso que o resultado que vai sair se você colcar <= 20 vai ser maior)
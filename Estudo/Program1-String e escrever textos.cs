// See https://aka.ms/new-console-template for more information
// Isto aqui é sobre Cadeias de Caracteres, sobre Hello World, e como escrever letras, palavras ou até texto no console(terminal)

// 1 - É escrita uma mensagem no terminal, através do do Console(terminal).Writeline(escreve).
// Console.Writeline("Hello World!")

// 2 - String representa o texto em C#, nesse exercicio você da um nome para a string e uma palavras, e no Console.Writeline, 
// dentro dos (você escreve $ e depois "" e dentro dele você escreve a frase e o nome da string entre {}).
// string aFriend = "Emiliano";
// Console.WriteLine($"Olá meu amigo {aFriend}, saiba que tudo vai dar certo no final, porque você {aFriend} é o melhor, você é incrivel e demais meu amigo");

// 3 - Aqui você criar mais de uma string e da mais de um nome e uma palavra, ou frase, e .Lenght diz no terminal(console) o número de letras/caracteres da palavras da string.
// string firstFriend = "Emiliano";
// string secondFriend = "Katia";
// string thirtFriend = "Lucas";
// string fourthFriend = "Antonio";
// string fifithFriend = "Sander";

// Console.WriteLine($"Meu nome é {firstFriend} e minha mãe se chama {secondFriend}, 
// ela é a melhor mãe do mundo e por causa dela eu tenho a melhor familia do mundo, 
// eu tenho um pai {fifithFriend}, que eu as vezes penso que estou decepcionando ele porque parece que eu só ligo para ele quando estou precisando de dinheiro, e eu quero mudar isso, 
// e eu tenho dois irmão {thirtFriend} e {fourthFriend}, dois ótimos irmãos e que as vezes eu fui meu estupido com eles, por isso me desculpem, e obrigado {thirtFriend} por ter me apresentado este Tutorial!");

// Console.WriteLine($"O nome {firstFriend} tem {firstFriend.Length} letras.");
// Console.WriteLine($"O nome {secondFriend} tem {secondFriend.Length} letras.");
// Console.WriteLine($"O nome {thirtFriend} tem {thirtFriend.Length} letras.");
// Console.WriteLine($"O nome {fourthFriend} tem {fourthFriend.Length} letras.");
// Console.WriteLine($"O nome {fifithFriend} tem {fifithFriend.Length} letras.");

// 4 - Aqui aconteçe que exitem espaços em branco a direita ou a esquerda na string, e consequentemente no Console.Writeline, e os [dizem aonde os espaços em branco começam e terminam]
// e o TrimStart = corta os espaços a esquerda, o TrimEnd = corta os espaços a direita, e o Trim corta ambos os espaços, tanto o da direita quanto o da esquerda.
// string greeting = "      Hello World!       ";
// Console.WriteLine($"[{greeting}]");

// string trimmedGreeting = greeting.TrimStart();
// Console.WriteLine($"[{trimmedGreeting}]");

// trimmedGreeting = greeting.TrimEnd();
// Console.WriteLine($"[{trimmedGreeting}]");

// trimmedGreeting = greeting.Trim();
// Console.WriteLine($"[{trimmedGreeting}]");

// 5 - Aqui denovo você cria uma string e da um nome e uma palavra, nesse caso duas palavras, e através do Replace,
// dentro do (você escreve entre "" a palavra da string que quer substituir e entre "" a palavra que vai substituir a palavra escolhida)
// e o ToUpper deixa todas as palavras da string em maiúsculo, e o ToLower deixa todas as palavras da string em minusculo.
// string sayHello = "Olá Mundo!";
// Console.WriteLine(sayHello);
// sayHello = sayHello.Replace("Mundo", "Tartaruga");
// Console.WriteLine(sayHello);

// Console.WriteLine(sayHello.ToUpper());
// Console.WriteLine(sayHello.ToLower());

// 6 - Aqui você usa o Contains para localizar no texto da string, se tem a palavra que você escreveu no Contains, 
// aqui se retorna um resultado Boolean (booleano), quer dizer retorna True (verdadeiro) ou False (falço) no console(terminal)
// StartsWith = tem a mesma função de localizar a palavra que você escreveu, porém ela ve se a palavra está no inicio da frase
// EnsWith = tem a mesma função de localizar a palavra que você escreveu, porém ela ve se a palavra está no final da frase
// lembrando, para voltar true(verdadeiro) no StartsWith e EndsWith você tem que escrever a palavra do mesmo jeito que escreveu na string,
// ex: se você colocou um ponto na string, tem que colocar ponto também no Start e no End
// string songLyrics = "You say goodbye, and I say hello";
// Console.WriteLine(songLyrics.Contains("goodbye"));
// Console.WriteLine(songLyrics.Contains("greetings"));

// Console.WriteLine(songLyrics.StartsWith("You"));
// Console.WriteLine(songLyrics.EndsWith("hello"));


// Exemplo diferencial que foi usado no video:
// string songLyrics = "Eu estou querendo toma iogurte";
// var result = songLyrics.Contains("toma");
// Console.WriteLine(result);
// Console.WriteLine(songLyrics.Contains("iogurte"));

// Exemplo diferencial que usado no tutorial:
// - Aqui mostra que você pode usar os metodos mais de uma vez, você pode usar dois StartsWich e dois EndsWith
// string songLyrics = "You say goodbye, and I say hello";
// Console.WriteLine(songLyrics.StartsWith("You"));
// Console.WriteLine(songLyrics.StartsWith("goodbye"));

// Console.WriteLine(songLyrics.EndsWith("hello"));
// Console.WriteLine(songLyrics.EndsWith("goodbye"));
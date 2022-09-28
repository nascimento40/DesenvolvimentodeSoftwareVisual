// See https://aka.ms/new-console-template for more information
// Este é sobre lógica condicional com instruções branch e loop em C#

// 1 - Este aqui é exemplo básico do uso do if (tradução: E se), aonde se utiliza do tipo booleano, true(verdadeiro) ou false(falço), 
// aonde se você der um run e o resultado for maior que 10 aparece a mensagem no console (terminal), e se for falça não aparece nada.
// simplificando: o if pega o bool e ve se é true ou false, se for true aparece no console (terminal) e se for false não aparece nada.
// - você pode usar o (bool) para criar um numero/ou qualquer outra coisa que será usado no if
//int a = 5;
//int b = 1;
//if (a + b > 10)
    // Console.WriteLine("O resultado é maior que 10.");

// 2 - Aqui é onda mostra que, se quando você for usar o if, e o resultado por false, você pode utilizar o else (tradução: senão), 
// para executar um código diferente nos branches true e false, crie um branch else que será executado quando a condição for false.
// A instrução após a palavra-chave else é executada somente quando a condição que estiver sendo testada for false,
// a combinação de if e else com condições boolianas fornece todos os recursos que você precisa.
// Como o recuo não é significativo, você precisa usar { e } para indicar quando você quer que mais de uma instrução faça parte do bloco executado condicionalmente, 
// os programadores em C# normalmente usam essas chaves em todas as cláusulas if e else. 
// int a = 5;
// int b = 3;
// if (a + b > 10) {
    // Console.WriteLine("O resultado é maior que 10.");
// }
// else {
    // Console.WriteLine("O resultado não é maior que 10."); 
// }

// 3 - Aqui é mostrado que, dentro de um if e um else pode haver mais de uma condição, e os sinais apresentados são:
// O símbolo == testa a igualdade. Usar == distingue o teste de igualdade de atribuição, que você viu em a = 5.
// O && representa "e". Isso significa que as duas condições devem ser verdadeiras para executar a instrução no branch verdadeiro(if).
// O || representa "ou". Isso significa que dentre as duas condições só uma precisar ser verdadeiro para executar a instrução no branch verdadeiro(if).
// (Ps: Porém, o || pode te dar a resposta errada, isto porque o exemplo que tem ai ele diz que o resultado é maior que 10, porém também diz que a é igual b, o que não
// e se você fizer uma modificação para o resultado não ser maior que 10, ai sim ele diz que a não é igual a b)
// ex 1:
// int a = 5;
// int b = 3;
// int c = 4;
// if ((a + b + c > 10) && (a == b))
// {
    // Console.WriteLine("O resultado é maior que 10.");
    // Console.WriteLine("E o primeiro número é igual ao segundo");
// }
// else
// {
    // Console.WriteLine("O resultado não é maior que 10");
    // Console.WriteLine("Ou o primeiro número não é igual ao segundo");
// }

// ex 2:
// int a = 5;
// int b = 3;
// int c = 4;
// if ((a + b + c > 10) || (a == b))
// {
    // Console.WriteLine("O resultado é maior que 10.");
    // Console.WriteLine("E o primeiro número é igual ao segundo");
// }
// else
// {
    // Console.WriteLine("O resultado não é maior que 10");
    // Console.WriteLine("Ou o primeiro número não é igual ao segundo");
// }

// ex 3:
// ExploreIf();

// void ExploreIf()
// {
//     int a = 4;
//     int b = 7;
//     if (a + b > 10)
//     {
//         Console.WriteLine("O resultado é maior que 10.");
//     }
//     else
//     {
//         Console.WriteLine("O resultado não é maior que 10.");
//     }

//     int c = 4;
//     if ((a + b + c > 10) && (a > b))
//     {
//         Console.WriteLine("O resultado é maior que 10.");
//         Console.WriteLine("E o primeiro número é maior que o segundo");
//     }
//     else
//     {
//         Console.WriteLine("O resultado não é maior que 10.");
//         Console.WriteLine("Ou o primeiro número não é maior que o segundo");
//     }

//     if ((a + b + c > 10) || (a > b))
//     {
//         Console.WriteLine("O resultado é maior que 10.");
//         Console.WriteLine("E o primeiro número é maior que o segundo");
//     }
//     else
//     {
//         Console.WriteLine("O resultado não é maior que 10.");
//         Console.WriteLine("Ou o primeiro número não é maior que o segundo");
//     }
// }

// 4 - Aqui você aprende sobre os loops while, do e for, você usará loops para repetir as instruções que deseja executar mais de uma vez.
// ex 1: 
// int counter = 0;
// while (counter < 10)
// {
//   Console.WriteLine($"Hello World! The counter is {counter}");
//   counter++;
// }
// (A instrução while verifica uma condição e executa a instrução após while. 
// Ela repetirá a verificação da condição e executará essas instruções até que a condição seja false.
// No caso do exemplo acima, ela para quando o counter tiver valor 9, e se a condição for false desde o inicio
// nada aconteçe)

// - o sinal (++) é um operador increment, ele adiciona 1 ao valor, nesse exemplo ao counter, e armazena esse valor na variavel do counter
// outro jeito de escrevelo seria assim: counter = counter + 1;

// ex 2:
// int counter = 0;
// do
// {
//   Console.WriteLine($"Hello World! The counter is {counter}");
//   counter++;
// } while (counter < 10);
// (O loop while testa a condição antes de executar o código seguindo while. 
// O loop do ... while executa o código primeiro e, em seguida, verifica a condição.
// No caso do exemplo acima, mesmo que a condição seja false desde o inicio, ainda vai aparecer a mensagem no console(terminal))

// ex 3:
// - Outra instrução de loop comum que você verá no código C# é o loop for.
// for(int counter = 0; counter < 10; counter++)
// {
//   Console.WriteLine($"Hello World! The counter is {counter}");
// }
// (Ele faz o mesmo trabalho que o loop while e o loop do que você já usou. 
// A instrução for tem três partes que controlam o modo como ela funciona:
// 1. A primeira parte é o inicializador for: int counter = 0; declara que counter é a variável do loop, e define seu valor inicial como 0.
// 2. A parte central é a condição for: counter < 10 declara que este loop for continuará sendo executado desde que o valor do contador seja inferior a 10.
// 3. A parte final é o iterador for: counter++ especifica como modificar a variável de loop depois de executar o bloco após a instrução for. 
// Aqui, ela especifica que counter deve ser incrementado com 1 sempre que o bloco for executado.
// No caso do exemplo acima, ele age da mesma forma do ex 1, ele termina em 9 e se a condição no inicio for false
// nada acontece)

// 5 - Aqui você aprende sobre loops aninhados, um loop while, do ou for pode ser aninhado dentro de outro loop para criar uma matriz usando a combinação de cada item no loop externo com cada item no loop interno. 
// Vamos fazer isso para criar um conjunto de pares alfanuméricos para representar linhas e colunas.
// Um loop for pode gerar as linhas:
// for (int row = 1; row < 11; row++)
// {
//   Console.WriteLine($"The row is {row}");
// }

// Outro loop pode gerar as colunas:
// for (char column = 'a'; column < 'z'; column++)
// {
//   Console.WriteLine($"The column is {column}");
// }

// Você pode aninhar um loop dentro do outro para formar pares:
// for (int row = 1; row < 11; row++)
// {
//   for (char column = 'a'; column < 'z'; column++)
//   {
//     Console.WriteLine($"The cell is ({row}, {column})");
//   }
// }
// (Você pode ver que o loop externo incrementa uma vez para cada execução completa do loop interno.
// No caso do exemplo acima, ele exibe no console(terminal) os número de 1 a 10 com todas as letras do albeto, com exeção do Z que está no column).

// Exercicio proposto pelo tutorial:
// Agora que você viu a instrução if e as construções de loop na linguagem C#, 
// verifique se você pode escrever o código C# para encontrar a soma de todos os inteiros de 1 a 20 divisíveis por 3.
 
// int soma = 0;
// for (int numero = 1; numero < 21; numero++)
// {
//   if (numero % 3 == 0)
//   {
//     soma = soma + numero;
//   }
// }
// Console.WriteLine($"A soma é {soma}");

// - % este sinal pelo o que me foi ensinado é usado para achar o restante de uma divisão, porém, ele pode ser usado
// em contas aonde você tem que encontrar numeros divisiveis de outro numero, e o == 0 é usado para que seja utilzado
// apenas numeros cujo o restante seja igual a 0, porque nesse caso é usado um int e o int não tem numero com (,)
// No caso do exemplo acima, o codigo pega todos os numeros de 1 a 20 que sejam divisiveis por 3 e cujo resto da divisão seja 0
// - soma, ou int soma, é a variavel que mantem o registro de todos os números somados
// - int soma fica fora do for, para que a variavel seja somada e não redefinida em cada loop do for, que vai ficar no loop até que o numero fique igual ou maior 21

// (for tradução: para)
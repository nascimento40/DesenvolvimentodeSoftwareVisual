// See https://aka.ms/new-console-template for more information
// Este é sobre Manipular números de ponto flutuante e integrais em C#

// 1 - Aqui você come se faz uma simples operação de, usando números int (O tipo int representa um inteiro, 
// um número inteiro é um numero sem virgula, ou ponto e é positivo ou negativo):
// + Soma
// int a = 18;
// int b = 6;
// int c = a + b;
// Console.WriteLine(c);

// - Subtração
// int a = 18;
// int b = 6;
// int c = a - b;
// Console.WriteLine(c);

// * multiplicação
// int a = 18;
// int b = 6;
// int c = a * b;
// Console.WriteLine(c);

// ( / = simbolo) divisão
// int a = 18;
// int b = 6;
/// int c = a / b;
// Console.WriteLine(c);

// 2 - Aqui você pode ver, ou relembrar que, a multiplicação e a divisão vem antes da soma e subtração, 
// e ao mesmo tempo talvez você tenha observado um comportamento interessante com relação aos números inteiros. 
// A divisão de inteiros sempre produz um resultado inteiro, 
// mesmo quando você espera que o resultado inclua uma parte decimal ou fracionária (com virgula)
// Ex:
// (multiplicação vem antes dos outros)
// int a = 5;
// int b = 4;
// int c = 2;
// int d = a + b * c;
// Console.WriteLine(d);

// (Você pode forçar uma ordem diferente de operações, adicionando parênteses () para delimitar a operação, 
// ou operações, que você quer realizar primeiro)
// int a = 5;
// int b = 4;
// int c = 2;
// int d = (a + b) * c;
// Console.WriteLine(d);

// ou

// int a = 7;
// int b = 4;
// int c = 3;
// int d = (a + b) - 6 * c + (12 * 4) / 3 + 12;
// Console.WriteLine(d);

// (frações com int sempre retornam um int, o resultado pode estar errado ou só retorna um 0, que também pode estar errado)
// int a = 7;
// int b = 4;
// int c = 3;
// int d = (a + b) / c;
// Console.WriteLine(d);

// 3 - Aqui você consegue obter o quociente e o resto da divisão, o quociente é o numero que fica em baixo da caixa, do divisor,
// e o resto é o que sobra,
// (pegando esse exemplo, 7 + 4 = 11, 11 / 3, o quociente é o 3, pq 3 * 3 = 9, 11 - 9 = 2, e o resto é 2)
// int a = 7;
// int b = 4;
// int c = 3;
// int d = (a + b) / c;
// int e = (a + b) % c;
// Console.WriteLine($"quotient: {d}");
// Console.WriteLine($"remainder: {e}");

// 4 - Aqui você aprende sobre o Double, de forma simplificada você utiliza o double para obter/representar números inteiros ou decimais 
// (com virgula, no terminal aparce um . no lugar da , e vc também precida escrever . no lugar , quando for utilizar numero deciamal)
// exs: 
// double a = 5;
// double b = 4;
// double c = 2;
// double d = (a + b) / c;
// Console.WriteLine(d);

// (aqui você pode ver que pode usar os matodos anteteriores junto desse que aprendeu)
// double a = 19;
// double b = 23;
// double c = 8;
// double d = (a + b) / c;
// double e = (a + b) % c;
// Console.WriteLine(d);

// Console.WriteLine($"quotient: {d}");
// Console.WriteLine($"remainder: {e}");

// 5 - Aqui você aprende sobre o tipo decimal, que de forma simplificada seria a mesma coisa do double, porém com mais numeros depois da virgual,
// e para usar o decimal em uma conta você tem colocar M, 
// a letra M foi escolhida como a letra mais visualmente distinta entre as palavras-chave double e decimal.
// ex:
// double a = 1.0;
// double b = 3.0;
// Console.WriteLine(a / b);

// decimal c = 1.0M;
// decimal d = 3.0M;
// Console.WriteLine(c / d);

// desafio proposto pelo tutorial:
// - Calcular a área de um círculo cujo raio é de 2,50, e área de um circulo é o quadrado do raio multiplicado por PI, o velho 3,14...
// Uma dica: no vs contém uma constante para PI, Math.PI, que você pode usar para esse valor. 
// Math.PI, como todas as constantes declaradas no namespace System.Math, é um valor double. 
// Por esse motivo, você deve usar valores double em vez de decimal para esse desafio.
// (feito por mim)
// double raio = 2.5;
// double areal = Math.PI * raio * raio;
// Console.WriteLine(areal);

// (feito pelo tutorial)
// double radius = 2.50;
// double area = Math.PI * radius * radius;
// Console.WriteLine(area);

// Você pode pegar esse exemplo e usar para fazer outras formulas, ou outras contas de matématica
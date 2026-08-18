//#01.Soma de dois números
Console.WriteLine("Digite um numero");
if (int.TryParse(Console.ReadLine(), out int numeroUm))
{
    Console.WriteLine("Digite mais um numero");
    if (int.TryParse(Console.ReadLine(), out int numeroDois))
    {
        Console.WriteLine($"A soma é: {numeroUm + numeroDois}");
    }
    else
    {
        Console.WriteLine("Escreva um número inteiro");
        Console.ReadLine();
    }
}
else
{
    Console.WriteLine("Escreva um número inteiro");
    Console.ReadLine();
}
;
//#02.Antecessor e sucessor
Console.WriteLine("Digite outro numero");
if (int.TryParse(Console.ReadLine(), out int numeroMeio))
{

    Console.WriteLine($"O Antecessor: {numeroMeio - 1}");
    Console.WriteLine($"O numero é: {numeroMeio}");
    Console.WriteLine($"O sucessor é: {numeroMeio + 1}");
}
else
{
    Console.WriteLine("Escreva um número inteiro");
    Console.ReadLine();
}
;
//#03.Area de um retangulo
Console.WriteLine("Digite a base de um retângulo");
if (Double.TryParse(Console.ReadLine(), out double numeroBase))
{
    Console.WriteLine("Digite a altura de um retângulo");
    if (Double.TryParse(Console.ReadLine(), out double numeroAltura))
    {
        Console.WriteLine($"A área é: {(numeroBase * numeroAltura)}");
        Console.WriteLine($"O Perimetro é: {2 * (numeroBase + numeroAltura)}");
    }
    else
    {
        Console.WriteLine("Escreva um número válido");
        Console.ReadLine();
    }
}
else
{
    Console.WriteLine("Escreva um número válido");
    Console.ReadLine();
};
//#04.Conversor de moedas
Console.Write("Digite o valor em Reais (R$): ");
if (double.TryParse(Console.ReadLine(), out double reais))
{
    Console.Write("Digite a cotação do Dólar (US$): ");
    if (double.TryParse(Console.ReadLine(), out double cotacao))
    {
        Console.WriteLine($"O valor em dólares é: US$ {reais / cotacao}");
        Console.ReadLine();
    }
    else
    {
        Console.WriteLine("Escreva uma valor valido");
        Console.ReadLine();
    }
}
else
{
    Console.WriteLine("Escreva um valor válido");
    Console.ReadLine();
}
//#05.Calculadora Simples
Console.Write("Digite o primeiro número: ");
if (double.TryParse(Console.ReadLine(), out double n1))
{
    Console.Write("Digite o segundo número: ");
    if (double.TryParse(Console.ReadLine(), out double n2) && n2 != 0)
    {
        Console.WriteLine($"Soma: {n1 + n2}");
        Console.WriteLine($"Subtração: {n1 - n2}");
        Console.WriteLine($"Multiplicação: {n1 * n2}");
        Console.WriteLine($"Divisão: {n1 / n2}");
        Console.ReadLine();
    }
    else
    {
        Console.WriteLine("Escreva um número válido");
        Console.ReadLine();
    }
}
else
{
    Console.WriteLine("Escreva um número válido");
    Console.ReadLine();
};
//#06.Contagem crescente
for (int i = 1; i <= 100; i++)
{
    Console.Write(i);
    Console.ReadLine();
}
;
//#07.Contagem regressiva
for (int i = 100; i >= 1; i--)
{
    Console.Write(i);
    Console.ReadLine();
}
;
//#08.Tabuada
Console.WriteLine("Digite um número para ver a tabuada");
if (int.TryParse(Console.ReadLine(), out int numeroTabuada))
{
    for (int i = 1; i <= 10; i++)
    {
        Console.Write($"{numeroTabuada} x {i} = {numeroTabuada * i}");
        Console.ReadLine();
    }
}
else
{
    Console.WriteLine("Escreva um número válido");
    Console.ReadLine();
};
//#09.Soma dos números pares
int SomaPares = 0;
for (int i = 2; i <= 100; i += 2) SomaPares += i;
Console.WriteLine($"A soma dos números pares de 1 a 100 é {SomaPares}");
Console.ReadLine();
//#10.Login simples
string senhaDefinida = "1234";
Console.Write("Digite o Usuário: ");
string usuarioDigitado = Console.ReadLine();
Console.Write("Digite a Senha: ");
string senhaDigitada = Console.ReadLine();
bool validador = false;
do
{
    if (senhaDigitada != senhaDefinida)
    {
        Console.WriteLine("Senha incorreta! Tente novamente.");
        senhaDigitada = Console.ReadLine();
        Console.ReadLine();
    }
    else
    {
        Console.WriteLine("Login efetuado com sucesso!");
        validador = true;
        Console.ReadLine();
    }
} while (!validador);
//#11.Soma até digitar zero
int somaZero = 0;
int valorDigitado;
do
{
    Console.Write("Digite um número inteiro: Lembre-se de digitar 0 para parar ");
    valorDigitado = int.Parse(Console.ReadLine());
    somaZero += valorDigitado;
} while (valorDigitado != 0);
Console.WriteLine($"A soma total dos valores digitados é: {somaZero}");
Console.ReadLine();
//#12.Contador de caracteres
Console.WriteLine("Digite um nome: ");
string nome = Console.ReadLine();
Console.WriteLine($"O nome digitado tem {nome.Length} caracteres.");
Console.ReadLine();
//#13.Verificador de senha
Console.WriteLine("Crie uma nova senha: ");
string senhaNova = Console.ReadLine();
if (senhaNova.Length >= 8)
{
    Console.WriteLine("Senha válida.");
    Console.ReadLine();
}
else
{
    Console.WriteLine("Senha inválida.");
    Console.ReadLine();
}
;
//#14.Maior elemento
int maiorValor = 0;
int menorValor = 0;
int posicaoMaior = 0;
int posicaoMenor = 0;
for (int i = 1; i <= 10; i++)
{
    Console.Write($"Digite o número {i}/10: ");
    int numAtual = int.Parse(Console.ReadLine());
    if (numAtual > maiorValor)
    {
        maiorValor = numAtual;
        posicaoMaior = i;
    }
    if (numAtual < menorValor)
    {
        menorValor = numAtual;
        posicaoMenor = i;
    }
}
Console.WriteLine($"O maior valor digitado foi: {maiorValor} na posição {posicaoMaior}");
Console.ReadLine();
//#15.Média de um vetor
double somaNotas = 0;
for (int i = 1; i <= 8; i++)
{
    Console.Write($"Digite a nota {i}/8: ");
    somaNotas += double.Parse(Console.ReadLine());

}
Console.WriteLine($"A média final das 8 notas é: {somaNotas / 8:F2}");
Console.ReadLine();
//#16.Contagem de pares
int contadorPares = 0;
for (int i = 1; i <= 20; i++)
{
    Console.Write($"Digite o número {i}/20: ");
    if (int.Parse(Console.ReadLine()) % 2 == 0) contadorPares++;
}
Console.WriteLine($"Dos 20 números digitados, {contadorPares} são pares.");
Console.ReadLine();
//#17.Ordem inversa
int[] numerosInversos = new int[10];
for (int i = 0; i < 10; i++)
{
    Console.Write($"Digite o número {i + 1}/10: ");
    numerosInversos[i] = int.Parse(Console.ReadLine());
}
Console.Write("Números na ordem inversa:");
for (int i = 9; i >= 0; i--) Console.Write(numerosInversos[i] + " ");
Console.ReadLine();
//#18.Jogo da senha
int numeroSorteado = new Random().Next(1, 101);
int chute = 0;
Console.WriteLine("Tente adivinhar o número sorteado entre 1 e 100!");
while (chute != numeroSorteado)
{
    Console.Write("Digite seu chute: ");
    chute = int.Parse(Console.ReadLine());
    if (chute < numeroSorteado) Console.WriteLine("O número sorteado é MAIOR.");
    else if (chute > numeroSorteado) Console.WriteLine("O número sorteado é MENOR.");
}
Console.WriteLine($"Parabéns! Você acertou.O número sorteado era {numeroSorteado}.");
Console.ReadLine();
//#19.Caixa eletrônico
int[] notasDisponiveis = { 100, 50, 20, 10, 5, 2 };
Console.Write("Digite o valor para saque: R$ ");
int valorSaque = int.Parse(Console.ReadLine());
Console.WriteLine("Notas a serem entregues:");
foreach (int nota in notasDisponiveis)
{
    int quantidadeNotas = valorSaque / nota;
    if (quantidadeNotas > 0)
    {
        Console.WriteLine($"{quantidadeNotas} nota(s) de R${nota}");
        valorSaque %= nota;
        Console.ReadLine();
    }
}
if (valorSaque > 0) Console.WriteLine($"Sobrou R$ {valorSaque} que não pôde ser sacado.");
Console.ReadLine();



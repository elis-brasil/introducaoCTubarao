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
};
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
};
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
//#05.Calculadora Simples
//#06.Contagem crescente
//#07.Contagem regressiva
//#08.Tabuada
//#09.Soma dos números pares
//#10.Login simples
//#11.Soma até digitar zero
//#12.Contador de caracteres
//#13.Verificador de senha
//#14.Maior elemento
//#15.Média de um vetor
//#16.Contagem de pares
//#17.Ordem inversa
//#18.Jogo da senha
//#19.Caixa eletrônico


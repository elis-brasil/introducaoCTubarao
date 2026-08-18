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
    }
};
//#02.Antecessor e sucessor
Console.WriteLine("Digite outro numero");
if (decimal.TryParse(Console.ReadLine(), out decimal numeroMeio))
{

    Console.WriteLine($"O Antecessor: {numeroMeio - 1}");
    Console.WriteLine($"O numero é: {numeroMeio}");
    Console.WriteLine($"O sucessor é: {numeroMeio + 1}");
}
else
{
    Console.WriteLine("Escreve direito");
};
//#03.Area de um retangulo
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


Console.WriteLine("## struct Switch ##");

int compra = 600;
Console.WriteLine($"Valor da compra: {compra}");
Console.WriteLine("Informe o númemro de parcelas (1 a 3)");
int parcelas = int.Parse(Console.ReadLine()!);
switch (parcelas)
{
    case 1:
        Console.WriteLine($"\nPrestação R$ {compra / parcelas} - Sem juros");
        break;
    case 2:
        Console.WriteLine($"\nPrestação R$ {compra / parcelas} - Sem juros");
        break;
    case 3:
        Console.WriteLine($"\nPrestação R$ {compra / parcelas} - Sem juros");
        break;
    default:
        Console.WriteLine("\nNúmero de parcelas inválido");
        break;
}
Console.WriteLine("\nFim do programa");
Console.ReadKey();

Console.WriteLine("Infome um número inteiro");
int numero = int.Parse(Console.ReadLine()!);
switch(numero % 2)
{
    case 0:
        Console.WriteLine($"\nO número {numero} é par");
        break;
    case 1:
        Console.WriteLine($"\nO número {numero} é ímpar");
        break;
}
Console.WriteLine("\nFim do programa");


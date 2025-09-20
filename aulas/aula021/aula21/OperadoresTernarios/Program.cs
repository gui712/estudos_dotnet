Console.WriteLine("Operators Terneary ");

int positivo = 1;
int resultado;

resultado = +positivo;
Console.WriteLine("O valor de resultado é " + resultado);

Console.WriteLine("Informe um numero: ");

var n = Convert.ToInt32(Console.ReadLine());

Console.WriteLine($"O negativo de {n} é {-n}");

Console.WriteLine("Informe a temperatura: ");
var temp = Convert.ToDouble(Console.ReadLine());
var situacao = temp > 27 ? "Quente" : "Frio";
Console.WriteLine($"A temperatura está {situacao}");

Console.ReadKey();
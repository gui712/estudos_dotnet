Console.WriteLine("Nullable Types\n");
// nullable type is a value type that can also be null

Nullable<int> valor = null;
Nullable<double> valor1 = null;
Nullable<bool> valor2 = null;

Console.WriteLine($"Valor: {valor}, Valor1: {valor1}, Valor2: {valor2}");

// shorthand syntax
int? valor3 = null;
double? valor4 = null;
bool? valor5 = null;
Console.WriteLine($"Valor3: {valor3}, Valor4: {valor4}, Valor5: {valor5}");

int? a = null;
int b = a ?? 0;
// The ?? operator returns the left-hand operand if it is not null; otherwise, it returns the right-hand operand.
Console.WriteLine($"b: {b}");

int? c = null;

if (c.HasValue)
{
    Console.WriteLine($"{c.Value} is not null");
}
else
{
    Console.WriteLine("c is null");
}

Console.WriteLine("Conversion of types");

int number1 = 100;
double number2 = number1; // Implicit conversion from int to double
Console.WriteLine($"Implicit conversion: {number2}");

int number3 = 2145678;
long number4 = number3; // Implicit conversion from int to long
float number5 = number3;
double number6 = number3;
decimal number7 = number3; // Implicit conversion from int to decimal

Console.WriteLine($"Implicit conversion: {number4}, {number5}, {number6}, {number7}");

double number8 = 123.45;
int number10 = (int)number8; // Explicit conversion from double to int
Console.WriteLine($"Explicit conversion: {number10}");

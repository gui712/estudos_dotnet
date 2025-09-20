Console.WriteLine("Type Conversion");

int valueInt = 123;
double valueDouble = 12.45;
decimal valueDecimal = 12.45678m;

string s1 = valueInt.ToString();
string s2 = valueDouble.ToString();
string s3 = valueDecimal.ToString();

Console.WriteLine($"s1: {s1.GetType()}");
Console.WriteLine($"s2: {s2}");
Console.WriteLine($"s3: {s3}");

Console.ReadLine();

int varInt = 10000;
Console.WriteLine(Convert.ToByte(varInt));
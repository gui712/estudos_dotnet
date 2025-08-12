Console.WriteLine("-- Struct DateTime --\n");

DateTime dataAtual = DateTime.Now;
Console.WriteLine("Data atual: " + dataAtual);
Console.WriteLine(dataAtual.Year);
Console.WriteLine(dataAtual.Month);
Console.WriteLine(dataAtual.Day);
Console.WriteLine(dataAtual.Hour);
Console.WriteLine(dataAtual.Minute);
Console.WriteLine(dataAtual.Second);

Console.WriteLine("********************************");
Console.WriteLine(dataAtual.DayOfWeek);
Console.WriteLine(dataAtual.DayOfYear);

//Criar uma data especifica
DateTime data = new DateTime(2022, 09, 25);

Console.WriteLine("Data especifica: " + data);
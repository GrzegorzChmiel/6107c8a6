Console.WriteLine("Witaj w programie Trojkat");

Console.WriteLine();

Console.WriteLine("Podaj dlugości bokow trojkata rozdzielone spacjami:");
var dataString = Console.ReadLine();
var dataParts = dataString?.Split(' ');
if (dataParts?.Length != 3)
{
   Console.WriteLine("Niestety nie podano trzech dlugosci bokow trojkata. Uruchom program ponownie.");
   Console.ReadKey();
   return;
}

if (!float.TryParse(dataParts[0], out var a) || !float.TryParse(dataParts[1], out var b) || !float.TryParse(dataParts[2], out var c))
{
   Console.WriteLine("Niestety podane wartosci nie sa liczbami. Uruchom program ponownie.");
   Console.ReadKey();
   return;
}

if (a + b > c && a + c > b && b + c > 0)
{
   Console.WriteLine("W porzadku - mozna skonstruowac trojkat.");
}
else
{
   Console.WriteLine("Niestety - nie mozna skonstruowac trojkata.");
}

Console.ReadKey();
return;
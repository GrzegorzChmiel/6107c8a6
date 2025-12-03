Console.WriteLine("Witaj w programie Porownanie");

Console.WriteLine();

Console.WriteLine("Podaj prosze pierwsza liczbe calkowita:");
var number1String = Console.ReadLine();
if (!int.TryParse(number1String, out var number1))
{
   Console.WriteLine("Niestety pierwsza liczba zostala podana niepoprawnie. Uruchom program ponownie.");
   Console.ReadKey();
   return;
}

Console.WriteLine();

Console.WriteLine("Podaj prosze druga liczbe calkowita:");
var number2String = Console.ReadLine();
if (!int.TryParse(number2String, out var number2))
{
   Console.WriteLine("Niestety druga liczba zostala podana niepoprawnie. Uruchom program ponownie.");
   Console.ReadKey();
   return;
}

Console.WriteLine();

if (number1 == number2)
   Console.WriteLine("Wprowadzone liczby sa rowne.");
else
   Console.WriteLine($"Liczby: {number1} i {number2} nie sa rowne.");

Console.ReadKey();
return;
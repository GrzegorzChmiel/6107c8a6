Console.WriteLine("Witaj w programie Liczba parzysta");

Console.WriteLine();

Console.WriteLine("Podaj prosze liczbe:");
var numberString = Console.ReadLine();
if (!int.TryParse(numberString, out var number))
{
   Console.WriteLine("Niestety liczba zostala podana niepoprawnie. Uruchom program ponownie.");
   Console.ReadKey();
   return;
}

Console.WriteLine();

if (number % 2 == 0)
   Console.WriteLine($"Liczba: {number} jest liczba parzysta.");
else
   Console.WriteLine($"Liczba: {number} nie jest liczba parzysta.");

Console.ReadKey();
return;
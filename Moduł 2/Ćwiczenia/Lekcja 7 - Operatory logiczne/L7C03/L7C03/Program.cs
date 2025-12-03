Console.WriteLine("Witaj w programie Jaka liczba");

Console.WriteLine();

Console.WriteLine("Podaj prosze liczbe:");
var numberString = Console.ReadLine();
if (!double.TryParse(numberString, out var number))
{
   Console.WriteLine("Niestety liczba zostala podana niepoprawnie. Uruchom program ponownie.");
   Console.ReadKey();
   return;
}

Console.WriteLine();

if(number < 0)
   Console.WriteLine($"Liczba: {number} jest liczba ujemna.");
else
   Console.WriteLine($"Liczba: {number} jest liczba dodatnia.");

Console.ReadKey();
return;
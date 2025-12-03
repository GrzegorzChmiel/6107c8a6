Console.WriteLine("Witaj w programie Porownanie");

Console.WriteLine();

Console.WriteLine("Podaj prosze pierwsza liczbe:");
var firstString = Console.ReadLine();
if (!float.TryParse(firstString, out var first))
{
   Console.WriteLine("Niestety liczba zostala podana niepoprawnie. Uruchom program ponownie.");
   Console.ReadKey();
   return;
}

Console.WriteLine("Podaj prosze druga liczbe:");
var secondString = Console.ReadLine();
if (!float.TryParse(secondString, out var second))
{
   Console.WriteLine("Niestety liczba zostala podana niepoprawnie. Uruchom program ponownie.");
   Console.ReadKey();
   return;
}

Console.WriteLine("Podaj prosze trzecia liczbe:");
var thirdString = Console.ReadLine();
if (!float.TryParse(thirdString, out var third))
{
   Console.WriteLine("Niestety liczba zostala podana niepoprawnie. Uruchom program ponownie.");
   Console.ReadKey();
   return;
}

var allEqual = false;
var firstTheBiggest = false;
var secondTheBiggest = false;
var thirdTheBiggest = false;

if (Math.Abs(first - second) < 0.01 && Math.Abs(first - third) < 0.01)
   allEqual = true;
else if (first - second >= 0 && first - third >= 0)
   firstTheBiggest = true;
else if (second - first >= 0 && second - third >= 0)
   secondTheBiggest = true;
else if (third - first >= 0 && third - second >= 0)
   thirdTheBiggest = true;


if(allEqual)
   Console.WriteLine("Wszystkie liczby równe.");
else if (firstTheBiggest)
   Console.WriteLine("Najwieksza liczba jest liczba pierwsza.");
else if (secondTheBiggest)
   Console.WriteLine("Najwieksza liczba jest liczba druga.");
else if (thirdTheBiggest)
   Console.WriteLine("Najwieksza liczba jest liczba trzecia.");


Console.ReadKey();
return;
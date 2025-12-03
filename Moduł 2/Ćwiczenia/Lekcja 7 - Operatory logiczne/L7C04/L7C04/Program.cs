Console.WriteLine("Witaj w programie Rok przestepny");

Console.WriteLine();

Console.WriteLine("Podaj prosze rok:");
var yearString = Console.ReadLine();
if (!int.TryParse(yearString, out var year) || year <= 0)
{
   Console.WriteLine("Niestety rok zostal podany niepoprawnie. Uruchom program ponownie.");
   Console.ReadKey();
   return;
}

Console.WriteLine();

var firstCondition = year % 400 == 0;
var secondCondition = year % 4 == 0 && year % 100 != 0;
if (firstCondition || secondCondition)
   Console.WriteLine($"Rok {year} jest rokiem przestepnym.");
else
   Console.WriteLine($"Rok {year} nie jest rokiem przestepnym.");

Console.ReadKey();
return;
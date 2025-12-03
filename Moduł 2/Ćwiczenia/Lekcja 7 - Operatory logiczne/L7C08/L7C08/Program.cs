Console.WriteLine("Witaj w programie Rekrutacja");

Console.WriteLine();

Console.WriteLine("Podaj prosze wynik z matematyki:");
var mathString = Console.ReadLine();
if (!int.TryParse(mathString, out var math) || math < 0)
{
   Console.WriteLine("Niestety podana wartosc nie jest poprawnym okresleniem wyniku.Uruchom program ponownie.");
   Console.ReadKey();
   return;
}

Console.WriteLine("Podaj prosze wynik z chemii:");
var chemistryString = Console.ReadLine();
if (!int.TryParse(chemistryString, out var chemistry) || chemistry < 0)
{
   Console.WriteLine("Niestety podana wartosc nie jest poprawnym okresleniem wyniku.Uruchom program ponownie.");
   Console.ReadKey();
   return;
}

Console.WriteLine("Podaj prosze wynik z fizyki:");
var physicsString = Console.ReadLine();
if (!int.TryParse(physicsString, out var physics) || physics < 0)
{
   Console.WriteLine("Niestety podana wartosc nie jest poprawnym okresleniem wyniku.Uruchom program ponownie.");
   Console.ReadKey();
   return;
}

var conditionOne = math > 70 && chemistry > 45 && physics > 55 && math + chemistry + physics > 70;
var conditionTwo = math + chemistry > 150 || math + physics > 150;

if (conditionOne || conditionTwo)
{
   Console.WriteLine("Kandydat dopuszczony do rekrutacji.");
   Console.WriteLine($"Spelniony warunek: {(conditionOne ? "perwszy" : "drugi")}");
}
else
   Console.WriteLine("Kandydat niestety nie dopuszczony do rekrutacji.");

Console.ReadKey();
return;
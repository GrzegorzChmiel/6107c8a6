Console.WriteLine("Witaj w programie Temperatura");

Console.WriteLine();

Console.WriteLine("Podaj prosze temperature:");
var temperatureString = Console.ReadLine();
if (!float.TryParse(temperatureString, out var temperature))
{
   Console.WriteLine("Niestety podana wartosc nie jest liczba. Uruchom program ponownie.");
   Console.ReadKey();
   return;
}

if (temperature < 0)
{
   Console.WriteLine("Bardzo zimno.");
}
else if (temperature >= 0 && temperature < 10)
{
   Console.WriteLine("Zimno.");
}
else if (temperature >= 10 && temperature < 20)
{
   Console.WriteLine("Chlodno.");
}
else if (temperature >= 20 && temperature < 30)
{
   Console.WriteLine("W sam raz.");
}
else if (temperature >= 30 && temperature < 40)
{
   Console.WriteLine("Zaczyna byc goraco.");
}
else
{
   Console.WriteLine("Bardzo goraco.");
}


Console.WriteLine();

Console.ReadKey();
return;
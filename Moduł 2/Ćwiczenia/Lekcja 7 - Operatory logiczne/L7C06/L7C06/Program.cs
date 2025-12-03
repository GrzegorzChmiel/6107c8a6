Console.WriteLine("Witaj w programie Wzrost");

Console.WriteLine();

Console.WriteLine("Podaj prosze swoj wzrost w centymetrach:");
var heightString = Console.ReadLine();
if (!float.TryParse(heightString, out var height) || height<= 0)
{
   Console.WriteLine("Niestety wzrost zostal podany niepoprawnie. Uruchom program ponownie.");
   Console.ReadKey();
   return;
}

var message = "Twoj wzrost nalezy do kategorii: ";
if (height < 170)
{
   message += "niski";
}
else if (height < 180)
{
   message += "sredni";
}
else if (height < 190)
{
   message += "powyzej sredniej";
}
else if (height < 200)
{
   message += "wysoki";
}
else
{
   message += "bardzo wysoki";
}

Console.WriteLine(message);

Console.ReadKey();
return;
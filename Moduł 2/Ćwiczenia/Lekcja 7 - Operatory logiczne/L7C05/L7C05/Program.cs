Console.WriteLine("Witaj w programie Kwalifikacja wiekowa");

Console.WriteLine();

Console.WriteLine("Podaj prosze swoj wiek w latach:");
var ageString = Console.ReadLine();
if (!int.TryParse(ageString, out var age) || age <= 0)
{
   Console.WriteLine("Niestety wiek zostal podany niepoprawnie. Uruchom program ponownie.");
   Console.ReadKey();
   return;
}

string message;
if (age < 21)
   message = "Jeszcze za wczesnie na polityke";
else if (age < 30)
   message = "Mozesz zostac poslem/premierem";
else if (age < 35)
   message = "Mozesz zostac senatorem/premierem";
else
   message = "Mozesz juz zostac prezydentem";

Console.WriteLine(message);

Console.ReadKey();
return;
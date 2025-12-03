Console.WriteLine("Witaj w programie Kalendarz");

Console.WriteLine();

Console.WriteLine("Podaj numer dnia tygodnia:");
var dayNumberString = Console.ReadLine();
if (!int.TryParse(dayNumberString, out var dayNumber) || dayNumber < 1 || dayNumber > 7)
{
   Console.WriteLine("Niestety podany numer nie okresla dnia tygodnia w prawidlowy sposob. Uruchom program ponownie.");
   Console.ReadKey();
   return;
}

Console.WriteLine();

Console.WriteLine("Podany numer odpowiada dniu tygodnia:");
switch (dayNumber)
{
   case 1: Console.WriteLine("Poniedzialek"); break;
   case 2: Console.WriteLine("Wtorek"); break;
   case 3: Console.WriteLine("Sroda"); break;
   case 4: Console.WriteLine("Czwartek"); break;
   case 5: Console.WriteLine("Piatek"); break;
   case 6: Console.WriteLine("Sobota"); break;
   case 7: Console.WriteLine("Niedziela"); break;
   default: Console.WriteLine("Nie ma dnia tygodnia dla podanego numeru."); break;
}

Console.ReadKey();
return;
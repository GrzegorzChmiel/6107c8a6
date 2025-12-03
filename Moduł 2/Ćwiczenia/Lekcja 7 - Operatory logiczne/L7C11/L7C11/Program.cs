Console.WriteLine("Witaj w programie Ocena");

Console.WriteLine();

Console.WriteLine("Podaj cyfre okreslajaca ocene:");
var numberString = Console.ReadLine();
if (!int.TryParse(numberString, out var number) || number < 1 || number > 7)
{
   Console.WriteLine("Niestety nie podano poprawnej cyfry okreslajacej ocene. Uruchom program ponownie.");
   Console.ReadKey();
   return;
}

Console.WriteLine();

Console.WriteLine("Podana cyfra odpowiada nastepujacej ocenie:");
switch (number)
{
   case 1: Console.WriteLine("Niedostateczny"); break;
   case 2: Console.WriteLine("Dopuszczajacy"); break;
   case 3: Console.WriteLine("Dostateczny"); break;
   case 4: Console.WriteLine("Dobry"); break;
   case 5: Console.WriteLine("Bardzo dobry"); break;
   case 6: Console.WriteLine("Celujacy"); break;
   default: Console.WriteLine("Nie ma oceny odpowiadajacej podanej cyfrze."); break;
}

Console.ReadKey();
return;
// See https://aka.ms/new-console-template for more information
Console.WriteLine("Start");
Console.WriteLine();

string name = "";
string surname = "";
string phoneNumber = "";
string email = "";
float height = 0;
float weight = 0;
DateTime dateOfBirth = DateTime.MinValue;
short age = 0;
string sex = "";
string country = "";
string province = "";
string postalCode = "";
string city = "";
string street = "";
string buildingNumer = "";
short flatNumber = 0;

Console.WriteLine("Wprowadz dane:");
Console.WriteLine("--------------");
Console.WriteLine();

Console.WriteLine("Podaj imie:");
name = Console.ReadLine() ?? string.Empty;
Console.WriteLine("Podaj nazwisko:");
surname = Console.ReadLine() ?? string.Empty;
Console.WriteLine("Podaj numer telefonu:");
phoneNumber = Console.ReadLine() ?? string.Empty;
Console.WriteLine("Podaj e-mail:");
email = Console.ReadLine() ?? string.Empty;
Console.WriteLine("Podaj wzrost:");
height = Convert.ToSingle(Console.ReadLine());
Console.WriteLine("Podaj wagę:");
weight = Convert.ToSingle(Console.ReadLine());
Console.WriteLine("Podaj datę urodzenia:");
dateOfBirth = Convert.ToDateTime(Console.ReadLine());
Console.WriteLine("Podaj wiek:");
age = Convert.ToInt16(Console.ReadLine());
Console.WriteLine("Podaj płeć:");
sex = Console.ReadLine() ?? string.Empty;
Console.WriteLine("Podaj kraj zamieszkania:");
country = Console.ReadLine() ?? string.Empty;
Console.WriteLine("Podaj województwo:");
province = Console.ReadLine() ?? string.Empty;
Console.WriteLine("Podaj kod pocztowy:");
postalCode = Console.ReadLine() ?? string.Empty;
Console.WriteLine("Podaj miasto:");
city = Console.ReadLine() ?? string.Empty;
Console.WriteLine("Podaj ulicę:");
street = Console.ReadLine() ?? string.Empty;
Console.WriteLine("Podaj numer budynku:");
buildingNumer = Console.ReadLine() ?? string.Empty;
Console.WriteLine("Podaj numer mieszkania:");
flatNumber = Convert.ToInt16(Console.ReadLine());

Console.WriteLine();

Console.WriteLine("Wprowadzone dane:");
Console.WriteLine("-----------------");

Console.WriteLine();

Console.WriteLine($"Imie: {name}");
Console.WriteLine($"Nazwisko: {surname}");
Console.WriteLine($"Numer telefonu: {phoneNumber}");
Console.WriteLine($"E-mail: {email}");
Console.WriteLine($"Wzrost: {height}");
Console.WriteLine($"Waga: {weight}");
Console.WriteLine($"Data urodzenia: {dateOfBirth.ToLongDateString()}");
Console.WriteLine($"Wiek: {age}");
Console.WriteLine($"Płeć: {sex}");
Console.WriteLine($"Kraj zamieszkania: {country}");
Console.WriteLine($"Województwo: {province}");
Console.WriteLine($"Kod pocztowy: {postalCode}");
Console.WriteLine($"Miasto: {city}");
Console.WriteLine($"Ulica: {street}");
Console.WriteLine($"Numer budynku: {buildingNumer}");
Console.WriteLine($"Numer mieszkania: {flatNumber}");

Console.WriteLine();
Console.WriteLine("Stop");
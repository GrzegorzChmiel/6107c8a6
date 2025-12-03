Console.WriteLine("Witaj w programie Kalkulator");

Console.WriteLine();

Console.WriteLine("Podaj pierwsza liczbe:");
var firstNumberString = Console.ReadLine();
if (!double.TryParse(firstNumberString, out var firstNumber))
{
   Console.WriteLine("Niestety nie podano poprawnej liczby. Uruchom program ponownie.");
   Console.ReadKey();
   return;
}

Console.WriteLine();

Console.WriteLine("Podaj druga liczbe:");
var secondNumberString = Console.ReadLine();
if (!double.TryParse(secondNumberString, out var secondNumber))
{
   Console.WriteLine("Niestety nie podano poprawnej liczby. Uruchom program ponownie.");
   Console.ReadKey();
   return;
}

Console.WriteLine();

Console.WriteLine("Podaj dzialanie do wykonania:");
Console.WriteLine("-----------------------------");
Console.WriteLine("1 - Dodawanie");
Console.WriteLine("2 - Odejmowanie");
Console.WriteLine("3 - Mnożenie");
Console.WriteLine("4 - Dzielenie");

var choiceString = Console.ReadLine();
if (!int.TryParse(choiceString, out var choice))
{
   Console.WriteLine("Niestety nie podano poprawnej liczby okreslajacej dzialanie. Uruchom program ponownie.");
   Console.ReadKey();
   return;
}

Console.WriteLine();

switch (choice)
{
   case 1:
      {
         Console.WriteLine($"Wynik: {Add(firstNumber, secondNumber)}");
         break;
      }
   case 2:
      {
         Console.WriteLine($"Wynik: {Subtract(firstNumber, secondNumber)}");
         break;
      }
   case 3:
      {
         Console.WriteLine($"Wynik: {Multiply(firstNumber, secondNumber)}");
         break;
      }
   case 4:
      {
         Console.WriteLine($"Wynik: {Divide(firstNumber, secondNumber)}");
         break;
      }
   default:
      {
         Console.WriteLine("Niestety nie podano poprawnej liczby okreslajacej dzialanie. Uruchom program ponownie.");
         Console.ReadKey();
         return;
      }
}

Console.ReadKey();
return;

///////Metody lokalne///////
static double Add(double a, double b) => a + b;

static double Subtract(double a, double b) => a - b;

static double Multiply(double a, double b) => a * b;

static double Divide(double a, double b)
{
   if (b != 0)
      return a / b;

   Console.WriteLine("Nie mozna dzielic przez zero.");
   return 0;
}
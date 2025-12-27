using static System.Console;

namespace L8C07
{
   internal class Program
   {
      static void Main(string[] args)
      {
         WriteLine("Witaj w programie Diament.");
         Write("Podaj liczbe znakow krotszej przekatnej (nieparzysta): ");
         int n;
         var line = ReadLine();
         while (!int.TryParse(line ?? string.Empty, out n) || n % 2 == 0)
         {
            Write("Niepoprawna liczba. Podaj poprawna liczbe: ");
            line = ReadLine();
         }

         WriteLine();

         var middle = n / 2 + 1;
         var spread = 0;
         for (var i = 1; i <= middle; i++)
         {
            for (var k = 1; k <= n; k++)
            {
               if (k >= middle - spread && k <= middle + spread)
                  Write('*');
               else
                  Write(' ');
            }
            spread += 1;
            WriteLine();
         }

         spread -= 2;
         for (var i = middle - 2; i >= 0; i--)
         {
            for (var k = 1; k <= n; k++)
            {
               if (k >= middle - spread && k <= middle + spread)
                  Write('*');
               else
                  Write(' ');
            }
            spread -= 1;
            WriteLine();
         }

         ReadKey();
         return;
      }
   }
}

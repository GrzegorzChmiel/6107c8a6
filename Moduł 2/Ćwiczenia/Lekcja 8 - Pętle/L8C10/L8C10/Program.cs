namespace L8C10
{
   internal class Program
   {
      private static void Main(string[] args)
      {
         Console.WriteLine("Witaj w programie NWW.");

         Console.WriteLine();

         Console.Write("Podaj pierwsza liczbe: ");
         int n1;
         var n1Str = Console.ReadLine();
         while (!int.TryParse(n1Str ?? string.Empty, out n1))
         {
            Console.Write("Niepoprawna liczba. Podaj poprawną liczbę: ");
            n1Str = Console.ReadLine();
         }

         Console.WriteLine();

         Console.Write("Podaj druga liczbe: ");
         int n2;
         var n2Str = Console.ReadLine();
         while (!int.TryParse(n2Str ?? string.Empty, out n2))
         {
            Console.Write("Niepoprawna liczba. Podaj poprawną liczbę: ");
            n2Str = Console.ReadLine();
         }

         Console.WriteLine();

         var nww = 0;
         var n1Mul = n1;
         var n2Mul = n2;
         var tmp = n1 >= n2 ? n1 : n2;
         var n1Ctr = 1;
         var n2Ctr = 1;
         do
         {
            while (tmp > n1Mul)
            {
               n1Mul = n1 * n1Ctr;
               n1Ctr++;
            }
            tmp = n1Mul;
            if (tmp == n2Mul)
            {
               nww = tmp;
               break;
            }

            while (tmp > n2Mul)
            {
               n2Mul = n2 * n2Ctr;
               n2Ctr++;
            }
            tmp = n2Mul;
            if (tmp == n1Mul)
            {
               nww = tmp;
               break;
            }

         } while (true);

         Console.WriteLine($"Najmniejsza wspolna wielokrotnosc liczb: {n1} i {n2} wynosi: {nww}");

         Console.ReadKey();
         return;
      }
   }
}

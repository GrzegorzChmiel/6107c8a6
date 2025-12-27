namespace L8C03
{
   internal class Program
   {
      static void Main(string[] args)
      {
         Console.WriteLine("Witaj w programie Fibonacci.");
         Console.Write("Podaj liczbę elementów ciągu do wygenerowania: ");
         int n;
         var line = Console.ReadLine();
         while (!int.TryParse(line ?? string.Empty, out n))
         {
            Console.Write("Niepoprawna liczba. Podaj poprawną liczbę: ");
            line = Console.ReadLine();
         }

         Console.WriteLine();

         var list = new List<long>();
         long nm2 = 0;
         long nm1 = 1;
         for (var i = 0; i < n; i++)
         {
            switch (i)
            {
               case 0:
                  list.Add(nm2);
                  break;
               case 1:
                  list.Add(nm1);
                  break;
               default:
               {
                  var ni = nm1 + nm2;
                  list.Add(ni);
                  nm2 = nm1;
                  nm1 = ni;
                  break;
               }
            }
         }

         Console.WriteLine("Wygenerowany ciąg Fibonacciego:");
         Console.WriteLine(string.Join(", ", list));

         Console.ReadKey();
         return;
      }
   }
}

namespace L8L04
{
   internal class Program
   {
      static void Main(string[] args)
      {
         Console.WriteLine("Witaj w programie Diament.");
         Console.Write("Podaj liczbę elementów do wygenerowania: ");
         int n;
         var line = Console.ReadLine();
         while (!int.TryParse(line ?? string.Empty, out n))
         {
            Console.Write("Niepoprawna liczba. Podaj poprawną liczbę: ");
            line = Console.ReadLine();
         }

         var number = 1;
         var stop = false;
         var prevRowCol = 0;
         while (!stop)
         {
            var colCtr = 0;
            while (colCtr <= prevRowCol)
            {
               Console.Write(number + " ");
               number++;
               colCtr++;

               if (number <= n) 
                  continue;
               
               stop = true;
               break;
            }
 
            Console.WriteLine();
            prevRowCol = colCtr;
         }

         Console.ReadKey();
         return;
      }
   }
}

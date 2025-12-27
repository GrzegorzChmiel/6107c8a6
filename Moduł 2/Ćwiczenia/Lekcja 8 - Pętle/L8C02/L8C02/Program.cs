namespace L8C02
{
   internal class Program
   {
      static void Main(string[] args)
      {
         Console.WriteLine("Witaj w programie Licznik parzystych w zakresie 0 - 1000.");
         Console.WriteLine();

         var ctr = 0;
         var evenCtr = 0;
         do
         {
            if (IsEven(ctr))
            {
               Console.WriteLine($"Liczba parzysta: {ctr}");
               evenCtr++;
            }

            ctr++;
         } while (ctr <= 1000);

         Console.WriteLine();

         Console.WriteLine($"W zakresie od 0 do 1000 znaleziono {evenCtr} liczb parzystych.");

         Console.ReadKey();
         return;
      }

      private static bool IsEven(int number) => number % 2 == 0;
   }
}

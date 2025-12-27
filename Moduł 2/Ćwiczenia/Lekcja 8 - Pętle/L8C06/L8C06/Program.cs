namespace L8C06
{
   internal class Program
   {
      static void Main(string[] args)
      {
         Console.WriteLine("Witaj w programie Suma ciagu harmonicznego.");
         Console.Write("Podaj liczbę elementów do wygenerowania: ");
         int n;
         var line = Console.ReadLine();
         while (!int.TryParse(line ?? string.Empty, out n))
         {
            Console.Write("Niepoprawna liczba. Podaj poprawną liczbę: ");
            line = Console.ReadLine();
         }

         Console.WriteLine();

         var list = new List<string>();
         var sum = 0.0;
         for (var i = 1; i <= n; i++)
         {
            var element = (double)1/i;
            sum += element;

            var elementString = $"{element}\n";
            list.Add(elementString);
         }

         Console.WriteLine("Kolejne elementy ciagu:");
         Console.WriteLine(string.Join("", list));

         Console.WriteLine();
         Console.Write($"Suma {n} wyrazow ciagu wynosi: {sum}.");

         Console.ReadKey();
         return;
      }
   }
}

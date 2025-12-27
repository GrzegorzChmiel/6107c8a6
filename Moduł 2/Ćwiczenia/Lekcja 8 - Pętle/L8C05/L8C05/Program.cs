namespace L8C05
{
   internal class Program
   {
      private static void Main(string[] args)
      {
         Console.WriteLine("Witaj w programie Trzecia potega.");
         
         Console.WriteLine();

         Console.WriteLine("Ponizej trzecie potegi liczb z zakresu 1 - 20:");
         for (var i = 1; i <= 20; i++)
         {
            Console.WriteLine($"Dla liczby: {i} trzecia potega to: {Math.Pow(i, 3)}.");
         }

         Console.ReadKey();
         return;
      }
   }
}

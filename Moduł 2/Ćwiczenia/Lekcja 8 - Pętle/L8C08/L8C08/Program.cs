namespace L8C08
{
   internal class Program
   {
      private static void Main(string[] args)
      {
         Console.WriteLine("Witaj w programie Odwracacz.");

         Console.WriteLine();

         Console.Write("Podaj sekwencje do odwrocenia: ");
         var input = Console.ReadLine() ?? string.Empty;

         Console.WriteLine();

         var tempOutput = new char[input.Length];
         var tempOutputCtr = 0;
         for (var i = input.Length - 1; i >= 0; i--)
         {
            tempOutput[tempOutputCtr] = input[i];
            tempOutputCtr++;
         }
         var output = new string(tempOutput);
         Console.WriteLine("Odwrocona sekwencja:");
         Console.WriteLine(output);

         Console.ReadKey();
         return;
      }
   }
}

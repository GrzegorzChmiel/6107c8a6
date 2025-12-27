namespace L8C09
{
    internal class Program
    {
       private static void Main(string[] args)
        {
         Console.WriteLine("Witaj w programie Liczba binarna.");
         Console.Write("Podaj dodatnia liczbe calkowita do zamiany na binarna: ");
         int n;
         var line = Console.ReadLine();
         while (!int.TryParse(line ?? string.Empty, out n) || n < 0)
         {
            Console.Write("Niepoprawna liczba. Podaj poprawna liczbe: ");
            line = Console.ReadLine();
         }

         Console.WriteLine();

         var tempOutput = new List<char>();
         while (n > 0)
         {
            tempOutput.Add(n % 2 == 0 ? '0' : '1');
            n /= 2;
         }
         var output = string.Join("", tempOutput);
         Console.WriteLine($"Liczba {n} w zapisie binarnym: {output}");

         Console.ReadKey();
         return;
        }
    }
}

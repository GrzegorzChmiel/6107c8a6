namespace L8C01
{
   public class Program
   {
      private static void Main(string[] args)
      {
         Console.WriteLine("Witaj w programie Liczby pierwsze.");
         Console.WriteLine("Policzymy ile jest liczb pierwszych w zakresie 0 - 100.");

         var list = new List<int>();
         for (var i = 0; i < 100; i++)
         {
            if(IsPrime(i))
               list.Add(i);
         }

         Console.WriteLine("W zakresie 0 - 100 jest {0} liczb pierwszych.", list.Count);
         Console.WriteLine("Są to: {0}", string.Join(", ", list));

         Console.ReadKey();
         return;
      }

      public static bool IsPrime(int number)
      {
         if (number <= 1)
         {
            return false;
         }

         for (var i = 2; i <= Math.Sqrt(number); i++)
         {
            if (number % i == 0)
            {
               return false;
            }
         }

         return true;
      }
   }
}

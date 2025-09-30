namespace OperatorsAndExpressions
{
   internal class NullCoalescingOperatorsExample : Example
   {
      public override void RunExample()
      {
         List<int>? numbers = null;
         int? a = null;

         Console.WriteLine($"Now list {nameof(numbers)} is {(numbers is null ? "null" : string.Join(',', numbers))}.");
         Console.WriteLine($"Now variable {nameof(a)} is {(a is null ? "null" : a)}.");

         PrintBrake();

         numbers ??= [1, 2, 3, 4, 5];
         Console.WriteLine($"Now list {nameof(numbers)} is {(numbers is null ? "null" : string.Join(',', numbers))}.");

         PrintBrake();

         Console.WriteLine($"Now variable {nameof(a)} is still null, so print {a ?? 3} instead of it.");

         PrintBrake();
         a ??= 8;
         Console.WriteLine($"Now variable {nameof(a)} is {(a is null ? "null" : a)}.");
      }
   }
}

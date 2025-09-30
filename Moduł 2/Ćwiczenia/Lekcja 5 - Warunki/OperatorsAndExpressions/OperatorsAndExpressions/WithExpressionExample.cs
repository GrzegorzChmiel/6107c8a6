namespace OperatorsAndExpressions
{
   internal class WithExpressionExample : Example
   {
      private record NamedPoint(
         string Name,
         int X,
         int Y
      );

      public override void RunExample()
      {
         Console.WriteLine("Example for record:");
         var point1 = new NamedPoint("Rectangle1", 10, 15);
         var point2 = point1 with { Name = "Rectangle2", X = 30 };

         Console.WriteLine($"{nameof(point1)}: {point1}");
         Console.WriteLine($"{nameof(point2)}: {point2}");

         PrintBrake();

         Console.WriteLine("Example for anonymous type:");
         var anonType1 = new
         {
            Brand = "Ford",
            Model = "Mondeo",
            Engine = 1.8,
            EngineType = "tdci"
         };
         var anonType2 = anonType1 with { Engine = 2.0, EngineType = "Duratec" };
         Console.WriteLine($"{nameof(anonType1)}: {anonType1}");
         Console.WriteLine($"{nameof(anonType2)}: {anonType2}");
      }
   }
}

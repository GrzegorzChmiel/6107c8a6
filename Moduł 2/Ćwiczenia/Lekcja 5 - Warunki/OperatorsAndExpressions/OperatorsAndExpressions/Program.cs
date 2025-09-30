using OperatorsAndExpressions;

Console.WriteLine("Start");
Console.WriteLine();
Console.ForegroundColor = ConsoleColor.DarkYellow;

Console.WriteLine("========================================");
Console.WriteLine("With expression example - start.");
var example1 = new WithExpressionExample();
example1.RunExample();
Console.WriteLine("With expression example - stop.");
Console.WriteLine("========================================");

Console.WriteLine();

Console.ForegroundColor = ConsoleColor.Yellow;

Console.WriteLine("========================================");
Console.WriteLine("Deconstruction expression example - start.");
var example2 = new DeconstructionExpressionExample();
example2.RunExample();
Console.WriteLine("Deconstruction expression example - stop.");
Console.WriteLine("========================================");

Console.WriteLine();

Console.ForegroundColor = ConsoleColor.DarkYellow;

Console.WriteLine("========================================");
Console.WriteLine("Null coalescing example - start.");
var example3 = new NullCoalescingOperatorsExample();
example3.RunExample();
Console.WriteLine("Null coalescing example - stop.");
Console.WriteLine("========================================");

Console.WriteLine();

Console.ForegroundColor = ConsoleColor.Yellow;

Console.WriteLine("========================================");
Console.WriteLine("Pattern matching example - start.");
var example4 = new PatternMatchingExample();
example4.RunExample();
Console.WriteLine("Pattern matching example - stop.");
Console.WriteLine("========================================");

Console.WriteLine();

Console.ResetColor();
Console.WriteLine();
Console.WriteLine("Stop");
Console.ReadKey();
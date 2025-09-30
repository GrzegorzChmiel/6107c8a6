namespace OperatorsAndExpressions
{
   internal class PatternMatchingExample : Example
   {
      public override void RunExample()
      {
         RunPart1();

         PrintBrake();

         RunPart2();

         PrintBrake();

         RunPart3();

         PrintBrake();

         RunPart4();

         PrintBrake();

         RunPart5();

         PrintBrake();

         RunPart6();

         PrintBrake();

         RunPart7();

         PrintBrake();

         RunPart8();

         PrintBrake();

         RunPart9();

         PrintBrake();

         RunPart10();

         PrintBrake();

         RunPart11();

         PrintBrake();

         RunPart12();
      }

      private void RunPart1()
      {
         /*
          * Declaration and type patterns.
         */
         Console.WriteLine("Patterns - Part 1:");

         object greeting = "Hello, World!";
         if (greeting is string message)
         {
            var messageToPrint = $"Object: {nameof(greeting)} is string with value: {message}";
            Console.WriteLine(messageToPrint);
         }
      }

      private void RunPart2()
      {
         /*
          * Declaration and type patterns.
         */
         Console.WriteLine("Patterns - Part 2:");

         var numbers = new int[] { 1, 2, 3, 4, 5 };
         Console.WriteLine($"In case of: {nameof(numbers)} the source is: {GetSourceLabel(numbers)}");

         var letters = new List<char>() { 'a', 'b', 'c', 'd', 'e' };
         Console.WriteLine($"In case of: {nameof(letters)} the source is: {GetSourceLabel(letters)}");
      }

      private void RunPart3()
      {
         /*
          * Declaration and type patterns.
         */
         Console.WriteLine("Patterns - Part 3:");

         int? xNullable = 7;
         int y = 23;
         object yBoxed = y;

         if (xNullable is { } a && yBoxed is int b)
         {
            Console.WriteLine($"Result of (a + b) is: {a + b}");
         }
      }

      private void RunPart4()
      {
         /*
          * Declaration and type patterns.
         */
         Console.WriteLine("Patterns - Part 4:");

         var car = new Car { Toll = 13m };
         var truck = new Truck { Toll = 28m };

         Console.WriteLine($"1. Toll for car is: {CalculateToll1(car)}");
         Console.WriteLine($"1. Toll for truck is: {CalculateToll1(truck)}");

         Console.WriteLine();

         Console.WriteLine($"2. Toll for car is: {CalculateToll2(car)}");
         Console.WriteLine($"2. Toll for truck is: {CalculateToll2(truck)}");

         Console.WriteLine();

         Console.WriteLine($"3. Toll for car is: {CalculateToll3(car)}");
         Console.WriteLine($"3. Toll for truck is: {CalculateToll3(truck)}");
      }

      private void RunPart5()
      {
         /*
          * Constant pattern.
         */
         Console.WriteLine("Patterns - Part 5:");

         Console.WriteLine($"1. Ticket price for one person is: {GetGroupTicketPrice(1)}");

         Console.WriteLine();

         Console.WriteLine($"2. Ticket price for two persons is: {GetGroupTicketPrice(2)}");

         Console.WriteLine();

         Console.WriteLine($"3. Ticket price for three persons is: {GetGroupTicketPrice(3)}");
      }

      private void RunPart6()
      {
         /*
          * Relational patterns.
         */
         Console.WriteLine("Patterns - Part 6:");

         double measuredValue = -4.025;
         Console.WriteLine($"1. Measured value: {measuredValue} is: {ClassifyMeasurment(measuredValue)}");
         measuredValue = 14.025;
         Console.WriteLine($"1. Measured value: {measuredValue} is: {ClassifyMeasurment(measuredValue)}");
         measuredValue = Double.NaN;
         Console.WriteLine($"1. Measured value: {measuredValue} is: {ClassifyMeasurment(measuredValue)}");
         measuredValue = 7.657;
         Console.WriteLine($"1. Measured value: {measuredValue} is: {ClassifyMeasurment(measuredValue)}");

         Console.WriteLine();

         DateTime date = new DateTime(2025, 1, 14);
         Console.WriteLine($"2. Date: {date} is: {GetCalendarSeason(date)}");
         date = new DateTime(2025, 4, 24);
         Console.WriteLine($"2. Date: {date} is: {GetCalendarSeason(date)}");
         date = new DateTime(2025, 9, 30);
         Console.WriteLine($"2. Date: {date} is: {GetCalendarSeason(date)}");
         date = new DateTime(2025, 6, 12);
         Console.WriteLine($"2. Date: {date} is: {GetCalendarSeason(date)}");

      }

      private void RunPart7()
      {
         /*
          * Logical patterns.
         */
         Console.WriteLine("Patterns - Part 7:");

         double measuredValue = -4.025;
         Console.WriteLine($"1. Measured value: {measuredValue} is: {ClassifyMeasurment2(measuredValue)}");
         measuredValue = 14.025;
         Console.WriteLine($"1. Measured value: {measuredValue} is: {ClassifyMeasurment2(measuredValue)}");
         measuredValue = Double.NaN;
         Console.WriteLine($"1. Measured value: {measuredValue} is: {ClassifyMeasurment2(measuredValue)}");
         measuredValue = 7.657;
         Console.WriteLine($"1. Measured value: {measuredValue} is: {ClassifyMeasurment2(measuredValue)}");

         Console.WriteLine();

         DateTime date = new DateTime(2025, 1, 14);
         Console.WriteLine($"2. Date: {date} is: {GetCalendarSeason2(date)}");
         date = new DateTime(2025, 4, 24);
         Console.WriteLine($"2. Date: {date} is: {GetCalendarSeason2(date)}");
         date = new DateTime(2025, 9, 30);
         Console.WriteLine($"2. Date: {date} is: {GetCalendarSeason2(date)}");
         date = new DateTime(2025, 6, 12);
         Console.WriteLine($"2. Date: {date} is: {GetCalendarSeason2(date)}");
      }

      private void RunPart8()
      {
         /*
          * Property pattern.
         */
         Console.WriteLine("Patterns - Part 8:");

         DateTime date = new DateTime(2025, 8, 7);
         Console.WriteLine($"1. The day: {date:yyyy-MM-dd} is conference day: {IsConferenceDay(date)}.");
         date = new DateTime(2025, 9, 10);
         Console.WriteLine($"1. The day: {date:yyyy-MM-dd} is conference day: {IsConferenceDay(date)}.");

         Console.WriteLine();

         string sentence = "Hello, World!";
         Console.WriteLine($"2. First five signs of sentence: \"{sentence}\" is: \"{TakeFirstFive(sentence)}\".");
         ICollection<char> letters = new List<char> { 'a', 'b', 'c', 'd', 'e', 'f', 'g', 'h' };
         Console.WriteLine(
            $"2. First five signs of collection: \"{new string(letters.ToArray())}\" is: \"{TakeFirstFive(letters)}\".");

         Console.WriteLine();

         Segment segment = new Segment(new Point(10, 20), new Point(12, 15));
         Console.WriteLine($"3. {segment} has any end on X axis: {IsAnyEndOnXAxis(segment)}");
         segment = new Segment(new Point(10, 10), new Point(12, 0));
         Console.WriteLine($"3. {segment} has any end on X axis: {IsAnyEndOnXAxis(segment)}");
      }

      private void RunPart9()
      {
         /*
          * Positional pattern.
          */
         Console.WriteLine("Patterns - Part 9:");

         PointStruct ps = new PointStruct(0, 0);
         Console.WriteLine($"Point struct of coordinates X: {ps.X}, Y: {ps.Y} is {ClassifyPointStruct(ps)}");
         PointStruct psX = new PointStruct(1, 0);
         Console.WriteLine($"Point struct of coordinates X: {psX.X}, Y: {psX.Y} is {ClassifyPointStruct(psX)}");
         PointStruct psY = new PointStruct(0, 1);
         Console.WriteLine($"Point struct of coordinates X: {psY.X}, Y: {psY.Y} is {ClassifyPointStruct(psY)}");
         PointStruct psXy = new PointStruct(8, 4);
         Console.WriteLine($"Point struct of coordinates X: {psXy.X}, Y: {psXy.Y} is {ClassifyPointStruct(psXy)}");

         Console.WriteLine();

         int groupSize = 5;
         DateTime visitDate = new DateTime(2025, 8, 8);
         Console.WriteLine($"Group ticket price discount for group size: {groupSize} and date: {visitDate:yyyy-MM-dd} is: {GetGroupTicketPriceDiscount(groupSize, visitDate)}");
         groupSize = 15;
         visitDate = new DateTime(2025, 7, 30);
         Console.WriteLine($"Group ticket price discount for group size: {groupSize} and date: {visitDate:yyyy-MM-dd} is: {GetGroupTicketPriceDiscount(groupSize, visitDate)}");
         groupSize = 4;
         visitDate = new DateTime(2025, 8, 28);
         Console.WriteLine($"Group ticket price discount for group size: {groupSize} and date: {visitDate:yyyy-MM-dd} is: {GetGroupTicketPriceDiscount(groupSize, visitDate)}");

         Console.WriteLine();

         List<int> numbers = [1, 4, 7, 8, 5, 2, 3, 6, 9];
         if (SumAndCount(numbers) is (Sum: var sum, Count: var cnt) {Count: > 0})
         {
            Console.WriteLine($"Sum of [{string.Join(", ", numbers)}] is: {sum} and Count is: {cnt}");
         }
         numbers = [1, 4, 7, 8];
         if (SumAndCount(numbers) is { Count: > 0 } sc)
         {
            Console.WriteLine($"Sum of [{string.Join(", ", numbers)}] is: {sc.Sum} and Count is: {sc.Count}");
         }
      }

      private void RunPart10()
      {
         /*
          * var pattern.
          */

         Console.WriteLine("Patterns - Part 10:");

         var id = 5;
         var limit = 1500;
         Console.WriteLine($"Checking if sequqnce is acceptable for id: {id} and limit: {limit}. Result: {IsSequenceAcceptable(id, limit)}");
         id = 40;
         limit = 700;
         Console.WriteLine($"Checking if sequqnce is acceptable for id: {id} and limit: {limit}. Result: {IsSequenceAcceptable(id, limit)}");

         Console.WriteLine();

         var point = new Point(10, 20);
         Console.WriteLine($"The {point} transformation is: {TransformPoint(point)}");
         point = new Point(4, 2);
         Console.WriteLine($"The {point} transformation is: {TransformPoint(point)}");
         point = new Point(7, 7);
         Console.WriteLine($"The {point} transformation is: {TransformPoint(point)}");
      }

      private void RunPart11()
      {
         /*
          * Discard pattern.
          */

         Console.WriteLine("Patterns - Part 11:");

         var dayOfWeek = DayOfWeek.Monday;
         Console.WriteLine($"In the day of week: {dayOfWeek} the discount in percent is equal: {GetDiscountInPercent(dayOfWeek)}");
         dayOfWeek = DayOfWeek.Wednesday;
         Console.WriteLine($"In the day of week: {dayOfWeek} the discount in percent is equal: {GetDiscountInPercent(dayOfWeek)}");
         dayOfWeek = (DayOfWeek)15;
         Console.WriteLine($"In the day of week: {dayOfWeek} the discount in percent is equal: {GetDiscountInPercent(dayOfWeek)}");
      }

      private void RunPart12()
      {
         /*
          * List patterns.
          */

         Console.WriteLine("Patterns - Part 12:");

         var numbers = new[] { 1, 2, 3 };
         Console.WriteLine($"Array {nameof(numbers)} is: {string.Join(", ", numbers)}");
         Console.WriteLine("List pattern is: [1, 2, 3]");
         Console.WriteLine($"Match result: {numbers is [1, 2, 3]}");
         Console.WriteLine("List pattern is: [1, 2, 4]");
         Console.WriteLine($"Match result: {numbers is [1, 2, 4]}");
         Console.WriteLine("List pattern is: [1, 2, 3, 4]");
         Console.WriteLine($"Match result: {numbers is [1, 2, 3, 4]}");
         Console.WriteLine("List pattern is: [0 or 1, <= 2, >= 3]");
         Console.WriteLine($"Match result: {numbers is [0 or 1, <= 2, >= 3]}");

         Console.WriteLine();

         var floatNumbers = new List<float> { 1.23f, 1.17f, 2.14f, 7.41f };
         Console.WriteLine($"Array {nameof(floatNumbers)} is: {string.Join(", ", floatNumbers)}");
         if (floatNumbers is [var first, _, _, _])
         {
            Console.WriteLine($"The first item in {nameof(floatNumbers)} is: {first:R}");
         }
      }

      private bool IsAnyEndOnXAxis(Segment segment) => segment is { Start: { Y: 0 } } or { End: { Y: 0 } };

      private bool IsAnyEndOnXAxis2(Segment segment) => segment is { Start.Y: 0 } or { End.Y: 0 };

      private string TakeFirstFive(object obj) => obj switch
      {
         string { Length: > 5 } s => s[..5],
         string s => s,

         ICollection<char> { Count: > 5 } col => new string([.. col.Take(5)]),
         ICollection<char> col => new string(col.ToArray()),

         null => throw new ArgumentNullException(nameof(obj)),
         _ => throw new NotSupportedException($"Not supported type of argument: {obj.GetType().Name}")
      };

      private bool IsConferenceDay(DateTime date) => date is { Month: 8 or 9, Day: > 9 and < 11 };

      private string ClassifyMeasurment(double measuredValue) => measuredValue switch
      {
         < -4.0 => "To low",
         > 10.0 => "To high",
         double.NaN => "Unknown",
         _ => "Acceptable"
      };

      private string GetCalendarSeason(DateTime date) => date.Month switch
      {
         >= 3 and < 6 => "Spring",
         >= 6 and < 9 => "Summer",
         >= 9 and < 12 => "Autumn",
         12 or (>= 1 and < 3) => "Winter",
         _ => throw new ArgumentOutOfRangeException(nameof(date), $"Date with unexpected month: {date.Month}")
      };

      private string ClassifyMeasurment2(double measuredValue) => measuredValue switch
      {
         < -40.0 => "Too low",
         >= -40.0 and < 0.0 => "Low",
         >= 0.0 and < 10 => "Acceptable",
         >= 10.0 and < 20.0 => "High",
         >= 20 => "Too high",
         double.NaN => "Unknown"
      };

      private string GetCalendarSeason2(DateTime date) => date.Month switch
      {
         3 or 4 or 5 => "Spring",
         6 or 7 or 8 => "Summer",
         9 or 10 or 11 => "Autumn",
         12 or (>= 1 and < 3) => "Winter",
         _ => throw new ArgumentOutOfRangeException(nameof(date), $"Date with unexpected month: {date.Month}")
      };

      private decimal GetGroupTicketPrice(byte visitorsCount) => visitorsCount switch
      {
         1 => 15m,
         2 => 14m,
         3 => 10m,
         _ => throw new ArgumentException($"Unsupported count of visitors: {visitorsCount}")
      };

      private decimal CalculateToll1(Vehicle vehicle) => vehicle switch
      {
         Car => 25m,
         Truck => 42m,
         null => throw new ArgumentNullException(nameof(vehicle)),
         _ => throw new ArgumentException("Unknown type of a vehicle", nameof(vehicle))
      };

      private decimal CalculateToll2(Vehicle vehicle) => vehicle switch
      {
         Car _ => 20m,
         Truck _ => 33m,
         null => throw new ArgumentNullException(nameof(vehicle)),
         _ => throw new ArgumentException("Unknown type of a vehicle", nameof(vehicle))
      };

      private decimal CalculateToll3(Vehicle vehicle) => vehicle switch
      {
         Car car => car.Toll,
         Truck truck => truck.Toll,
         null => throw new ArgumentNullException(nameof(vehicle)),
         _ => throw new ArgumentException("Unknown type of a vehicle", nameof(vehicle))
      };

      private string GetSourceLabel<T>(IEnumerable<T> source)
      {
         return source switch
         {
            Array array => "Array",
            ICollection<T> collection => "Collection",
            _ => throw new ArgumentOutOfRangeException(nameof(source), source, null)
         };
      }

      private string ClassifyPointStruct(PointStruct pointStruct) => pointStruct switch
      {
         (0, 0) => "Origin",
         (1, 0) => "Positive X basis end",
         (0, 1) => "Positive Y basis end",
         _ => "Just a point"
      };

      private decimal GetGroupTicketPriceDiscount(int groupSize, DateTime visitDate) => (groupSize, visitDate.DayOfWeek) switch
      {
         ( <= 0, _) => throw new ArgumentException("Group size must be positive"),
         (_, DayOfWeek.Saturday or DayOfWeek.Sunday) => 0m,
         ( >= 5 and < 10, DayOfWeek.Monday) => 20m,
         ( >= 10, DayOfWeek.Monday) => 30m,
         ( >= 5 and < 10, _) => 12m,
         ( >= 10, _) => 15m,
         _ => 0m
      };

      private (int Sum, int Count) SumAndCount(IEnumerable<int> source)
      {
         int sum = 0;
         int cnt = 0;

         foreach (var num in source)
         {
            sum += num;
            cnt++;
         }

         return (sum, cnt);
      }

      private int[] SimulateDataFetch(int id)
      {
         var random = new Random(id);
         var sequence = Enumerable.Range(0, 200);
         var randomSequence = sequence.Select(i => i * random.Next(-10, 11) / 3);
         var result = randomSequence.AsParallel().ToArray();

         return result;
      }

      private bool IsSequenceAcceptable(int id, int limit) => SimulateDataFetch(id) is var results && results.Max() <= limit && results.Min() >= -limit;

      private Point TransformPoint(Point point) => point switch
      {
         var (x, y) when x > y => new Point(x, -y),
         var (x, y) when x < y => new Point(-x, y),
         _ => point
      };

      private decimal GetDiscountInPercent(DayOfWeek dayOfWeek) => dayOfWeek switch
      {
         DayOfWeek.Monday => 0.5m,
         DayOfWeek.Tuesday => 2.5m,
         DayOfWeek.Wednesday => 3.5m,
         DayOfWeek.Thursday => 0.2m,
         DayOfWeek.Friday => 1.5m,
         DayOfWeek.Saturday => 0.8m,
         DayOfWeek.Sunday => 5m,
         _ => 0.0m
      };
   }

   internal abstract class Vehicle
   {
      public decimal Toll { get; init; }
   }

   internal class Car : Vehicle
   {

   }

   internal class Truck : Vehicle
   {

   }

   internal record Point(int X, int Y);

   internal record Segment(Point Start, Point End);

   internal readonly struct PointStruct(int x, int y)
   {
      public int X { get; init; } = x;
      public int Y { get; init; } = y;

      public void Deconstruct(out int x, out int y)
      {
         x = X;
         y = Y;
      }
   }
}

namespace OperatorsAndExpressions
{
   internal class DeconstructionExpressionExample : Example
   {
      private record House(int Area, string Address)
      {
         public required string RelatorNotes { get; set; }
      }

      private record Book(string Title, string Author)
      {
         public required string Description { get; init; }

         public void Deconstruct(out string title, out string author, out string desc)
         {
            title = Title;
            author = Author;
            desc = Description;
         }
      }

      private readonly struct Point3D
      {
         public int X { get; init; }
         public int Y { get; init; }
         public int Z { get; init; }

         public void Deconstruct(out int x, out int y, out int z)
         {
            x = X;
            y = Y;
            z = Z;
         }

         public void Deconstruct(out int x, out int y)
         {
            x = X;
            y = Y;
         }
      }

      private class User
      {
         public required string Name { get; init; }

         public required string Surname { get; init; }

         public required string Email { get; init; }

         public void Deconstruct(out string name, out string surname, out string email)
         {
            name = Name;
            surname = Surname;
            email = Email;
         }

         public void Deconstruct(out string name, out string surname)
         {
            name = Name;
            surname = Surname;
         }
      }

      public override void RunExample()
      {
         Console.WriteLine("Example for tuple:");
         var tuple = (X: 20, Y: 50, Desc: "Coordinates reserved");
         Console.WriteLine($"Created {nameof(tuple)}: {tuple}");

         var (x, y, _) = tuple;

         Console.WriteLine("Deconstructed tuple coordinates:");
         Console.WriteLine($"X: {x}");
         Console.WriteLine($"Y: {y}");


         PrintBrake();

         Console.WriteLine("Example for record:");
         var house = new House(200, "Appointment street 10")
         {
            RelatorNotes = "Very fine house"
         };
         Console.WriteLine($"Created record: {nameof(house)}, {nameof(house.Area)}: {house.Area}, {nameof(house.Address)}: {house.Address}");

         var (area, address) = house;

         Console.WriteLine("Deconstructed record:");
         Console.WriteLine($"Area: {area}");
         Console.WriteLine($"Address: {address}");

         PrintBrake();

         Console.WriteLine("Example for the record with deconstruct method:");
         var book = new Book("Big collapse", "Dennis Northon")
         {
            Description = "History of a big human collapse"
         };
         Console.WriteLine($"Created record: {nameof(book)}, {nameof(book.Title)}: {book.Title}, {nameof(book.Author)}: {book.Author}, {nameof(book.Description)}: {book.Description}");

         var (title, author, desc) = book;

         Console.WriteLine("Deconstructed record:");
         Console.WriteLine($"Title: {title}");
         Console.WriteLine($"Author: {author}");
         Console.WriteLine($"Description: {desc}");

         PrintBrake();

         Console.WriteLine("Example for struct with deconstruct method:");
         var point3D = new Point3D { X = 10, Y = 20, Z = 50 };
         Console.WriteLine($"Created struct: {nameof(point3D)}: {nameof(point3D.X)}: {point3D.X}, {nameof(point3D.Y)}: {point3D.Y}, {nameof(point3D.Z)}: {point3D.Z}");

         var (pointX, pointY, pointZ) = point3D;

         Console.WriteLine("Deconstructed struct:");
         Console.WriteLine($"X: {pointX}");
         Console.WriteLine($"Y: {pointY}");
         Console.WriteLine($"Z: {pointZ}");


         PrintBrake();

         Console.WriteLine("Example for class with deconstruct method:");
         var user = new User { Name = "John", Surname = "Smith", Email = "john.smith@gmail.com" };
         Console.WriteLine($"Created class: {nameof(user)}, {nameof(user.Name)}: {user.Name}, {nameof(user.Surname)}: {user.Surname}, {nameof(user.Email)}: {user.Email}");

         var (userName, userSurname, userEmail) = user;
         Console.WriteLine("Deconstructed class:");
         Console.WriteLine($"Name: {userName}");
         Console.WriteLine($"Surname: {userSurname}");
         Console.WriteLine($"Email: {userEmail}");
      }
   }
}

namespace AnimalShelter
{
   internal class Animal
   {
      public int AnimalId { get; set; }

      public string Name { get; set; } = string.Empty;

      public int Age { get; set; }

      public AnimalSpecies Specie { get; set; }

      public override string ToString()
      {
         return $"Animal id: {AnimalId}, Name: {Name}, Age: {Age}, Specie: {Specie}";
      }
   }

   internal enum AnimalSpecies
   {
      Dog = 1,
      Cat = 2,
      Bird = 3,
      Rabbit = 4,
      Other = 5
   }
}

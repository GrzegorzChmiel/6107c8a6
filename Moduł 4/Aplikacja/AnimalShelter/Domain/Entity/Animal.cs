using Domain.Common;

namespace Domain.Entity
{
   public class Animal : BaseEntity
   {
      public string Name { get; set; } = string.Empty;

      public int Age { get; set; }

      public AnimalSpecies Specie { get; set; }

      public override string ToString()
      {
         return $"Animal id: {Id}, Name: {Name}, Age: {Age}, Specie: {Specie}";
      }
   }

   public enum AnimalSpecies
   {
      Dog = 1,
      Cat = 2,
      Bird = 3,
      Rabbit = 4,
      Other = 5
   }
}

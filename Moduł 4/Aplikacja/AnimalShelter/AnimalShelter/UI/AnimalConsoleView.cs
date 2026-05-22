using Application.Interfaces;
using Domain.Entity;

namespace AnimalShelter.UI
{
   internal class AnimalConsoleView(IAnimalService animalService)
   {
      private readonly IAnimalService _animalService = animalService;

      public void AddNewAnimal()
      {
         Console.WriteLine("You are creating animal data now:");

         var name = ReadAnimalName();
         Console.WriteLine();

         var age = ReadAnimalAge();
         Console.WriteLine();

         var specie = ReadAnimalSpecie();
         Console.WriteLine();

         var id = _animalService.AddAnimal(name, age, specie);
         Console.WriteLine($"Animal added with id: {id}");
         Console.WriteLine();
      }

      public void ListAnimals()
      {
         Console.WriteLine("You are listing animal data now:");

         var animals = _animalService.GetAllAnimalsSorted();
         foreach (var animal in animals)
         {
            Console.WriteLine(animal);
         }

         Console.WriteLine();
      }

      public void ViewAnimalById()
      {
         Console.WriteLine("Now you see choosen animal data.");
         Console.WriteLine("Please select id of animal, you need to see:");

         var animal = SelectAnimal();
         Console.WriteLine(animal);
         Console.WriteLine();
      }

      public void AdoptAnimal()
      {
         Console.WriteLine("Now you place animal for adoption.");
         Console.WriteLine("Please select id of animal, you need place for adoption:");

         var animal = SelectAnimal();

         _animalService.AdoptAnimal(animal.Id);
         Console.WriteLine("Animal placed for adoption:");
         Console.WriteLine(animal);
         Console.WriteLine();
      }

      private Animal SelectAnimal()
      {
         Animal? animal = null;
         do
         {
            var idString = Console.ReadLine();
            if (!int.TryParse(idString, out var id) || id <= 0)
            {
               Console.WriteLine();
               Console.WriteLine("Incorrect animal's id. Please try again.");
               Console.WriteLine();
               continue;
            }

            animal = _animalService.GetAnimalById(id);
            if (animal is null)
            {
               Console.WriteLine();
               Console.WriteLine($"There is no animal with this id: {id}. Please try again.");
               Console.WriteLine();
            }
         } while (animal is null);

         return animal;
      }

      private static string ReadAnimalName()
      {
         Console.WriteLine("Please select the animal's name:");

         string? name;
         do
         {
            name = Console.ReadLine();
            if (string.IsNullOrWhiteSpace(name))
            {
               Console.WriteLine();
               Console.WriteLine("Incorrect animal's name. Please try again.");
               Console.WriteLine();
            }
         } while (string.IsNullOrWhiteSpace(name));

         return name;
      }

      private static int ReadAnimalAge()
      {
         Console.WriteLine("Please select the animal's age:");

         int age;
         bool valid;
         do
         {
            var ageString = Console.ReadLine();
            valid = int.TryParse(ageString, out age) && age > 0;
            if (!valid)
            {
               Console.WriteLine();
               Console.WriteLine("Incorrect animal's age. Please try again.");
               Console.WriteLine();
            }
         } while (!valid);

         return age;
      }

      private static AnimalSpecies ReadAnimalSpecie()
      {
         Console.WriteLine("Please select the animal's specie:");

         var specieValues = Enum.GetValues<AnimalSpecies>();
         foreach (var s in specieValues)
         {
            Console.WriteLine($"{(int)s} - {s}.");
         }

         int specieId;
         bool valid;
         do
         {
            var input = Console.ReadLine();
            valid = int.TryParse(input, out specieId)
               && Enum.IsDefined(typeof(AnimalSpecies), specieId);

            if (!valid)
            {
               Console.WriteLine();
               Console.WriteLine("Incorrect selection. Please try again.");
               Console.WriteLine();
            }
         } while (!valid);

         return (AnimalSpecies)specieId;
      }
   }
}

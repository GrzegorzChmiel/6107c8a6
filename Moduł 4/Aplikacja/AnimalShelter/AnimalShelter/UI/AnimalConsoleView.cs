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
         Console.WriteLine("Now you see chosen animal data.");
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

      public void ExportAnimalById()
      {
         Console.WriteLine("Now you export chosen animal data to file.");
         Console.WriteLine("Please select id of animal, you need to export:");
       
         var animal = SelectAnimal();
         var fileName = PrepareFileName(animal);
         var result = _animalService.SaveAnimalDataToFile(animal.Id, fileName);
         if(result)
         {
            Console.WriteLine($"Animal data exported to file: {fileName} successfully.");
            Console.WriteLine("Data exported to file:");
            Console.WriteLine(animal);
         }
         else
         {
            Console.WriteLine("Animal data export failed. Please try again.");
         }
         Console.WriteLine();
      }

      public void ExportAllAnimals()
      {
         Console.WriteLine("Now you export all animals data to file.");
         
         var fileName = PrepareFileName();
         var result = _animalService.SaveAllAnimalsDataToFile(fileName);
         if (result)
         {
            Console.WriteLine($"All animals data exported to file: {fileName} successfully.");
            Console.WriteLine($"Number of animals data exported to file: {_animalService.GetAllAnimalsSorted().Count}");
         }
         else
         {
            Console.WriteLine("All animals data export failed. Please try again.");
         }
         Console.WriteLine();
      }

      public void LoadAnimalDataFromFile()
      {
         Console.WriteLine("Now you import animal data from file.");
         Console.WriteLine("Please select file name to import animal data from:");

         string? fileName;
         do
         {
            fileName = Console.ReadLine();
            if (!string.IsNullOrWhiteSpace(fileName)) 
               continue;
            
            Console.WriteLine();
            Console.WriteLine("Incorrect file name. Please try again.");
            Console.WriteLine();
         } while (string.IsNullOrWhiteSpace(fileName));
         
         var result = _animalService.LoadAnimalDataFromFile(fileName);
         if (result)
         {
            Console.WriteLine($"Animal data imported from file: {fileName} successfully.");
            Console.WriteLine($"Number of all animals now: {_animalService.GetAllAnimalsSorted().Count}");
         }
         else
         {
            Console.WriteLine("Animal data import failed. Please try again.");
         }
         Console.WriteLine();
      }

      private static string PrepareFileName(Animal animal)
      { 
         var namePart = animal.Name.Replace(" ", "_");
         return $"{namePart}_{animal.Id}_{DateTime.Now:yyyy_MM_dd_HH_mm_ss}.json";
      }

      private static string PrepareFileName()
      {
         return $"AllAnimals_{DateTime.Now:yyyy_MM_dd_HH_mm_ss}.json";
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
         while(!int.TryParse(Console.ReadLine(), out age) || age <= 0)
         {
            Console.WriteLine();
            Console.WriteLine("Incorrect animal's age. Please try again.");
            Console.WriteLine();
         }

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
         while (true)
         {
            var input = Console.ReadLine();
            if (int.TryParse(input, out specieId) && Enum.IsDefined(typeof(AnimalSpecies), specieId))
            {
               break;
            }
            Console.WriteLine();
            Console.WriteLine("Incorrect selection. Please try again.");
            Console.WriteLine();
         }

         return (AnimalSpecies)specieId;
      }
   }
}

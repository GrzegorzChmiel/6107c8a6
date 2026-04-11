using Application.Interfaces;
using Application.Services;
using AnimalShelter.Data;
using AnimalShelter.UI;
using Domain.Interfaces;
using Infrastructure.Repositories;

namespace AnimalShelter
{
   internal class Program
   {
      private static void Main(string[] args)
      {
         // ── Composition Root (manual DI) ──
         IAnimalRepository repository = new InMemoryAnimalRepository();
         IAnimalService animalService = new AnimalService(repository);
         var view = new AnimalConsoleView(animalService);

         DataSeeder.Seed(animalService);

         // ── UI Loop ──
         Console.WriteLine("Welcome to the \"Animal Shelter\" App");
         Console.WriteLine();

         var finishWork = false;
         do
         {
            Console.WriteLine("Please select action you want to do:");
            Console.WriteLine("1 - Entering animal data.");
            Console.WriteLine("2 - Viewing choosen animal data.");
            Console.WriteLine("3 - Adopting an animal.");
            Console.WriteLine("4 - List animal data.");
            Console.WriteLine("5 - Exit application.");

            var actionIdString = Console.ReadLine();
            if (!int.TryParse(actionIdString, out var actionId))
            {
               actionId = 0;
            }

            Console.WriteLine();

            switch (actionId)
            {
               case 1:
                  view.AddNewAnimal();
                  break;
               case 2:
                  view.ViewAnimalById();
                  break;
               case 3:
                  view.AdoptAnimal();
                  break;
               case 4:
                  view.ListAnimals();
                  break;
               case 5:
                  finishWork = true;
                  break;
               default:
                  Console.WriteLine("Incorrect selection. Please try again.");
                  Console.WriteLine();
                  break;
            }

         } while (!finishWork);

         Console.Read();
      }
   }
}

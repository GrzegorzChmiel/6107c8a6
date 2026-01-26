using App.Managers;
using Domain.Entity;

namespace AnimalShelter
{
   internal class Program
   {
      private static void Main(string[] args)
      {
         ItemManager manager = new ();
         manager.InitializeApp();

         Console.WriteLine("Welcome to the \"Animal Shelter\" App");
         Console.WriteLine();

         var finishWork = false;
         do
         {
            Console.WriteLine("Please select action you want to do:");

            var mainMenuItems = manager.GetMenuItemsByCategory(MenuItemCategory.MainMenu);
            foreach (var menuItem in mainMenuItems)
            {
               Console.WriteLine(menuItem);
            }

            var actionIdString = Console.ReadLine();
            if (!int.TryParse(actionIdString, out var actionId))
            {
               actionId = 0;
            }

            Console.WriteLine();
            
            switch (actionId)
            {
               case 1:
                  manager.AddNewAnimal();
                  Console.WriteLine();
                  break;
               case 2:
                  manager.ViewChoosenAnimalData();
                  Console.WriteLine();
                  break;
               case 3:
                  manager.AnimalAdoption();
                  Console.WriteLine();
                  break;
               case 4:
                  manager.ListAnimalsData();
                  Console.WriteLine();
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

using App.Concrete;
using Domain.Entity;

namespace App.Managers
{
   public class ItemManager
   {
      private readonly MenuItemService _menuItemService = new MenuItemService();
      private readonly AnimalService _animalService = new AnimalService();

      #region Animal
      public void ListAnimalsData()
      {
         Console.WriteLine("You are listing animal data now:");

         var sortedList = _animalService.GetAllItems().OrderBy(a => a.Specie).ThenBy(a => a.Id).ToList();
         foreach (var animal in sortedList)
         {
            Console.WriteLine(animal);
         }
      }

      public void AddNewAnimal()
      {
         Console.WriteLine("You are creating animal data now:");

         var name = GetAnimalNameView();
         Console.WriteLine();

         var age = GetAnimalAgeView();
         Console.WriteLine();

         var specie = GetAnimalSpecieView();
         Console.WriteLine();

         AddAnimal(name, age, specie);
      }

      public void AddAnimal(string name, int age, AnimalSpecies specie)
      {
         var id = _animalService.GetIdForNewAnimal();
         var newAnimal = new Animal { Id = id, Name = name, Age = age, Specie = specie };
         _animalService.AddItem(newAnimal);
      }

      public void AnimalAdoption()
      {
         Console.WriteLine("Now you place animal for adoption.");
         Console.WriteLine("Please select id of animal, you need place for adoption:");

         var animal = SelectAnimal();

         Console.WriteLine("Animal placed for adoption:");
         Console.WriteLine(animal);

         _animalService.GetAllItems().Remove(animal);
      }

      public void ViewChoosenAnimalData()
      {
         Console.WriteLine("Now you see choosen animal data.");
         Console.WriteLine("Please select id of animal, you need to see:");

         var animal = SelectAnimal();

         Console.WriteLine(animal);
      }

      private static string GetAnimalNameView()
      {
         Console.WriteLine("Please select the animal's name:");

         string? nameString;
         var correctName = false;
         do
         {
            nameString = Console.ReadLine();
            correctName = !string.IsNullOrWhiteSpace(nameString);
            if (correctName)
               continue;

            Console.WriteLine();
            Console.WriteLine("Incorrect animal's name. Please try again.");
            Console.WriteLine();
         } while (!correctName);

         return nameString!;
      }

      private static int GetAnimalAgeView()
      {
         Console.WriteLine("Please select the animal's age:");

         int age;
         var correctAge = false;
         do
         {
            var ageString = Console.ReadLine();
            correctAge = int.TryParse(ageString, out age) && age > 0;
            if (correctAge)
               continue;

            Console.WriteLine();
            Console.WriteLine("Incorrect animal's age. Please try again.");
            Console.WriteLine();
         } while (!correctAge);

         return age!;
      }

      private AnimalSpecies GetAnimalSpecieView()
      {
         Console.WriteLine("Please select the animal's specie:");

         var animalSpecieId = 0;
         var correctChoice = false;
         do
         {
            var animalSpecieMenuItems = _menuItemService.GetMenuItemsByCategory(MenuItemCategory.AnimalSpecieMenu);
            foreach (var menuItem in animalSpecieMenuItems)
            {
               Console.WriteLine(menuItem);
            }

            var choiceString = Console.ReadLine();
            if (!int.TryParse(choiceString, out animalSpecieId) || !_menuItemService.IsMenuItemIdValid(animalSpecieId, MenuItemCategory.AnimalSpecieMenu))
            {
               animalSpecieId = 0;
               Console.WriteLine();
               Console.WriteLine("Incorrect selection. Please try again.");
               Console.WriteLine();
            }

            correctChoice = animalSpecieId != 0;
         } while (!correctChoice);

         var result = (AnimalSpecies)animalSpecieId;
         return result;
      }

      private Animal SelectAnimal()
      {
         Animal? animal = null;
         var correctId = false;
         do
         {
            var idString = Console.ReadLine();
            correctId = int.TryParse(idString, out var id) && id > 0;
            if (!correctId)
            {
               Console.WriteLine();
               Console.WriteLine("Incorrect animal's id. Please try again.");
               Console.WriteLine();
            }

            var listSearched = false;
            if (correctId)
            {
               listSearched = true;
               foreach (var animalElement in _animalService.GetAllItems())
               {
                  if (animalElement.Id != id)
                     continue;

                  animal = animalElement;
                  break;
               }
            }

            correctId = animal != null;
            if (correctId || !listSearched)
               continue;

            Console.WriteLine();
            Console.WriteLine($"There is no animal with this id: {id}. Please try again.");
            Console.WriteLine();

         } while (!correctId);

         return animal!;
      }
      #endregion

      #region Menu
      public void AddMenuItem(int id, string desc, MenuItemCategory category)
      {
         var menuItem = new MenuItem
         {
            Id = id,
            MenuItemDesc = desc,
            Category = category

         };
         _menuItemService.AddItem(menuItem);
      }

      public List<MenuItem> GetMenuItemsByCategory(MenuItemCategory category)
      {
         return _menuItemService.GetAllItems().Where(menuItem => menuItem.Category == category).ToList();
      }
      #endregion

      #region Initialization
      public void InitializeApp()
      {
         Initializator initializator = new(this);
         initializator.Initialize();
      }
      #endregion
   }
}

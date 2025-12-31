namespace AnimalShelter
{
   internal class AnimalService
   {
      private readonly List<Animal> _animals = [];

      public void AddNewAnimal(MenuItemService menuItemService)
      {
         Console.WriteLine("You are creating animal data now:");

         var name = GetAnimalNameView();
         Console.WriteLine();


         var age = GetAnimalAgeView();
         Console.WriteLine();

         var specie = GetAnimalSpecieView(menuItemService);
         Console.WriteLine();

         AddAnimal(name, age, specie);
      }

      public void AddAnimal(string name, int age, AnimalSpecies specie)
      {

         var id = GetIdForNewAnimal();
         var newAnimal = new Animal { AnimalId = id, Name = name, Age = age, Specie = specie };
         _animals.Add(newAnimal);
      }

      public void ViewChoosenAnimalData()
      {
         Console.WriteLine("Now you see choosen animal data.");
         Console.WriteLine("Please select id of animal, you need to see:");

         var animal = GetAnimalById();

         Console.WriteLine(animal);
      }

      public void AnimalAdoption()
      {
         Console.WriteLine("Now you place animal for adoption.");
         Console.WriteLine("Please select id of animal, you need place for adoption:");

         var animal = GetAnimalById();

         Console.WriteLine("Animal placed for adoption:");
         Console.WriteLine(animal);

         _animals.Remove(animal);
      }

      public void ListAnimalsData()
      {
         Console.WriteLine("You are listing animal data now:");

         var sortedList = _animals.OrderBy(a => a.Specie).ThenBy(a => a.AnimalId).ToList();
         foreach (var animal in sortedList)
         {
            Console.WriteLine(animal);
         }
      }

      private int GetIdForNewAnimal()
      {
         var result = 1;

         if (_animals.Count == 0)
            return result;

         foreach (var animal in _animals)
         {
            if (animal.AnimalId > result)
               result = animal.AnimalId;
         }

         result += 1;

         return result;
      }

      private string GetAnimalNameView()
      {
         Console.WriteLine("Please select the animal's name:");

         string? nameString;
         var correctName = false;
         do
         {
            nameString = Console.ReadLine();
            correctName = !string.IsNullOrWhiteSpace(nameString);
            if (!correctName)
            {
               Console.WriteLine();
               Console.WriteLine("Incorrect animal's name. Please try again.");
               Console.WriteLine();
            }
         } while (!correctName);

         return nameString!;
      }

      private int GetAnimalAgeView()
      {
         Console.WriteLine("Please select the animal's age:");

         int age;
         var correctAge = false;
         do
         {
            var ageString = Console.ReadLine();
            correctAge = int.TryParse(ageString, out age) && age > 0;
            if (!correctAge)
            {
               Console.WriteLine();
               Console.WriteLine("Incorrect animal's age. Please try again.");
               Console.WriteLine();
            }
         } while (!correctAge);

         return age!;
      }

      private static AnimalSpecies GetAnimalSpecieView(MenuItemService menuItemService)
      {
         Console.WriteLine("Please select the animal's specie:");

         var animalSpecieId = 0;
         var correctChoice = false;
         do
         {
            var animalSpecieMenuItems = menuItemService.GetMenuItemsByCategory(MenuItemCategory.AnimalSpecieMenu);
            foreach (var menuItem in animalSpecieMenuItems)
            {
               Console.WriteLine(menuItem);
            }

            var choiceString = Console.ReadLine();
            if (!int.TryParse(choiceString, out animalSpecieId) || !menuItemService.IsMenuItemIdValid(animalSpecieId, MenuItemCategory.AnimalSpecieMenu))
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

      private Animal GetAnimalById()
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
               foreach (var animalElement in _animals)
               {
                  if (animalElement.AnimalId == id)
                  {
                     animal = animalElement;
                     break;
                  }
               }
            }
            correctId = animal != null;
            if (!correctId && listSearched)
            {
               Console.WriteLine();
               Console.WriteLine($"There is no animal with this id: {id}. Please try again.");
               Console.WriteLine();
            }

         } while (!correctId);

         return animal!;
      }
   }
}

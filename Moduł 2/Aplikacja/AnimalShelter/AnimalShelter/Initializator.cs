namespace AnimalShelter
{
   internal class Initializator
   {
      public static void Initialize(MenuItemService menuItemService, AnimalService animalService)
      {
         InitMenu(menuItemService);

         InitData(animalService);
      }

      private static void InitData(AnimalService animalService)
      {
         //Init data - dogs.
         animalService.AddAnimal("Max", 10, AnimalSpecies.Dog);
         animalService.AddAnimal("Charlie", 4, AnimalSpecies.Dog);
         animalService.AddAnimal("Buddy", 5, AnimalSpecies.Dog);
         animalService.AddAnimal("Rocky", 2, AnimalSpecies.Dog);
         animalService.AddAnimal("Cooper", 6, AnimalSpecies.Dog);
         animalService.AddAnimal("Duke", 4, AnimalSpecies.Dog);
         animalService.AddAnimal("Milo", 6, AnimalSpecies.Dog);
         animalService.AddAnimal("Toby", 2, AnimalSpecies.Dog);
         animalService.AddAnimal("Jack", 1, AnimalSpecies.Dog);
         animalService.AddAnimal("Oscar", 8, AnimalSpecies.Dog);

         //Init data - cats.
         animalService.AddAnimal("Luna", 8, AnimalSpecies.Cat);
         animalService.AddAnimal("Oliver", 5, AnimalSpecies.Cat);
         animalService.AddAnimal("Bella", 4, AnimalSpecies.Cat);
         animalService.AddAnimal("Milo", 2, AnimalSpecies.Cat);
         animalService.AddAnimal("Daisy", 4, AnimalSpecies.Cat);
         animalService.AddAnimal("Leo", 9, AnimalSpecies.Cat);
         animalService.AddAnimal("Willow", 3, AnimalSpecies.Cat);
         animalService.AddAnimal("Jasper", 9, AnimalSpecies.Cat);
         animalService.AddAnimal("Cleo", 2, AnimalSpecies.Cat);
         animalService.AddAnimal("Felix", 3, AnimalSpecies.Cat);

         //Init data - birds.
         animalService.AddAnimal("Kiwi", 7, AnimalSpecies.Bird);
         animalService.AddAnimal("Sunny", 2, AnimalSpecies.Bird);
         animalService.AddAnimal("Sky", 8, AnimalSpecies.Bird);
         animalService.AddAnimal("Pepper", 4, AnimalSpecies.Bird);
         animalService.AddAnimal("Coco", 1, AnimalSpecies.Bird);
         animalService.AddAnimal("Blue", 3, AnimalSpecies.Bird);
         animalService.AddAnimal("Mango", 4, AnimalSpecies.Bird);
         animalService.AddAnimal("Rio", 2, AnimalSpecies.Bird);
         animalService.AddAnimal("Echo", 4, AnimalSpecies.Bird);
         animalService.AddAnimal("Breeze", 7, AnimalSpecies.Bird);

         //Init data - rabbits.
         animalService.AddAnimal("Thumper", 4, AnimalSpecies.Rabbit);
         animalService.AddAnimal("Snowball", 5, AnimalSpecies.Rabbit);
         animalService.AddAnimal("Clover", 2, AnimalSpecies.Rabbit);
         animalService.AddAnimal("Hazel", 7, AnimalSpecies.Rabbit);
         animalService.AddAnimal("Bunny", 3, AnimalSpecies.Rabbit);
         animalService.AddAnimal("Willow", 9, AnimalSpecies.Rabbit);
         animalService.AddAnimal("Poppy", 5, AnimalSpecies.Rabbit);
         animalService.AddAnimal("Nibbles", 1, AnimalSpecies.Rabbit);
         animalService.AddAnimal("Marshmallow", 2, AnimalSpecies.Rabbit);
         animalService.AddAnimal("Honey", 6, AnimalSpecies.Rabbit);

         //Init data - others.
         animalService.AddAnimal("Shadow", 7, AnimalSpecies.Other);
         animalService.AddAnimal("Peanut", 4, AnimalSpecies.Other);
         animalService.AddAnimal("Lucky", 5, AnimalSpecies.Other);
         animalService.AddAnimal("Scout", 2, AnimalSpecies.Other);
         animalService.AddAnimal("Ziggy", 7, AnimalSpecies.Other);
         animalService.AddAnimal("Maple", 3, AnimalSpecies.Other);
         animalService.AddAnimal("Storm", 9, AnimalSpecies.Other);
         animalService.AddAnimal("Pepper", 10, AnimalSpecies.Other);
         animalService.AddAnimal("River", 7, AnimalSpecies.Other);
         animalService.AddAnimal("Sunny", 5, AnimalSpecies.Other);
      }

      private static void InitMenu(MenuItemService menuItemService)
      {
         //Main menu options.
         menuItemService.AddMenuItem(1, "Entering animal data.", MenuItemCategory.MainMenu);
         menuItemService.AddMenuItem(2, "Viewing choosen animal data.", MenuItemCategory.MainMenu);
         menuItemService.AddMenuItem(3, "Adopting an animal.", MenuItemCategory.MainMenu);
         menuItemService.AddMenuItem(4, "List animal data.", MenuItemCategory.MainMenu);
         menuItemService.AddMenuItem(5, "Exit application.", MenuItemCategory.MainMenu);

         //Animal's specie menu options.
         menuItemService.AddMenuItem(1, "Dog.", MenuItemCategory.AnimalSpecieMenu);
         menuItemService.AddMenuItem(2, "Cat.", MenuItemCategory.AnimalSpecieMenu);
         menuItemService.AddMenuItem(3, "Bird.", MenuItemCategory.AnimalSpecieMenu);
         menuItemService.AddMenuItem(4, "Rabbit.", MenuItemCategory.AnimalSpecieMenu);
         menuItemService.AddMenuItem(5, "Other.", MenuItemCategory.AnimalSpecieMenu);
      }
   }
}

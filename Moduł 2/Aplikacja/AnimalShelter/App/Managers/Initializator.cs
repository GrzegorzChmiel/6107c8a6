using Domain.Entity;

namespace App.Managers
{
   internal class Initializator(ItemManager itemManager)
   {
      private readonly ItemManager _itemManager = itemManager;

      public void Initialize()
      {
         InitMenu();

         InitData();
      }

      private void InitData()
      {
         //Init data - dogs.
         _itemManager.AddAnimal("Max", 10, AnimalSpecies.Dog);
         _itemManager.AddAnimal("Charlie", 4, AnimalSpecies.Dog);
         _itemManager.AddAnimal("Buddy", 5, AnimalSpecies.Dog);
         _itemManager.AddAnimal("Rocky", 2, AnimalSpecies.Dog);
         _itemManager.AddAnimal("Cooper", 6, AnimalSpecies.Dog);
         _itemManager.AddAnimal("Duke", 4, AnimalSpecies.Dog);
         _itemManager.AddAnimal("Milo", 6, AnimalSpecies.Dog);
         _itemManager.AddAnimal("Toby", 2, AnimalSpecies.Dog);
         _itemManager.AddAnimal("Jack", 1, AnimalSpecies.Dog);
         _itemManager.AddAnimal("Oscar", 8, AnimalSpecies.Dog);

         //Init data - cats.
         _itemManager.AddAnimal("Luna", 8, AnimalSpecies.Cat);
         _itemManager.AddAnimal("Oliver", 5, AnimalSpecies.Cat);
         _itemManager.AddAnimal("Bella", 4, AnimalSpecies.Cat);
         _itemManager.AddAnimal("Milo", 2, AnimalSpecies.Cat);
         _itemManager.AddAnimal("Daisy", 4, AnimalSpecies.Cat);
         _itemManager.AddAnimal("Leo", 9, AnimalSpecies.Cat);
         _itemManager.AddAnimal("Willow", 3, AnimalSpecies.Cat);
         _itemManager.AddAnimal("Jasper", 9, AnimalSpecies.Cat);
         _itemManager.AddAnimal("Cleo", 2, AnimalSpecies.Cat);
         _itemManager.AddAnimal("Felix", 3, AnimalSpecies.Cat);

         //Init data - birds.
         _itemManager.AddAnimal("Kiwi", 7, AnimalSpecies.Bird);
         _itemManager.AddAnimal("Sunny", 2, AnimalSpecies.Bird);
         _itemManager.AddAnimal("Sky", 8, AnimalSpecies.Bird);
         _itemManager.AddAnimal("Pepper", 4, AnimalSpecies.Bird);
         _itemManager.AddAnimal("Coco", 1, AnimalSpecies.Bird);
         _itemManager.AddAnimal("Blue", 3, AnimalSpecies.Bird);
         _itemManager.AddAnimal("Mango", 4, AnimalSpecies.Bird);
         _itemManager.AddAnimal("Rio", 2, AnimalSpecies.Bird);
         _itemManager.AddAnimal("Echo", 4, AnimalSpecies.Bird);
         _itemManager.AddAnimal("Breeze", 7, AnimalSpecies.Bird);

         //Init data - rabbits.
         _itemManager.AddAnimal("Thumper", 4, AnimalSpecies.Rabbit);
         _itemManager.AddAnimal("Snowball", 5, AnimalSpecies.Rabbit);
         _itemManager.AddAnimal("Clover", 2, AnimalSpecies.Rabbit);
         _itemManager.AddAnimal("Hazel", 7, AnimalSpecies.Rabbit);
         _itemManager.AddAnimal("Bunny", 3, AnimalSpecies.Rabbit);
         _itemManager.AddAnimal("Willow", 9, AnimalSpecies.Rabbit);
         _itemManager.AddAnimal("Poppy", 5, AnimalSpecies.Rabbit);
         _itemManager.AddAnimal("Nibbles", 1, AnimalSpecies.Rabbit);
         _itemManager.AddAnimal("Marshmallow", 2, AnimalSpecies.Rabbit);
         _itemManager.AddAnimal("Honey", 6, AnimalSpecies.Rabbit);

         //Init data - others.
         _itemManager.AddAnimal("Shadow", 7, AnimalSpecies.Other);
         _itemManager.AddAnimal("Peanut", 4, AnimalSpecies.Other);
         _itemManager.AddAnimal("Lucky", 5, AnimalSpecies.Other);
         _itemManager.AddAnimal("Scout", 2, AnimalSpecies.Other);
         _itemManager.AddAnimal("Ziggy", 7, AnimalSpecies.Other);
         _itemManager.AddAnimal("Maple", 3, AnimalSpecies.Other);
         _itemManager.AddAnimal("Storm", 9, AnimalSpecies.Other);
         _itemManager.AddAnimal("Pepper", 10, AnimalSpecies.Other);
         _itemManager.AddAnimal("River", 7, AnimalSpecies.Other);
         _itemManager.AddAnimal("Sunny", 5, AnimalSpecies.Other);
      }

      private void InitMenu()
      {
         //Main menu options.
         _itemManager.AddMenuItem(1, "Entering animal data.", MenuItemCategory.MainMenu);
         _itemManager.AddMenuItem(2, "Viewing choosen animal data.", MenuItemCategory.MainMenu);
         _itemManager.AddMenuItem(3, "Adopting an animal.", MenuItemCategory.MainMenu);
         _itemManager.AddMenuItem(4, "List animal data.", MenuItemCategory.MainMenu);
         _itemManager.AddMenuItem(5, "Exit application.", MenuItemCategory.MainMenu);

         //Animal's specie menu options.
         _itemManager.AddMenuItem(1, "Dog.", MenuItemCategory.AnimalSpecieMenu);
         _itemManager.AddMenuItem(2, "Cat.", MenuItemCategory.AnimalSpecieMenu);
         _itemManager.AddMenuItem(3, "Bird.", MenuItemCategory.AnimalSpecieMenu);
         _itemManager.AddMenuItem(4, "Rabbit.", MenuItemCategory.AnimalSpecieMenu);
         _itemManager.AddMenuItem(5, "Other.", MenuItemCategory.AnimalSpecieMenu);
      }
   }
}

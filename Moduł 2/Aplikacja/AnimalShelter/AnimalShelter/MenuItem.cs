namespace AnimalShelter
{
   internal class MenuItem
   {
      public int MenuItemId { get; set; }

      public string MenuItemDesc { get; set; } = string.Empty;

      public MenuItemCategory Category { get; set; }

      public override string ToString()
      {
         return $"{MenuItemId} - {MenuItemDesc}";
      }
   }

   internal enum MenuItemCategory
   {
      MainMenu = 1,
      AnimalSpecieMenu = 2
   }
}

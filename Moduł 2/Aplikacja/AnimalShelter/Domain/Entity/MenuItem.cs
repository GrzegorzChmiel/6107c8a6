using Domain.Common;

namespace Domain.Entity
{
   public class MenuItem : BaseEntity
   {
      public string MenuItemDesc { get; set; } = string.Empty;

      public MenuItemCategory Category { get; set; }

      public override string ToString()
      {
         return $"{Id} - {MenuItemDesc}";
      }
   }

   public enum MenuItemCategory
   {
      MainMenu = 1,
      AnimalSpecieMenu = 2
   }
}

namespace AnimalShelter
{
   internal class MenuItemService
   {
      private readonly List<MenuItem> _menuItems = [];

      public void AddMenuItem(int id, string desc, MenuItemCategory category)
      {
         var menuItem = new MenuItem
         {
            MenuItemId = id,
            MenuItemDesc = desc,
            Category = category

         };
         _menuItems.Add(menuItem);
      }

      public List<MenuItem> GetMenuItemsByCategory(MenuItemCategory category)
      {
         var result = new List<MenuItem>();
         
         foreach (var menuItem in _menuItems)
         {
            if(menuItem.Category == category)
               result.Add(menuItem);
         }

         return result;
      }

      public bool IsMenuItemIdValid(int menuItemId, MenuItemCategory category)
      {
         var result = false;

         var menuItems = GetMenuItemsByCategory(category);
         foreach (var menuItem in menuItems)
         {
            if(menuItem.MenuItemId == menuItemId)
            {
               result = true;
               break;
            }
         }

         return result;
      }
   }
}

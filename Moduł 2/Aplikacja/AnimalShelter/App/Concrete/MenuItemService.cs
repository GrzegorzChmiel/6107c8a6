using App.Common;
using Domain.Entity;

namespace App.Concrete
{
    public class MenuItemService : BaseService<MenuItem>
    {
       public List<MenuItem> GetMenuItemsByCategory(MenuItemCategory category)
       {
          return GetAllItems().Where(menuItem => menuItem.Category == category).ToList();
       }

       public bool IsMenuItemIdValid(int menuItemId, MenuItemCategory category)
       {
          var menuItems = GetMenuItemsByCategory(category);

          return menuItems.Any(menuItem => menuItem.Id == menuItemId);
       }
   }
}

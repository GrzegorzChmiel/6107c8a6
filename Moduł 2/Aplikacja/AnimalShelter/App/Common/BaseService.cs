using App.Abstract;
using Domain.Common;

namespace App.Common
{
    public class BaseService<T> : IService<T> where T : BaseEntity
    {
       private readonly IList<T> _list = new List<T>();

       public IList<T> GetAllItems()
       {
          return _list;
       }

       public int AddItem(T item)
       {
          _list.Add(item);
          return item.Id;
       }

       public int UpdateItem(T item)
       {
          var itemToUpdate = _list.First(a => a.Id == item.Id);
          itemToUpdate = item;
          return itemToUpdate.Id;
       }

       public void RemoveItem(T item)
       {
          var itemToRemove = _list.First(a => a.Id == item.Id);
          _list.Remove(itemToRemove);
       }
    }
}

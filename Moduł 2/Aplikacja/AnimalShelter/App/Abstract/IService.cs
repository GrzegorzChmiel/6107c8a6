namespace App.Abstract
{
   public interface IService<T>
   {
      IList<T> GetAllItems();

      int AddItem(T item);

      int UpdateItem(T item);

      void RemoveItem(T item);
   }
}

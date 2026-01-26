using App.Common;
using Domain.Entity;

namespace App.Concrete
{
    public class AnimalService : BaseService<Animal>
    {
       public int GetIdForNewAnimal()
       {
          var result = 1;

          var animals = GetAllItems();
          if (animals.Count == 0)
             return result;

          result = animals.Select(animal => animal.Id).Prepend(result).Max();

          result += 1;

          return result;
       }
   }
}

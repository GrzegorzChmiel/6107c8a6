using Domain.Entity;

namespace Domain.Interfaces
{
   public interface IAnimalRepository
   {
      IReadOnlyList<Animal> GetAll();

      Animal? GetById(int id);

      int Add(Animal animal);

      void Remove(int id);

      int GetNextId();
   }
}

using Domain.Entity;
using Domain.Interfaces;

namespace Infrastructure.Repositories
{
   public class InMemoryAnimalRepository : IAnimalRepository
   {
      private readonly List<Animal> _animals = [];

      public IReadOnlyList<Animal> GetAll()
      {
         return _animals.AsReadOnly();
      }

      public Animal? GetById(int id)
      {
         return _animals.FirstOrDefault(a => a.Id == id);
      }

      public int Add(Animal animal)
      {
         _animals.Add(animal);
         return animal.Id;
      }

      public void Remove(int id)
      {
         var animal = _animals.FirstOrDefault(a => a.Id == id)
            ?? throw new InvalidOperationException($"Animal with id {id} not found.");

         _animals.Remove(animal);
      }

      public int GetNextId()
      {
         return _animals.Count == 0 ? 1 : _animals.Max(a => a.Id) + 1;
      }
   }
}

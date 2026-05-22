using Application.Interfaces;
using Domain.Entity;
using Domain.Interfaces;

namespace Application.Services
{
   public class AnimalService(IAnimalRepository animalRepository) : IAnimalService
   {
      private readonly IAnimalRepository _animalRepository = animalRepository;

      public IReadOnlyList<Animal> GetAllAnimals()
      {
         return _animalRepository.GetAll();
      }

      public IReadOnlyList<Animal> GetAllAnimalsSorted()
      {
         return _animalRepository.GetAll()
            .OrderBy(a => a.Specie)
            .ThenBy(a => a.Id)
            .ToList();
      }

      public Animal? GetAnimalById(int id)
      {
         return _animalRepository.GetById(id);
      }

      public int AddAnimal(string name, int age, AnimalSpecies specie)
      {
         var id = _animalRepository.GetNextId();
         var animal = new Animal
         {
            Id = id,
            Name = name,
            Age = age,
            Specie = specie,
            CreatedDateTime = DateTime.UtcNow,
            ModifiedDateTime = DateTime.UtcNow,
            CreatedById = 1,
            ModifiedById = 1
         };

         return _animalRepository.Add(animal);
      }

      public void AdoptAnimal(int id)
      {
         _animalRepository.Remove(id);
      }
   }
}

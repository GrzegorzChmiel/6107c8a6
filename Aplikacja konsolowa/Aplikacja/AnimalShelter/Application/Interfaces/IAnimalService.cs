using Domain.Entity;

namespace Application.Interfaces
{
   public interface IAnimalService
   {
      IReadOnlyList<Animal> GetAllAnimals();

      IReadOnlyList<Animal> GetAllAnimalsSorted();

      Animal? GetAnimalById(int id);

      int AddAnimal(string name, int age, AnimalSpecies specie);

      void AdoptAnimal(int id);

      bool SaveAnimalDataToFile(int id, string filePath);

      bool SaveAllAnimalsDataToFile(string filePath);

      bool LoadAnimalDataFromFile(string filePath);
   }
}

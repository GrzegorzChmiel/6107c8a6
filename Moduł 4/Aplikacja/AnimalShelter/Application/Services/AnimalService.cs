using Application.Interfaces;
using Domain.Entity;
using Domain.Interfaces;

namespace Application.Services
{
   public class AnimalService(IAnimalRepository animalRepository, ISerializerService serializer, IFileService fileService) : IAnimalService
   {
      private readonly IAnimalRepository _animalRepository = animalRepository;
      private readonly ISerializerService _serializer = serializer;
      private readonly IFileService _fileService = fileService;

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

      public bool SaveAnimalDataToFile(int id, string filePath)
      {
         var animal = _animalRepository.GetById(id);
         if (animal is null || string.IsNullOrEmpty(filePath))
            return false;

         var serializedData = _serializer.Serialize(animal);

         return _fileService.SaveToFile(filePath, serializedData);
      }

      public bool SaveAllAnimalsDataToFile(string filePath)
      {
         if (string.IsNullOrEmpty(filePath))
            return false;

         var animals = _animalRepository.GetAll();
         var serializedData = _serializer.Serialize(animals);

         return _fileService.SaveToFile(filePath, serializedData);
      }

      public bool LoadAnimalDataFromFile(string filePath)
      {
         if (string.IsNullOrEmpty(filePath))
            return false;

         var data = _fileService.LoadFromFile(filePath);
         if (string.IsNullOrEmpty(data))
            return false;

         var animals = _serializer.Deserialize(data);
         if (animals.Count == 0)
            return false;

         foreach (var animal in animals)
         {
            _animalRepository.Add(animal);
         }

         return true;
      }
   }
}

using Domain.Entity;

namespace Application.Interfaces;

public interface ISerializerService 
{
   string Serialize(Animal animal);

   string Serialize(IReadOnlyList<Animal> animals);

   IList<Animal> Deserialize(string data);
}
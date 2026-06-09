using System.Text.Json;
using System.Text.Json.Serialization;
using Application.Interfaces;
using Domain.Entity;

namespace Application.Services
{
   public class SerializerService : ISerializerService
   {
      private readonly JsonSerializerOptions _serializerOptions = new()
      {
         WriteIndented = true,
         Converters =
         {
            new JsonStringEnumConverter()
         }
      };

      public IList<Animal> Deserialize(string data)
      {
         if (string.IsNullOrWhiteSpace(data))
         {
            return new List<Animal>();
         }

         try
         {
            var dataList = JsonSerializer.Deserialize<List<Animal>>(data, _serializerOptions);
            return dataList ?? [];
         }
         catch (JsonException)
         {
            return new List<Animal>();
         }
      }

      public string Serialize(Animal animal)
      {
         var list = new List<Animal> { animal };
         return JsonSerializer.Serialize(list, _serializerOptions);
      }

      public string Serialize(IReadOnlyList<Animal> animals)
      {
         return JsonSerializer.Serialize(animals, _serializerOptions);
      }
   }
}

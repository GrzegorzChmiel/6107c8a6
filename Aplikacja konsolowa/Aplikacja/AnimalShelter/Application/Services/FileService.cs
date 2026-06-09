using Application.Interfaces;

namespace Application.Services;

public class FileService : IFileService
{
   public string LoadFromFile(string filePath)
   {
      try
      {
         return File.ReadAllText(filePath);
      }
      catch (Exception)
      {
         return string.Empty;
      }
   }

   public bool SaveToFile(string filePath, string data)
   {
      try
      {
         File.WriteAllText(filePath, data);
      }
      catch (Exception)
      {
         return false;
      }
      return true;
   }
}
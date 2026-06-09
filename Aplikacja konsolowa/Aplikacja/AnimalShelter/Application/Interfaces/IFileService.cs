namespace Application.Interfaces;

public interface IFileService
{
   bool SaveToFile(string filePath, string data);

   string LoadFromFile(string filePath);
}
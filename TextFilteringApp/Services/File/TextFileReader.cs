using System.IO;
namespace TextFilteringApp.Services.File
{
    public class TextFileReader : IFileReader
    {
        public async Task<string> ReadAsStringAsync(string filePath)
        {
            return await System.IO.File.ReadAllTextAsync(filePath);
        }
    }
}

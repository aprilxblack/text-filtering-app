namespace TextFilteringApp.Services.File
{
    public interface IFileReader
    {
        Task<string> ReadAsStringAsync(string filePath);
    }
}

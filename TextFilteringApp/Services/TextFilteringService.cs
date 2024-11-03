using TextFilteringApp.Services;

namespace TextFilteringApp
{
    public class TextFilteringService
    {
        private readonly IFileReader _fileReader;

        public TextFilteringService(IFileReader fileReader)
        {
            _fileReader = fileReader;
        }
    }
}

using TextFilteringApp.Extensions;

namespace TextFilteringApp.Services.Filtering
{
    public class ExcludeShorterThan3CharsFilter : IFilter
    {
        public string[] Filter(string[] input)
        {
            return input.Where(input => input.StripPunctuation().Length >= 3).ToArray();
        }
    }
}

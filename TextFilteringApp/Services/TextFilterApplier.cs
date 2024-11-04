using System.Linq;
using System.Text.RegularExpressions;
using TextFilteringApp.Services.Filtering;

namespace TextFilteringApp.Services
{
    public class TextFilterApplier
    {
        private readonly IFilter _filter;

        public TextFilterApplier(IFilter filter)
        {
            _filter = filter;
        }

        public string Apply(string input)
        {
            var separated = SeparateTextIntoWords(input);
            var filtered = _filter.Filter(separated);
            return string.Join(" ", filtered);
        }

        public static string[] SeparateTextIntoWords(string input)
        {
            return Regex.Matches(input, @"\b\w+('\w+)?[^\w\s]*").Cast<Match>().Select(m => m.Value.Trim()).ToArray();
        }
    }
}

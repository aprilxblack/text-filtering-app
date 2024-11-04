using System.Linq;
using System.Text.RegularExpressions;
using TextFilteringApp.Services.Filtering;

namespace TextFilteringApp.Services
{
    public class TextFilterApplier
    {
        private readonly IList<IFilter> _filters;

        public TextFilterApplier(IList<IFilter> filters)
        {
            _filters = filters;
        }

        public string Apply(string input)
        {
            var separated = SeparateTextIntoWords(input);
            var filtered = _filters.Aggregate(separated, (current, filter) => filter.Filter(current));
            return string.Join(" ", filtered);
        }

        public static string[] SeparateTextIntoWords(string input)
        {
            return Regex.Matches(input, @"\b\w+('\w+)?[^\w\s]*").Cast<Match>().Select(m => m.Value.Trim()).ToArray();
        }
    }
}

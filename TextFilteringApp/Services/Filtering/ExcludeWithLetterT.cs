namespace TextFilteringApp.Services.Filtering
{
    public class ExcludeWithLetterT : IFilter
    {
        public string[] Filter(string[] input)
        {
            return input.Where(input => !input.Contains('t') && !input.Contains('T')).ToArray();
        }
    }
}

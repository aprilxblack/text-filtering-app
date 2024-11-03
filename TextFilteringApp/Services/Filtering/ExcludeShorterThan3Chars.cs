namespace TextFilteringApp.Services.Filtering
{
    public class ExcludeShorterThan3Chars : IFilter
    {
        public string[] Filter(string[] input)
        {
            return input.Where(input => input.Length >= 3).ToArray();
        }
    }
}

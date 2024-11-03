using TextFilteringApp.Extensions;

namespace TextFilteringApp.Services.Filtering
{
    public class ExcludeWithVowelInTheMiddleFilter : IFilter
    {
        private char[] vowels = ['a', 'e', 'i', 'o', 'u'];
        public string[] Filter(string[] input)
        {
            return input.Where(x => !HasVowelInTheMiddle(x.StripPunctuation())).ToArray();
        }

        private bool HasVowelInTheMiddle(string inputWord)
        {
            int middle = inputWord.Length / 2;

            if (inputWord.Length % 2 == 0)
            {
                return vowels.Contains(inputWord[middle - 1]) || vowels.Contains(inputWord[middle]);
            }
            else
            {
                return vowels.Contains(inputWord[middle]);
            }

        }
    }
}
 
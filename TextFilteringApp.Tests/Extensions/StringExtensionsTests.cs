using TextFilteringApp.Extensions;

namespace TextFilteringApp.Tests.Extensions
{
    public class StringExtensionsTests
    {
        [Theory]
        [InlineData("No, you can't have candy", "No you cant have candy")]
        [InlineData("Why are we still here? Just to suffer?", "Why are we still here Just to suffer")]
        [InlineData("Nooooo!!!!", "Nooooo")]
        public void StripPunctuation_RemovesAllPunctuation(string inputString, string expected)
        {
            var result = inputString.StripPunctuation();
            Assert.Equal(expected, result);
        }
    }
}

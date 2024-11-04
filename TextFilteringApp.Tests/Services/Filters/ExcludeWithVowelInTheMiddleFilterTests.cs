using TextFilteringApp.Services.Filtering;

namespace TextFilteringApp.Tests.Services.Filters
{
    public class ExcludeWithVowelInTheMiddleFilterTests
    {
        private ExcludeWithVowelInTheMiddleFilter _sut;

        public ExcludeWithVowelInTheMiddleFilterTests()
        {
            _sut = new ExcludeWithVowelInTheMiddleFilter();
        }

        [Fact]
        public void Filter_ShouldCorrectlyFilterOutWordsWithVowelInTheMiddle()
        {
            string[] input = ["What?", "This", "is", "definitely", "not", "my", "cat,", "I", "swear!"];
            var result = _sut.Filter(input);

            Assert.Equal(["my"], result);
        }

    }
}

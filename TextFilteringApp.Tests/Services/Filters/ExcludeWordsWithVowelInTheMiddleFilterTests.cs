using TextFilteringApp.Services.Filtering;

namespace TextFilteringApp.Tests.Services.Filters
{
    public class ExcludeWordsWithVowelInTheMiddleFilterTests
    {
        private ExcludeWordsWithVowelInTheMiddleFilter _sut;

        public ExcludeWordsWithVowelInTheMiddleFilterTests()
        {
            _sut = new ExcludeWordsWithVowelInTheMiddleFilter();
        }

        [Fact]
        public void Filter_ShouldCorrectlyFilterOutWordsWithVowelInTheMiddle()
        {
            string[] input = ["rather", "clean", "the", "what", "currently", "Karolina"];
            var result = _sut.Filter(input);

            Assert.Equal(["rather", "the"], result);
        }

    }
}

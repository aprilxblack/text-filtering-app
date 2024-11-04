using TextFilteringApp.Services.Filtering;

namespace TextFilteringApp.Tests.Services.Filters
{
    public class ExcludeWithLetterTFilterTests
    {
        private ExcludeWithLetterTFilter _sut;

        public ExcludeWithLetterTFilterTests()
        {
            _sut = new ExcludeWithLetterTFilter();
        }

        [Fact]
        public void Filter_ShouldExcludeAllWordsWithLetterT()
        {
            string[] input = ["Alice", "was", "beginning", "to", "get", "very", "tired", "of", "sitting", "by", "her", "sister", "on", "the", "bank.", "The", "end"];
            var result = _sut.Filter(input);
            Assert.Equal(["Alice", "was", "beginning", "very", "of", "by", "her", "on", "bank.", "end"], result);
        }
    }
}

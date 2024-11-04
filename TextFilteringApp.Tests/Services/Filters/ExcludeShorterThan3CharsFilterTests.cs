using TextFilteringApp.Services.Filtering;

namespace TextFilteringApp.Tests.Services.Filters
{
    public class ExcludeShorterThan3CharsFilterTests
    {
        public ExcludeShorterThan3CharsFilter _sut;

        public ExcludeShorterThan3CharsFilterTests()
        {
            _sut = new ExcludeShorterThan3CharsFilter();
        }

        [Fact]
        public void Filter_ShouldExludeWordsShorterThan3Chars()
        {
            string[] input = ["Yes,", "Karolina", "Zdziarska", "is", "a", "Senior", "Software", "Developer"];
            var result = _sut.Filter(input);

            Assert.Equal(["Yes,", "Karolina", "Zdziarska", "Senior", "Software", "Developer"], result);
        }
    }
}

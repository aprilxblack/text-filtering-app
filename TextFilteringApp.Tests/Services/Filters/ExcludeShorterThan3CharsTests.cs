using TextFilteringApp.Services.Filtering;

namespace TextFilteringApp.Tests.Services.Filters
{
    public class ExcludeShorterThan3CharsTests
    {
        public ExcludeShorterThan3Chars _sut;

        public ExcludeShorterThan3CharsTests()
        {
            _sut = new ExcludeShorterThan3Chars();
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

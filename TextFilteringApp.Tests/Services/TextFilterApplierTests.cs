using NSubstitute;
using TextFilteringApp.Services;
using TextFilteringApp.Services.Filtering;

namespace TextFilteringApp.Tests.Services
{
    public class TextFilterApplierTests
    {
        private TextFilterApplier _sut;
        private IFilter _filter = Substitute.For<IFilter>();

        public TextFilterApplierTests()
        {
            _sut = new TextFilterApplier(_filter);
        }

        [Fact]
        public void GivenTextInput_ShouldFilterCorrectly()
        {

        }

        [Theory]
        [InlineData("Karolina is a software developer", new string[] { "Karolina", "is", "a", "software", "developer" })]
        [InlineData("No, you can't have my pizza!", new string[] { "No,", "you", "can't", "have", "my", "pizza!" })]
        [InlineData("What is this?I don't know!", new string[] { "What", "is", "this?", "I", "don't", "know!" })]
        [InlineData("He said:'I can't do it'", new string[] { "He", "said:'", "I", "can't", "do", "it'"})]
        public void SeparateTextIntoWords_ShouldSeparatecorrectly(string input, string[] expected)
        {
            var result = TextFilterApplier.SeparateTextIntoWords(input);
            Assert.Equal(expected, result);
        }
    }
}

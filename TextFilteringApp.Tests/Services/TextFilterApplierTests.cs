using Moq;
using NSubstitute;
using TextFilteringApp.Services;
using TextFilteringApp.Services.Filtering;

namespace TextFilteringApp.Tests.Services
{
    public class TextFilterApplierTests
    {
        private TextFilterApplier _sut;
        private IFilter _filter1 = Substitute.For<IFilter>();
        private IFilter _filter2 = Substitute.For<IFilter>();
        private IFilter _filter3 = Substitute.For<IFilter>();

        public TextFilterApplierTests()
        {
            _sut = new TextFilterApplier([_filter1, _filter2, _filter3]);
        }

        [Fact]
        public void ApplyWithMultipleFilters_ShouldAggregateAllFilters()
        {
            var input = "Here is some text input: let's filter it";

            _filter1.Filter(It.IsAny<string[]>()).ReturnsForAnyArgs(new string[] { "Here", "is", "some", "text", "input:", "let's", "filter" });
            _filter2.Filter(It.IsAny<string[]>()).ReturnsForAnyArgs(new string[] { "Here", "is", "some", "text", "input:", "let's", "filter", "it"});
            _filter3.Filter(It.IsAny<string[]>()).ReturnsForAnyArgs(new string[] { "Here", "is", "some" });

            var expectedOutput = "Here is some";

            var result = _sut.Apply(input);
            Assert.Equal(expectedOutput, result);
        }

        [Theory]
        [InlineData("Karolina is a software developer", new string[] { "Karolina", "is", "a", "software", "developer" })]
        [InlineData("No, you can't have my pizza!", new string[] { "No,", "you", "can't", "have", "my", "pizza!" })]
        [InlineData("What is this?I don't know!", new string[] { "What", "is", "this?", "I", "don't", "know!" })]
        [InlineData("He said:'I can't do it'", new string[] { "He", "said:'", "I", "can't", "do", "it'"})]
        [InlineData("I am   happy", new string[] { "I", "am", "happy" })]
        public void SeparateTextIntoWords_ShouldSeparatecorrectly(string input, string[] expected)
        {
            var result = TextFilterApplier.SeparateTextIntoWords(input);
            Assert.Equal(expected, result);
        }
    }
}

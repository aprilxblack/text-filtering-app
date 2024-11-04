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
    }
}

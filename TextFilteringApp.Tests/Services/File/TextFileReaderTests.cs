using TextFilteringApp.Services.File;

namespace TextFilteringApp.Tests.Services.File
{
    public class TextFileReaderTests
    {
        private TextFileReader _sut;

        public TextFileReaderTests()
        {
            _sut = new TextFileReader();
        }

        [Fact]
        public async Task ReadAsStringAsync_GivenValidFilePath_ShouldReturnContent()
        {
            var testFilePath = Path.Combine(Environment.CurrentDirectory, "test-input.txt");
            var result = await _sut.ReadAsStringAsync(testFilePath);
            Assert.Equal("Hello, world from the unit test!", result);
        }

        [Fact]
        public async Task ReadAsStringAsync_GivenInvalidFilePath_ShouldThrowFileNotFoundException()
        {
            await Assert.ThrowsAsync<FileNotFoundException>(() => _sut.ReadAsStringAsync("some-invalid-path.txt"));
        }
    }
}

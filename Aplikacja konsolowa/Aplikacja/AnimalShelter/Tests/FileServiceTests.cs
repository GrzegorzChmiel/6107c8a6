using Application.Services;
using FluentAssertions;

namespace Tests
{
    [TestFixture]
    public class FileServiceTests
    {
        private FileService _fileService = null!;

        [SetUp]
        public void SetUp()
        {
            _fileService = new FileService();
        }

        [Test]
        public void SaveToFile_ShouldWriteAndReturnTrue()
        {
            var tempFile = Path.GetTempFileName();
            try
            {
                var data = "hello world";
                var result = _fileService.SaveToFile(tempFile, data);
                result.Should().BeTrue();

                var read = File.ReadAllText(tempFile);
                read.Should().Be(data);
            }
            finally
            {
                File.Delete(tempFile);
            }
        }

        [Test]
        public void LoadFromFile_ShouldReturnFileContents_WhenFileExists()
        {
            var tempFile = Path.GetTempFileName();
            try
            {
                File.WriteAllText(tempFile, "abc");
                var result = _fileService.LoadFromFile(tempFile);
                result.Should().Be("abc");
            }
            finally
            {
                File.Delete(tempFile);
            }
        }

        [Test]
        public void LoadFromFile_ShouldReturnEmpty_OnMissingFile()
        {
            var path = Path.Combine(Path.GetTempPath(), Guid.NewGuid().ToString() + ".txt");
            var result = _fileService.LoadFromFile(path);
            result.Should().BeEmpty();
        }
    }
}

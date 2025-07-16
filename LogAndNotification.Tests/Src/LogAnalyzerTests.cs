using LogAndNotification;
using NUnit.Framework;

namespace LogAndNotification.Tests
{
    [TestFixture]
    public class LogAnalyzerTests
    {
        [TestCase("filewithgoodextension.SLF", true)]
        [TestCase("filewithgoodextension.slf", true)]
        [TestCase("filewithbadextension.foo", false)]
        public void IsValidLogFileName_VariousExtensions_ChecksThem(string file, bool expected)
        {
            // Arrange
            LogAnalyzer analyzer = new LogAnalyzer();

            // Act
            bool result = analyzer.IsValidLogFileName(file);

            // Assert
            Assert.That(result, Is.EqualTo(expected));
        }
    }
}

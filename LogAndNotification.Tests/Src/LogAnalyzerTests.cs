using NUnit.Framework;

[TestFixture]
public class LogAnalyzerTests
{
    [Test]
    public void IsValidFileName_BadExtension_ReturnsFalse()
    {
        // Arrange
        LogAnalyzer analyzer = new LogAnalyzer();

        // Act
        bool result = analyzer.IsValidLogFileName("filewithbadextension.foo");

        // Assert
        Assert.False(result);
    }
}

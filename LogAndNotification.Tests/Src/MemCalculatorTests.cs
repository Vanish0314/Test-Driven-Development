using LogAndNotification;
using NUnit.Framework;

namespace LogAndNotification.Tests
{
    [TestFixture]
    public class MemCalculatorTests
    {
        [Test]
        public void Sum_ByDefault_ReturnsZero()
        {
            MemCalculator calc = new MemCalculator();
            int lastSum = calc.Sum();
            Assert.That(lastSum, Is.EqualTo(0));
        }
    }
}

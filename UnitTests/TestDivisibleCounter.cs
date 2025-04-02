using DivisibleLib;
using System.Text;

namespace UnitTests
{
    [TestClass]
    public sealed class TestDivisibleCounter
    {
        [TestMethod]
        public async Task ZeroDivisor()
        {
            Dictionary<int, string> divisors = new()
            {
                [0] = "test"
            };

            StringBuilder result = new StringBuilder();
            await foreach (var partialResult in DivisibleCounter.Count(1, divisors))
            {
                result.Append(partialResult);
            }

            Assert.AreEqual("1\n", result.ToString());
        }
    }
}

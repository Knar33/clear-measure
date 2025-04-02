using DivisibleLib;
using System.Text;

namespace UnitTests
{
    [TestClass]
    public sealed class TestDivisibleCounter
    {
        [TestMethod]
        public async Task OriginalRequirement()
        {
            Dictionary<int, string> divisors = new()
            {
                [3] = "first_name",
                [5] = "last_name",
            };

            StringBuilder result = new StringBuilder();
            await foreach (var partialResult in DivisibleCounter.Count(100, divisors))
            {
                result.Append(partialResult);
            }

            Assert.AreEqual("1\n2\nfirst_name\n4\nlast_name\nfirst_name\n7\n8\nfirst_name\nlast_name\n11\nfirst_name\n13\n14\nfirst_name last_name\n16\n17\nfirst_name\n19\nlast_name\nfirst_name\n22\n23\nfirst_name\nlast_name\n26\nfirst_name\n28\n29\nfirst_name last_name\n31\n32\nfirst_name\n34\nlast_name\nfirst_name\n37\n38\nfirst_name\nlast_name\n41\nfirst_name\n43\n44\nfirst_name last_name\n46\n47\nfirst_name\n49\nlast_name\nfirst_name\n52\n53\nfirst_name\nlast_name\n56\nfirst_name\n58\n59\nfirst_name last_name\n61\n62\nfirst_name\n64\nlast_name\nfirst_name\n67\n68\nfirst_name\nlast_name\n71\nfirst_name\n73\n74\nfirst_name last_name\n76\n77\nfirst_name\n79\nlast_name\nfirst_name\n82\n83\nfirst_name\nlast_name\n86\nfirst_name\n88\n89\nfirst_name last_name\n91\n92\nfirst_name\n94\nlast_name\nfirst_name\n97\n98\nfirst_name\nlast_name\n", result.ToString());
        }

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

        [TestMethod]
        public async Task NegativeUpperBound()
        {
            Dictionary<int, string> divisors = new()
            {
                [1] = "test"
            };

            StringBuilder result = new StringBuilder();
            await foreach (var partialResult in DivisibleCounter.Count(-1, divisors))
            {
                result.Append(partialResult);
            }

            Assert.AreEqual("", result.ToString());
        }

        [TestMethod]
        public async Task ZeroUpperBound()
        {
            Dictionary<int, string> divisors = new()
            {
                [1] = "test"
            };

            StringBuilder result = new StringBuilder();
            await foreach (var partialResult in DivisibleCounter.Count(0, divisors))
            {
                result.Append(partialResult);
            }

            Assert.AreEqual("", result.ToString());
        }

        [TestMethod]
        public async Task StreamingResults()
        {
            Dictionary<int, string> divisors = new()
            {
                [2] = "test"
            };

            int counter = 1;
            await foreach (var partialResult in DivisibleCounter.Count(0, divisors))
            {
                if (counter % 2 == 0)
                {
                    Assert.AreEqual("test\n", partialResult.ToString());
                }
                else
                {
                    Assert.AreEqual($"{counter}\n", partialResult.ToString());
                }
                counter++;
            }
        }
    }
}

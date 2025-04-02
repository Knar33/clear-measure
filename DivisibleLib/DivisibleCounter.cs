using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace DivisibleLib
{
    public class DivisibleCounter
    {
        public static async IAsyncEnumerable<string> Count(int upperBound, Dictionary<int, string> divisors, [EnumeratorCancellation] CancellationToken cancellationToken = default)
        {
            for (int i = 1; i <= upperBound; i++)
            {
                string partialResult = "";
                var divisible = false;
                foreach (var (divisor, text) in divisors)
                {
                    if (divisor == 0) continue;
                    if (i % divisor == 0)
                    {
                        partialResult += $"{text} ";
                        divisible = true;
                    }
                }
                if (!divisible)
                {
                    partialResult = $"{i}";
                }
                partialResult += "\n";

                yield return partialResult;
            }
        }
    }
}

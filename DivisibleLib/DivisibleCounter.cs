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
        public static async IAsyncEnumerable<string> Count(int upperBound, Dictionary<int, string> divisors, [EnumeratorCancellation] CancellationToken cancellationToken = default, string separator = "\n")
        {
            for (int i = 1; i <= upperBound; i++)
            {
                var divisible = false;
                List<string> divisorHits = new List<string>();

                foreach (var (divisor, text) in divisors)
                {
                    if (divisor == 0) continue;
                    if (i % divisor == 0)
                    {
                        divisorHits.Add(text);
                        divisible = true;
                    }
                }
                if (divisible)
                {
                    yield return $"{string.Join(" ", divisorHits)}{separator}";
                }
                else
                {
                    yield return $"{i}{separator}";
                }
            }
        }
    }
}

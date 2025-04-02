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
        public static async IAsyncEnumerable<string> Count(int upperBound, [EnumeratorCancellation] CancellationToken cancellationToken = default)
        {
            for (int i = 1; i <= upperBound; i++)
            {
                string partialResult = "";

                var divisibleByThree = false;
                var divisibleByFive = false;
                if (i % 3 == 0)
                {
                    divisibleByThree = true;
                }
                if (i % 5 == 0)
                {
                    divisibleByFive = true;
                }

                if (!divisibleByThree && !divisibleByFive)
                {
                    partialResult += $"{i} ";
                }

                if (divisibleByThree)
                {
                    partialResult += "FirstName ";
                }
                if (divisibleByFive)
                {
                    partialResult += "LastName";
                }
                partialResult += "\n";

                yield return partialResult;
            }
        }
    }
}

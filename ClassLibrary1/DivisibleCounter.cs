using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary1
{
    public class DivisibleCounter
    {
        public static string Count(int upperBound)
        {
            string countResult = "";

            for (int i = 1; i <= upperBound; i++)
            {
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
                    countResult += $"{i} ";
                }

                if (divisibleByThree)
                {
                    countResult += "FirstName ";
                }
                if (divisibleByFive)
                {
                    countResult += "LastName";
                }
                countResult += "\n";
            }
            return countResult;
        }
    }
}

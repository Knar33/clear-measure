using DivisibleLib;
using System.Reflection.Emit;

//TODO: 
//enhancement: parameratize name, number and word pairs (arbitrary number of number/word pairs)
//add unit test project, add unit tests to prove that it works, add regression tests

Dictionary<int, string> divisors = new()
{
    [3] = "first_name",
    [4] = "middle_name",
    [5] = "last_name"
};

await foreach (var partialResult in DivisibleCounter.Count(100, divisors))
{
    Console.Write(partialResult);
}
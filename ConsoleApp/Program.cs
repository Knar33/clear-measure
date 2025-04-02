using DivisibleLib;
using System.Reflection.Emit;

//TODO: 
//add unit test project, add unit tests to prove that it works, add regression tests
    //Test cases:
        //basic test from original requirements
        //divisor is 0
        //upper bound is negative 
        //test that results are being streamed

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
using DivisibleLib;
using System.Reflection.Emit;

//TODO: 
//implement as stream
//enhancement: parameratize name, number and word pairs (arbitrary number of number/word pairs)
//add unit test project, add unit tests to prove that it works, add regression tests

Console.WriteLine(DivisibleCounter.Count(Int32.MaxValue));

await foreach (var partialResult in DivisibleCounter.Count(Int32.MaxValue))
{
    Console.Write(partialResult);
}
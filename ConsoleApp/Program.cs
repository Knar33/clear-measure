﻿using DivisibleLib;

Dictionary<int, string> divisors = new()
{
    [3] = "first_name",
    [5] = "last_name"
};

await foreach (var partialResult in DivisibleCounter.Count(100, divisors))
{
    Console.Write(partialResult);
}
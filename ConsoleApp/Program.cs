using DivisibleLib;


//numers 1-100 printed to screen
//divisible by 3 - oprint "andrew"
//divisible by 5 - print "byerly"

//use in other programs
//create a dotnet library, get output back
//pass in upper bound, name still hardcoded

//implement as stream
//add unit test project, add unit tests to prove that it works, add regression tests
//enhancement: parameratize name, number and word pairs (arbitrary number of number/word pairs)
//push to public git repo

Console.WriteLine(DivisibleCounter.Count(Int32.MaxValue));
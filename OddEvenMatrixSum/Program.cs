var table = Enumerable.Range(1, 100).ToArray();

var evenSum = table.Where(x => x % 2 == 0).Sum();
var oddSum = table.Where(x => x % 2 != 0).Sum();

Console.WriteLine($"Sum of even numbers: {evenSum}");
Console.WriteLine($"Sum of odd numbers: {oddSum}");
var result = calculatePythagoreanTheorem(3.5, 6);

Console.WriteLine(result);

double calculatePythagoreanTheorem(double a, double b)
{
    return Math.Sqrt(Math.Pow(a, 2) + Math.Pow(b, 2));
}
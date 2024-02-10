using System.Collections;

var cities = new[] { "Gdańsk", "Warszawa", "Katowice", "Poznań", "Kraków", "Rzeszów" };
var array = ArrayList.Adapter(cities);

array.Sort(StringComparer.CurrentCulture);

Console.WriteLine("Cities in alphabetical order:");
foreach (var item in array)
{
    Console.WriteLine(item);
}
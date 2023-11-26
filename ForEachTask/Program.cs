var pets = new string[4]{"cat", "dog", "parrot", "guinea pig"};

foreach (var pet in pets)
{
    if (pet == "dog") {
        Console.WriteLine("End");
        
        break;
    }

    Console.WriteLine(pet);
}
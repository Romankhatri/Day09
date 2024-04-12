class Animal
{
    internal string species;
    internal string breed;
    internal string name;
    internal int height;
    internal int weight;

    internal void Printdetails()
    {
        Console.WriteLine($"Sepcies: {species}");
        Console.WriteLine($"Breed: {breed}");
        Console.WriteLine($"Name: {name}");
        Console.WriteLine($"Height: {height}'inches ");
        Console.WriteLine($"Weight: {weight}'pounds ");
        Console.WriteLine(" ");
    }
}
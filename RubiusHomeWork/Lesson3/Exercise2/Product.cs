namespace Lesson3.Exercise2;

internal class Product
{
    public required string Name { get; init; }
    public required decimal Price { get; init; }

    public required int Amount { get; set; }

    public override string ToString()
    {
        return $"Name: {Name}; Price: {Price}; Amount: {Amount}";
    }
}
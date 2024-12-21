namespace Lesson10.Entities;

public class Equipment
{
    public int Id { get; init; }
    public required string Name { get; set; }

    public override string ToString()
    {
        return $"Equipment: {Name}, Id: {Id}";
    }
}
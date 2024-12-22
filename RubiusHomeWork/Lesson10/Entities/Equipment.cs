using System.ComponentModel.DataAnnotations;

namespace Lesson10.Entities;

public class Equipment
{
    public int Id { get; init; }

    [Required(ErrorMessage = "Name is required")]
    [StringLength(100, MinimumLength = 1, ErrorMessage = "Name must be between 1 and 100 characters.")]
    public required string Name { get; set; }

    public override string ToString()
    {
        return $"{Name}, Id: {Id}";
    }
}
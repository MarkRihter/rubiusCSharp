namespace Lesson11.Entities;

public class AuthorData
{
    public int Id { get; init; }

    public string Name { get; set; }

    public string Bio { get; set; }

    public string BirthPlace { get; set; }

    public int AuthorId { get; set; }

    public Author Author { get; set; }
}
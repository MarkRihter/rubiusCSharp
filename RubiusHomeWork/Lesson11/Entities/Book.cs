namespace Lesson11.Entities;

public class Book
{
    public int Id { get; init; }

    public string Title { get; set; }

    public List<Genre> Genres { get; set; }

    public DateOnly DateOfPublication { get; set; }

    public int AuthorId { get; set; }

    public Author Author { get; set; }
}
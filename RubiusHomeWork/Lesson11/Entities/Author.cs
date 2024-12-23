using System.ComponentModel.DataAnnotations.Schema;

namespace Lesson11.Entities;

public class Author
{
    public int Id { get; init; }

    public AuthorData Data { get; set; }

    public List<Book> Books { get; set; }
}
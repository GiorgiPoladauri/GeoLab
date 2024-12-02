namespace LibraryManagementSystemProject.Models
{
    public class Author
    {
        public int AuthorId { get; set; }
        public required string Name { get; set; }
        public required string Nationality { get; set; }
        public DateOnly BirthYear { get; set; }
    }
}

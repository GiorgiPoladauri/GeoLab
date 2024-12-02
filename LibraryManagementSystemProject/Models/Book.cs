namespace LibraryManagementSystemProject.Models
{
    public class Book
    {
        public int BookId { get; set; }
        public required string Title { get; set; }
        public DateTime PublicationDate { get; set; }
        public int AuthorId { get; set; }
        public int Pages { get; set; }
        public int Quantity { get; set; }
    }
}

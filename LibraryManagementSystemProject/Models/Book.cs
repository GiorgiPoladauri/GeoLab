namespace LibraryManagementSystemProject.Models
{
    public class Book
    {
        public int BookId { get; set; }
        public string Title { get; set; }
        public DateTime PublicationDate { get; set; }
        public int AuthorId { get; set; }
        public int PageCount { get; set; }
        public string Description { get; set; }
        public int Quantity { get; set; }
    }
}

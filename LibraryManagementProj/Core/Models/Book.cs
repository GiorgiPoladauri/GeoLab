namespace LibraryManagementProj.Core.Models
{
    public class Book
    {
        public int BookID { get; set; }
        public string BookName { get; set; }
        public string Description { get; set; }
        public DateTime PublicationDate { get; set; }
        public string AuthorName { get; set; }
        public int Pages { get; set; }
        public int Quantity { get; set; }

        public Book() { }

        public Book(string bookname, string? description, DateTime publicationdate, string authorname, int pages, int quantity)
        {
            BookName = bookname;
            Description = description;
            PublicationDate = publicationdate;
            AuthorName = authorname;
            Pages = pages;
            Quantity = quantity;
        }

        public void UpdateBook(string bookname, string? description, DateTime publicationdate, string authorname, int pages, int quantity)
        {
            BookName = bookname;
            Description = description;
            PublicationDate = publicationdate;
            AuthorName = authorname;
            Pages = pages;
            Quantity = quantity;
        }

    }
}

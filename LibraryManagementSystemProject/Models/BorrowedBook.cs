namespace LibraryManagementSystemProject.Models
{
    public class BorrowedBook
    {
        public int BorrowedBookId { get; set; }
        public int UserId { get; set; }
        public int BookId { get; set; }
        public DateTime BorrowDate { get; set; }
        public DateTime? ReturnDate { get; set; }
    }
}

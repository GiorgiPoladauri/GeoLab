namespace LibraryManagementProj.Models
{
    public class BorrowedBook
    {
        public int BorrowedBookID { get; set; }
        public int UserID { get; set; }
        public int BookID { get; set; }
        public DateTime BorrowDate { get; set; }
        public DateTime ReturnDate { get; set; }

        public BorrowedBook(int borrowedbookid, int userid, int bookid, DateTime borrowdate, DateTime returndate)
        {
            BorrowedBookID = borrowedbookid;
            UserID = userid;
            BookID = bookid;
            BorrowDate = borrowdate;
            ReturnDate = returndate;
        }
    }
}

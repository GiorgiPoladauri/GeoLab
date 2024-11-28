using LibraryManagementSystemProject.Models;
using LibraryManagementSystemProject.Repositories;

namespace LibraryManagementSystemProject.Services
{
    public class BorrowService
    {
        private BookRepository _bookRepository;
        private BorrowedBookRepository _borrowRepository;
        private UserRepository _userRepository;

        public BorrowService()
        {
            _bookRepository = new BookRepository("books.json");
            _borrowRepository = new BorrowedBookRepository("borrowedBooks.json");
            _userRepository = new UserRepository("users.json");
        }

        public void BorrowBook(int userId, int bookId)
        {
            var books = _bookRepository.GetAll();
            var book = books.FirstOrDefault(b => b.BookId == bookId);
            var users = _userRepository.GetAll();
            var user = users.FirstOrDefault(u => u.UserId == userId);
            var borrowedBooks = _borrowRepository.GetAll();
            var userBorrowedBooks = borrowedBooks.Where(b => b.UserId == userId).ToList();

            var borrow = new BorrowedBook
            {
                BorrowedBookId = borrowedBooks.Count > 0 ? borrowedBooks.Max(b => b.BorrowedBookId) + 1 : 1,
                UserId = userId,
                BookId = bookId,
                BorrowDate = DateTime.Now
            };

            if (book == null)
            {
                MessageBox.Show("Error: Book not found.");
                return;
            }

            else if (book.Quantity <= 0)
            {
                MessageBox.Show("Error: Book is not available.");
                return;
            }

            if (user == null)
            {
                MessageBox.Show("Error: User not found.");
                return;
            }

            else if (userBorrowedBooks.Count >= 5)
            {
                MessageBox.Show("Error: 5 book limit has been reached.");
                return;
            }

            else
            {
                _borrowRepository.Add(borrow);

                book.Quantity -= 1;
                _bookRepository.SaveAll(books);

                MessageBox.Show("Congrats, Borrowed !");
            }
        }

        public void ReturnBook(int borrowId)
        {
            var borrowedBooks = _borrowRepository.GetAll();
            var borrow = borrowedBooks.FirstOrDefault(b => b.BorrowedBookId == borrowId);
            var books = _bookRepository.GetAll();
            var book = books.FirstOrDefault(b => b.BookId == borrow.BookId);

            if (borrow == null)
            {
                MessageBox.Show("Error: Invalid borrow ID.");
                return;
            }

            if (borrow.ReturnDate != null)
            {
                MessageBox.Show("Error: Book has been already returned.");
                return;
            }

            if (book != null)
            {
                book.Quantity += 1;
                _bookRepository.SaveAll(books);
            }

            else
            {
                borrow.ReturnDate = DateTime.Now;
                _borrowRepository.SaveAll(borrowedBooks);

                MessageBox.Show("Success !");
            }
        }
    }
}

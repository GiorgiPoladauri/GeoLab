using LibraryManagementSystemProject.Services;
using System;
using System.Windows.Forms;

namespace LibraryManagementSystemProject
{
    public partial class Form1 : Form
    {
        private UserService userService;
        private BorrowService borrowService;

        public Form1()
        {
            InitializeComponent();
            userService = new UserService();
            borrowService = new BorrowService();
        }

        private void RegisterButton_Click(object sender, EventArgs e)
        {
            string userName = UserNameTextBox.Text;
            string personalId = PersonalIdTextBox.Text;
            string email = EmailTextBox.Text;
            userService.RegisterUser(userName, personalId, email);
        }

        private void BorrowBookButton_Click(object sender, EventArgs e)
        {
            if (!int.TryParse(UserIdForBorrowTextBox.Text, out int userId))
            {
                MessageBox.Show("Invalid User ID. Please enter a valid number.");
                return;
            }

            if (!int.TryParse(BookIdForBorrowTextBox.Text, out int bookId))
            {
                MessageBox.Show("Invalid Book ID. Please enter a valid number.");
                return;
            }

            borrowService.BorrowBook(userId, bookId);
        }


        private void DeleteUserButton_Click(object sender, EventArgs e)
        {
            int userId = int.Parse(UserIdForDeleteTextBox.Text);
            userService.DeleteUser(userId);
            MessageBox.Show("User deleted successfully!");
        }

        private void ReturnBookButton_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(BorrowIdForReturnTextBox.Text))
            {
                MessageBox.Show("Please enter a valid Borrow ID.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (int.TryParse(BorrowIdForReturnTextBox.Text, out int borrowId))
            {
                try
                {
                    borrowService.ReturnBook(borrowId);
                    MessageBox.Show("Book returned successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Error: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("Invalid Borrow ID entered. Please enter a numeric value.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }


        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}

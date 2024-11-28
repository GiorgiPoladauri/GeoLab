namespace LibraryManagementSystemProject
{
    partial class Form1
    {
        private System.ComponentModel.IContainer components = null;
        private System.Windows.Forms.Button RegisterButton;
        private System.Windows.Forms.Button BorrowBookButton;
        private System.Windows.Forms.Button DeleteUserButton;
        private System.Windows.Forms.Button ReturnBookButton;
        private System.Windows.Forms.TextBox UserNameTextBox;
        private System.Windows.Forms.TextBox PersonalIdTextBox;
        private System.Windows.Forms.TextBox EmailTextBox;
        private System.Windows.Forms.TextBox UserIdForBorrowTextBox;
        private System.Windows.Forms.TextBox BookIdForBorrowTextBox;
        private System.Windows.Forms.TextBox UserIdForDeleteTextBox;
        private System.Windows.Forms.TextBox BorrowIdForReturnTextBox;
        private System.Windows.Forms.Label UserNameLabel;
        private System.Windows.Forms.Label PersonalIdLabel;
        private System.Windows.Forms.Label EmailLabel;
        private System.Windows.Forms.Label UserIdForBorrowLabel;
        private System.Windows.Forms.Label BookIdForBorrowLabel;
        private System.Windows.Forms.Label UserIdForDeleteLabel;
        private System.Windows.Forms.Label BorrowIdForReturnLabel;

        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            RegisterButton = new Button();
            BorrowBookButton = new Button();
            DeleteUserButton = new Button();
            ReturnBookButton = new Button();
            UserNameTextBox = new TextBox();
            PersonalIdTextBox = new TextBox();
            EmailTextBox = new TextBox();
            UserIdForBorrowTextBox = new TextBox();
            BookIdForBorrowTextBox = new TextBox();
            UserIdForDeleteTextBox = new TextBox();
            BorrowIdForReturnTextBox = new TextBox();
            UserNameLabel = new Label();
            PersonalIdLabel = new Label();
            EmailLabel = new Label();
            UserIdForBorrowLabel = new Label();
            BookIdForBorrowLabel = new Label();
            UserIdForDeleteLabel = new Label();
            BorrowIdForReturnLabel = new Label();
            label1 = new Label();
            timer1 = new System.Windows.Forms.Timer(components);
            SuspendLayout();
            // 
            // RegisterButton
            // 
            RegisterButton.BackColor = Color.LightSkyBlue;
            RegisterButton.Location = new Point(274, 78);
            RegisterButton.Name = "RegisterButton";
            RegisterButton.Size = new Size(100, 30);
            RegisterButton.TabIndex = 0;
            RegisterButton.Text = "Register User";
            RegisterButton.UseVisualStyleBackColor = false;
            RegisterButton.Click += RegisterButton_Click;
            // 
            // BorrowBookButton
            // 
            BorrowBookButton.BackColor = Color.LightSkyBlue;
            BorrowBookButton.Location = new Point(274, 218);
            BorrowBookButton.Name = "BorrowBookButton";
            BorrowBookButton.Size = new Size(100, 30);
            BorrowBookButton.TabIndex = 1;
            BorrowBookButton.Text = "Borrow Book";
            BorrowBookButton.UseVisualStyleBackColor = false;
            BorrowBookButton.Click += BorrowBookButton_Click;
            // 
            // DeleteUserButton
            // 
            DeleteUserButton.BackColor = Color.LightSkyBlue;
            DeleteUserButton.Location = new Point(274, 314);
            DeleteUserButton.Name = "DeleteUserButton";
            DeleteUserButton.Size = new Size(100, 30);
            DeleteUserButton.TabIndex = 2;
            DeleteUserButton.Text = "Delete User";
            DeleteUserButton.UseVisualStyleBackColor = false;
            DeleteUserButton.Click += DeleteUserButton_Click;
            // 
            // ReturnBookButton
            // 
            ReturnBookButton.BackColor = Color.LightSkyBlue;
            ReturnBookButton.Location = new Point(274, 364);
            ReturnBookButton.Name = "ReturnBookButton";
            ReturnBookButton.Size = new Size(100, 30);
            ReturnBookButton.TabIndex = 3;
            ReturnBookButton.Text = "Return Book";
            ReturnBookButton.UseVisualStyleBackColor = false;
            ReturnBookButton.Click += ReturnBookButton_Click;
            // 
            // UserNameTextBox
            // 
            UserNameTextBox.BackColor = Color.LightSteelBlue;
            UserNameTextBox.Location = new Point(150, 50);
            UserNameTextBox.Name = "UserNameTextBox";
            UserNameTextBox.Size = new Size(100, 27);
            UserNameTextBox.TabIndex = 11;
            // 
            // PersonalIdTextBox
            // 
            PersonalIdTextBox.BackColor = Color.LightSteelBlue;
            PersonalIdTextBox.Location = new Point(150, 80);
            PersonalIdTextBox.Name = "PersonalIdTextBox";
            PersonalIdTextBox.Size = new Size(100, 27);
            PersonalIdTextBox.TabIndex = 12;
            // 
            // EmailTextBox
            // 
            EmailTextBox.BackColor = Color.LightSteelBlue;
            EmailTextBox.Location = new Point(150, 110);
            EmailTextBox.Name = "EmailTextBox";
            EmailTextBox.Size = new Size(100, 27);
            EmailTextBox.TabIndex = 13;
            // 
            // UserIdForBorrowTextBox
            // 
            UserIdForBorrowTextBox.BackColor = Color.LightSteelBlue;
            UserIdForBorrowTextBox.Location = new Point(150, 205);
            UserIdForBorrowTextBox.Name = "UserIdForBorrowTextBox";
            UserIdForBorrowTextBox.Size = new Size(100, 27);
            UserIdForBorrowTextBox.TabIndex = 14;
            // 
            // BookIdForBorrowTextBox
            // 
            BookIdForBorrowTextBox.BackColor = Color.LightSteelBlue;
            BookIdForBorrowTextBox.Location = new Point(150, 238);
            BookIdForBorrowTextBox.Name = "BookIdForBorrowTextBox";
            BookIdForBorrowTextBox.Size = new Size(100, 27);
            BookIdForBorrowTextBox.TabIndex = 15;
            // 
            // UserIdForDeleteTextBox
            // 
            UserIdForDeleteTextBox.BackColor = Color.LightSteelBlue;
            UserIdForDeleteTextBox.Location = new Point(150, 316);
            UserIdForDeleteTextBox.Name = "UserIdForDeleteTextBox";
            UserIdForDeleteTextBox.Size = new Size(100, 27);
            UserIdForDeleteTextBox.TabIndex = 16;
            // 
            // BorrowIdForReturnTextBox
            // 
            BorrowIdForReturnTextBox.BackColor = Color.LightSteelBlue;
            BorrowIdForReturnTextBox.Location = new Point(150, 366);
            BorrowIdForReturnTextBox.Name = "BorrowIdForReturnTextBox";
            BorrowIdForReturnTextBox.Size = new Size(100, 27);
            BorrowIdForReturnTextBox.TabIndex = 17;
            // 
            // UserNameLabel
            // 
            UserNameLabel.Location = new Point(50, 50);
            UserNameLabel.Name = "UserNameLabel";
            UserNameLabel.Size = new Size(100, 23);
            UserNameLabel.TabIndex = 4;
            UserNameLabel.Text = "User Name:";
            // 
            // PersonalIdLabel
            // 
            PersonalIdLabel.Location = new Point(50, 80);
            PersonalIdLabel.Name = "PersonalIdLabel";
            PersonalIdLabel.Size = new Size(100, 23);
            PersonalIdLabel.TabIndex = 5;
            PersonalIdLabel.Text = "Personal ID:";
            // 
            // EmailLabel
            // 
            EmailLabel.Location = new Point(50, 110);
            EmailLabel.Name = "EmailLabel";
            EmailLabel.Size = new Size(100, 23);
            EmailLabel.TabIndex = 6;
            EmailLabel.Text = "Email:";
            // 
            // UserIdForBorrowLabel
            // 
            UserIdForBorrowLabel.Location = new Point(44, 205);
            UserIdForBorrowLabel.Name = "UserIdForBorrowLabel";
            UserIdForBorrowLabel.Size = new Size(100, 23);
            UserIdForBorrowLabel.TabIndex = 7;
            UserIdForBorrowLabel.Text = "User ID for Borrow:";
            // 
            // BookIdForBorrowLabel
            // 
            BookIdForBorrowLabel.Location = new Point(44, 241);
            BookIdForBorrowLabel.Name = "BookIdForBorrowLabel";
            BookIdForBorrowLabel.Size = new Size(100, 23);
            BookIdForBorrowLabel.TabIndex = 8;
            BookIdForBorrowLabel.Text = "Book ID for Borrow:";
            // 
            // UserIdForDeleteLabel
            // 
            UserIdForDeleteLabel.Location = new Point(44, 320);
            UserIdForDeleteLabel.Name = "UserIdForDeleteLabel";
            UserIdForDeleteLabel.Size = new Size(100, 23);
            UserIdForDeleteLabel.TabIndex = 9;
            UserIdForDeleteLabel.Text = "User ID to Delete:";
            // 
            // BorrowIdForReturnLabel
            // 
            BorrowIdForReturnLabel.Location = new Point(44, 369);
            BorrowIdForReturnLabel.Name = "BorrowIdForReturnLabel";
            BorrowIdForReturnLabel.Size = new Size(100, 23);
            BorrowIdForReturnLabel.TabIndex = 10;
            BorrowIdForReturnLabel.Text = "Borrow ID to Return:";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.LightSkyBlue;
            label1.BorderStyle = BorderStyle.FixedSingle;
            label1.Cursor = Cursors.Cross;
            label1.Location = new Point(129, 9);
            label1.Name = "label1";
            label1.Padding = new Padding(10, 5, 10, 5);
            label1.Size = new Size(143, 32);
            label1.TabIndex = 18;
            label1.Text = "Welcome to LMT";
            label1.Click += label1_Click;
            // 
            // Form1
            // 
            BackColor = Color.LightGray;
            ClientSize = new Size(978, 449);
            Controls.Add(label1);
            Controls.Add(RegisterButton);
            Controls.Add(BorrowBookButton);
            Controls.Add(DeleteUserButton);
            Controls.Add(ReturnBookButton);
            Controls.Add(UserNameLabel);
            Controls.Add(PersonalIdLabel);
            Controls.Add(EmailLabel);
            Controls.Add(UserIdForBorrowLabel);
            Controls.Add(BookIdForBorrowLabel);
            Controls.Add(UserIdForDeleteLabel);
            Controls.Add(BorrowIdForReturnLabel);
            Controls.Add(UserNameTextBox);
            Controls.Add(PersonalIdTextBox);
            Controls.Add(EmailTextBox);
            Controls.Add(UserIdForBorrowTextBox);
            Controls.Add(BookIdForBorrowTextBox);
            Controls.Add(UserIdForDeleteTextBox);
            Controls.Add(BorrowIdForReturnTextBox);
            Cursor = Cursors.Cross;
            FormBorderStyle = FormBorderStyle.Fixed3D;
            MaximizeBox = false;
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Library Management Tool";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        private Label label1;
        private System.Windows.Forms.Timer timer1;
    }
}

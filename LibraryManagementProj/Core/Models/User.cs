namespace LibraryManagementProj.Core.Models
{
    public class User
    {
        public int UserID { get; set; }
        public string UserName { get; set; }
        public string PersonalNumber { get; set; }
        public string Email { get; set; }

        public User() { }

        public User(string username, string personalnumber, string email)
        {
            UserName = username;
            PersonalNumber = personalnumber;
            Email = email;
        }

        public void UpdateUser(string username, string personalnumber, string email)
        {
            UserName = username;
            PersonalNumber = personalnumber;
            Email = email;
        }

    }
}

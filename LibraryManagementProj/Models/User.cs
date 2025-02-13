namespace LibraryManagementProj.Models
{
    public class User
    {
        public int UserID { get; set; }
        public string UserName { get; set; }
        public string PersonalNumber { get; set; }
        public string Email { get; set; }

        public User(int userid, string username, string personalnumber, string email)
        {
            UserID = userid;
            UserName = username;
            PersonalNumber = personalnumber;
            Email = email;
        }
    }
}

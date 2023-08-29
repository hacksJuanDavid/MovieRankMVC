namespace MovieRank.Models
{
    public class LoginViewModel
    {
        public LoginViewModel(string userEmail, string password)
        {
            UserEmail = userEmail;
            Password = password;
        }

        public string UserEmail { get; set; }
        public string Password { get; set; }
    }
}
namespace WebApplication3.Models
{
    public class User
    {
        public User(string username, string token)
        {
            this.username = username;
            this.token = token;
        }

        public string username { get; set; }
        public string token { get; set; }
    }
}
namespace Core_API_Postgre_Identity.Models
{
    public class RegisterUser
    {
        public string? Email { get; set; }
        public string? Password { get; set; }
    }

    public class LoginUser
    {
        public string? Email { get; set; }
        public string? Password { get; set; }
    }
}

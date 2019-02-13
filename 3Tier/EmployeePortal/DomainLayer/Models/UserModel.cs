namespace DomainLayer.Models
{
    public class UserModel
    {
        public string Email { get; set; }
        public string Password { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public bool IsStudent { get; set; }
        public UserModel(string FirstName, string LastName, string Email, string Password, bool IsStudent)
        {
            this.Email = Email;
            this.Password = Password;
            this.FirstName = FirstName;
            this.LastName = LastName;
            this.IsStudent = IsStudent;
        }
    }
}

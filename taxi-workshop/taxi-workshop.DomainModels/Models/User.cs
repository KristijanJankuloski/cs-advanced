using taxi_workshop.DomainModels.Enums;

namespace taxi_workshop.DomainModels.Models
{
    public class User : BaseEntity
    {
        public string Username { get; set; }
        public string Password { get; set; }
        public Role Role { get; set; }

        public User(){}
        public User(string username, string password, Role role)
        {
            Username = username;
            Password = password;
            Role = role;
        }

        public override string Print()
        {
            return $"{Username} - {Role}";
        }
    }
}

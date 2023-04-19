namespace Events.Models
{
    public class User
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Email { get; set; }
        public int Age { get; set; }

        public User(){}
        public User(string firstName, string lastName, string email, int age)
        {
            FirstName = firstName;
            LastName = lastName;
            Email = email;
            Age = age;
        }

        public void ReadPromotion(ProductType productType, string marketName)
        {
            Console.WriteLine($"Hello {FirstName}, there is a promotion avalible for {productType} at {marketName}");
        }
    }
}

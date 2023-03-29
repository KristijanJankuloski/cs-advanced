using ClassExercises.Models;

string WelcomeUser(string name)
{
    return $"Dear {name}, welcome to our company!";
}

string GetMessage(int index, string[] stringArr)
{
    return stringArr[index];
}

double Average(List<int> intList)
{
    return intList.Average();
}

int Sum(List<int> intList)
{
    return intList.Sum();
}

User GetUserByName(List<User> users)
{
    return users.Where(u => u.Username == "Kiko").FirstOrDefault();
}
List<User> users = new() { new User("Kiko", 25), new User("John", 23), new User("Bob", 22)};
User foundUser = GetUserByName(users);
Console.WriteLine($"{foundUser.Username} {foundUser.Age}");
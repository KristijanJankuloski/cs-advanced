using Interfaces.Entities;
using Interfaces.Entities.Interfaces;

List<IUser> users = new List<IUser>();
Teacher teacher1 = new Teacher() { Id=1 ,Name = "Kristijan", Username = "kiko", Password = "1234", Subject="CS" };
Teacher teacher2 = new Teacher() { Id = 2, Name = "John", Username = "jd", Password = "password", Subject = "Networking" };
Student student = new Student() { Id = 3, Name = "Bob", Username = "bob", Password = "12345", Grades = new List<int> { 5, 4, 5, 3} };

users.Add(teacher1);
users.Add(teacher2);
users.Add(student);

foreach(var user in users)
{
    user.PrintUser();
}
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassExercises.Models
{
    public class User
    {
        public string Username { get; set; }
        public int Age { get; set; }

        public User(string username, int age)
        {
            Username = username;
            Age = age;  
        }
    }
}

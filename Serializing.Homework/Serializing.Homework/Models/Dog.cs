using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Serializing.Homework.Models
{
    public class Dog
    {
        public string? Name { get; set; }
        public DateTime DateOfBirth { get; set; }
        public DogColor Color { get; set; }

        public Dog() { }
        public Dog(string name, DateTime birthDate, DogColor color)
        {
            Name = name;
            DateOfBirth = birthDate;
            Color = color;
        }

        public int GetAge()
        {
            return DateTime.Now.Year - DateOfBirth.Year;
        }
    }
}

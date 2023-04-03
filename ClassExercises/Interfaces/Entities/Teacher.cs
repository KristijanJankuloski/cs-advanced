using Interfaces.Entities.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interfaces.Entities
{
    public class Teacher : User, ITeacher
    {
        public string Subject { get; set; }

        public override void PrintUser()
        {
            Console.WriteLine($"{Id}, {Name} {Username} - {Subject}");
        }
    }
}

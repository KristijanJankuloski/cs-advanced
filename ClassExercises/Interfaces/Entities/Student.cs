using Interfaces.Entities.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interfaces.Entities
{
    internal class Student : User, IStudent
    {
        public List<int> Grades { get; set; }

        public override void PrintUser()
        {
            Console.Write($"\n{Id}, {Name} {Username}");
            foreach( var grade in Grades)
            {
                Console.Write( $"{grade} " );
                Console.WriteLine();
            }
        }
    }
}

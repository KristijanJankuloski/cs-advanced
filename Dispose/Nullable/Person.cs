using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Nullable
{
    public class Person
    {
        public int Id { get; set; }
        public string? Name { get; set; }
        public int? Score { get; set; }
        //public Person(int id, string name, int score)
        //{
        //    Id = id;
        //    Name = name;
        //    Score = score;
        //}
    }
}

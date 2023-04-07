using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Generics.Entities
{
    public class GenericDb<T> where T : BaseEntity
    {
        public List<T> List { get; set; }
        public GenericDb()
        {
            List = new List<T>();
        }

        public void Add(T item)
        {
            List.Add(item);
        }

        public void PrintItems()
        {
            foreach (var item in List)
            {
                Console.WriteLine(item.GetInfo());
            }
        }
    }
}

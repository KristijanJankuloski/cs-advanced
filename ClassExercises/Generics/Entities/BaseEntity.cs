using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Generics.Entities
{
    public abstract class BaseEntity
    {
        public int Id { get; set; }

        public BaseEntity(){}
        public BaseEntity(int id)
        {
            Id = id;
        }
        public abstract string GetInfo();
    }
}

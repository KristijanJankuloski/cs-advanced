using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Generics.Entities
{
    internal class Order : BaseEntity
    {
        public string Details { get; set; }
        public DateTime DateOrdered { get; set; }
        public Order(int id, string details) : base(id)
        {
            this.Details = details;
            DateOrdered = DateTime.Now;
        }
        public override string GetInfo()
        {
            return $"{Id} {Details} - {DateOrdered}";
        }
    }
}

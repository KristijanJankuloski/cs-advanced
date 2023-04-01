using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interfaces.Entities.Interfaces
{
    public interface IUser
    {
        int Id { get; set; }
        string Name { get; set; }
        string Username { get; set; }
        string Password { get; set; }
        void PrintUser();
    }
}

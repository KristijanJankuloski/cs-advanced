using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using taxi_workshop.DomainModels.Enums;
using taxi_workshop.DomainModels.Models;
using taxi_workshop.Services.Implementations;

namespace taxi_workshop.Desktop.Helpers
{
    public static class ServiceHelper
    {
        public static UserService userService = new UserService();

        static ServiceHelper()
        {
            userService.Add(new User("admin", "admin", Role.Administrator));
            userService.Add(new User("john", "jd123", Role.Manager));
            userService.Add(new User("kiko", "kiko", Role.Maintenence));
            userService.Add(new User("user", "user", Role.Manager));
            userService.Add(new User("bob", "bob123", Role.Administrator));
        }
    }
}

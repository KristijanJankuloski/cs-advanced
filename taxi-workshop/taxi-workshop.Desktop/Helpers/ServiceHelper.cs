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
        public static DriverService driverService = new DriverService();
        public static CarService carService = new CarService();

        static ServiceHelper()
        {
            userService.Add(new User("admin", "admin", Role.Administrator));
            userService.Add(new User("john", "jd123", Role.Manager));
            userService.Add(new User("kiko", "kiko", Role.Maintenence));
            userService.Add(new User("user", "user", Role.Manager));
            userService.Add(new User("bob", "bob123", Role.Administrator));

            carService.Add(new Car("Corola", "SK1234AA", DateTime.Now.AddMonths(12)));
            carService.Add(new Car("Polo", "SK1111AA", DateTime.Now.AddMonths(2)));
            carService.Add(new Car("Mercedes", "SK1212AB", DateTime.Now.AddDays(-2)));

            Driver newDriver1 = new Driver("John", "Doe", Shift.Morning, carService.GetSingle(1), "A12345", DateTime.Now.AddMonths(4));
            Driver newDriver2 = new Driver("Bob", "Bobski", Shift.Evening, carService.GetSingle(1), "A12323", DateTime.Now.AddMonths(2));
            carService.GetSingle(1).AssignedDrivers.Add(newDriver1);
            carService.GetSingle(1).AssignedDrivers.Add(newDriver2);

            driverService.Add(newDriver1);
            driverService.Add(newDriver2);
        }
    }
}

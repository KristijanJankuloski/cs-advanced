using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using taxi_workshop.DomainModels.Enums;
using taxi_workshop.DomainModels.Models;
using taxi_workshop.Services.Interfaces;

namespace taxi_workshop.Services.Implementations
{
    public class CarService : ServiceBase<Car>, ICarService
    {
        public bool IsCarAvailable(Car car) =>
            car.IsLicenseExpiered() != ExpieryStatus.Expired && car.AssignedDrivers.Count != 3;
    }
}

using taxi_workshop.DomainModels.Enums;
using taxi_workshop.DomainModels.Models;
using taxi_workshop.Services.Interfaces;

namespace taxi_workshop.Services.Implementations
{
    public class DriverService : ServiceBase<Driver>, IDriverService
    {
        public void AssignDriver(Driver driver, Car car)
        {
            driver.Car = car;
            _db.Update(driver);
        }

        public bool IsDriverAvailable(Driver driver) =>
            driver.IsLicenseExpiered() != ExpieryStatus.Expired && driver.Car != null;

        public void UnassignDriver(Driver driver)
        {
            driver.Car = null;
            _db.Update(driver);
        }
    }
}

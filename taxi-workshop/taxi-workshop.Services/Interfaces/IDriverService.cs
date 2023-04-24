using taxi_workshop.DomainModels.Models;

namespace taxi_workshop.Services.Interfaces
{
    internal interface IDriverService : IServiceBase<Driver>
    {
        void AssignDriver(Driver driver, Car car);
        void UnassignDriver(Driver driver);
        bool IsDriverAvailable(Driver driver);
    }
}

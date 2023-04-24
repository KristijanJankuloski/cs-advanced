using taxi_workshop.DomainModels.Models;

namespace taxi_workshop.Services.Interfaces
{
    public interface ICarService : IServiceBase<Car>
    {
        bool IsCarAvailable(Car car);
    }
}

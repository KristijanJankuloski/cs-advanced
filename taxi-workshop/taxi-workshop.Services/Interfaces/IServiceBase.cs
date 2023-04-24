using taxi_workshop.DomainModels.Models;

namespace taxi_workshop.Services.Interfaces
{
    public interface IServiceBase<T> where T : BaseEntity
    {
        List<T> GetAll();
        T GetSingle(int id);
        void Add(T entity);
        void Remove(int id);
    }
}

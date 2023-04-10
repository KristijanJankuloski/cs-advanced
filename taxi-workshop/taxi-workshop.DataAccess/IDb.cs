using taxi_workshop.DomainModels.Models;

namespace taxi_workshop.DataAccess
{
    public interface IDb<T>  where T : BaseEntity
    {
        List<T> GetAll();
        T GetById(int id);
        int Insert(T item);
        void Update(T item);
        void DeleteById(int id);
    }
}

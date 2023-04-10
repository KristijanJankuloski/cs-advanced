using taxi_workshop.DomainModels.Models;

namespace taxi_workshop.DataAccess
{
    public class LocalDb<T> : IDb<T> where T : BaseEntity
    {
        private List<T> _db;
        public int IdCount { get; set; }
        public LocalDb()
        {
            _db = new List<T>();
            IdCount = 1;
        }
        public List<T> GetAll()
        {
            return _db;
        }

        public T GetById(int id)
        {
            return _db.SingleOrDefault(x => x.Id == id);
        }

        public int Insert(T item)
        {
            item.Id = IdCount++;
            _db.Add(item);
            return item.Id;
        }

        public void Update(T item)
        {
            T newItem = _db.SingleOrDefault(x => x.Id == item.Id);
            newItem = item;
        }

        public void DeleteById(int id)
        {
            T itemToRemove = _db.SingleOrDefault(x => x.Id == id);
            if (itemToRemove != null)
                _db.Remove(itemToRemove);
        }
    }
}

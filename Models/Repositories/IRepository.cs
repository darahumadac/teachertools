using System.Collections.Generic;

namespace Models.Repositories
{
    public interface IRepository<T> where T : class
    {
        void Add(T entity);
        void Update(T entity);
        void Delete(T entity);
        List<T> GetAll();
        List<T> GetByIdentifier(string numberOrCode);
    }
}
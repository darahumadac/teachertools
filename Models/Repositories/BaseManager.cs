using System.Collections.Generic;

namespace Models.Repositories
{
    public abstract class BaseManager<T> where T : class 
    {
        protected readonly IRepository<T> Repository;

        protected BaseManager(IRepository<T> repository)
        {
            Repository = repository;
        }

        public virtual void Add(T entity)
        {
            Repository.Add(entity);
        }

        public virtual void Update(T entity)
        {
            Repository.Update(entity);
        }

        public virtual void Delete(T entity)
        {
            Repository.Delete(entity);
        }

        public List<T> GetAllRecords()
        {
            return Repository.GetAll();
        }

        public int TotalRecordCount
        {
            get { return GetAllRecords().Count; }
        }
    }
}
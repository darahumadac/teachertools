using System.Collections.Generic;

namespace TeacherTools.Forms
{
    public interface IRecordManager<T>
    {
        void Add(T entity);
        void Update(T entity);
        void Delete(T entity);
        List<T> GetAllRecords();
    }
}
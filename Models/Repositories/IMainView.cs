using System.Collections.Generic;

namespace Models.Repositories
{
    public interface IMainView<T>
    {
        void ShowAllRecords();
        void ShowFilteredRecords(List<T> recordList);
        void AddRecord();
        void EditSelectedRecord();
        void DeleteSelectedRecord();
    }
}
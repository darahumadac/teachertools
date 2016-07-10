using System.Collections.Generic;

namespace Models.Repositories
{
    public interface IMainView<T>
    {
        void ShowAllRecords();
        void ShowAllRecords(string[] excludeColumns);
        void ShowFilteredRecords(string[] excludeColumns, List<T> recordList);
        void ShowFilteredRecords(List<T> recordList);
        void AddRecord();
        void EditSelectedRecord();
        void DeleteSelectedRecord();
    }
}
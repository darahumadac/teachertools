using System.Collections.Generic;

namespace TeacherTools.Forms
{
    public interface IMainView<T>
    {
        void ShowAllRecords();
        void ShowAllRecords(string[] excludeColumns);
        void ShowFilteredRecords(string[] excludeColumns, List<T> recordList);
        void ShowFilteredRecords(List<T> recordList);
        void AddRecord();
        void EditRecord();
        void DeleteRecord();
    }
}
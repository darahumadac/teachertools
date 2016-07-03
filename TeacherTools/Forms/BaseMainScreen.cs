using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Resources;
using System.Text;
using System.Threading.Tasks;
using System.Web.UI.WebControls;
using System.Windows.Forms;
using TeacherTools.Repositories;

namespace TeacherTools.Forms
{
    public partial class BaseMainScreen<T> : Form, IMainView<T>
    {
        private readonly DataRepository _appDataRepository;
        private readonly ResourceManager _resource;
        private readonly IRecordManager<T> _recordManager;
        private readonly Dictionary<FormViewMode, Form> _childForms;
        
        public BaseMainScreen(ResourceManager resource, IRecordManager<T> recordManager, 
            Dictionary<FormViewMode, Form> childForms)
        {
            _resource = resource;
            _recordManager = recordManager;
            _childForms = childForms;

            InitializeComponent();
        }

        protected virtual void resetBtn_Click(object sender, EventArgs e)
        {
            ShowAllRecords();
        }

        public void ShowAllRecords(string[] excludeColumns)
        {
            List<T> recordList = _recordManager.GetAllRecords();
            bindDataAndDispalyRecordCount(recordList);
            removeColumns(excludeColumns);
        }

        private void bindDataAndDispalyRecordCount(List<T> recordList)
        {
            baseGridView.DataSource = recordList;
            shownRecordsLbl.Text = String.Format("{0} records shown", recordList.Count);
        }

        private void removeColumns(string[] excludeColumns)
        {
            foreach (var column in excludeColumns)
            {
                baseGridView.Columns.Remove(column);
            }
        }

        public void ShowFilteredRecords(string[] excludeColumns, List<T> recordList)
        {
            bindDataAndDispalyRecordCount(recordList);
            removeColumns(excludeColumns);
        }

        public void ShowAllRecords()
        {
            List<T> recordList = _recordManager.GetAllRecords();
            bindDataAndDispalyRecordCount(recordList);
        }

        public void ShowFilteredRecords(List<T> recordList)
        {
            bindDataAndDispalyRecordCount(recordList);
        }

        public void AddRecord()
        {
            getAndShowForm(FormViewMode.Insert);
        }

        private void getAndShowForm(FormViewMode viewMode)
        {
            Form formToShow = _childForms[viewMode];
            formToShow.Show();
        }

        public void EditRecord()
        {
            getAndShowForm(FormViewMode.Edit);
        }

        public void DeleteRecord()
        {
            T selectedRecord = (T)baseGridView.SelectedRows[0].DataBoundItem;
            
            DialogResult confirmResult = MessageBox.Show(_resource.GetString("DeleteConfirmMsg"),
                _resource.GetString("DeleteConfirmCaption"),
                MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

            if (confirmResult == DialogResult.Yes)
            {
                _recordManager.Delete(selectedRecord);

                MessageBox.Show(_resource.GetString("DeleteSuccessMsg"),
                    _resource.GetString("DeleteSuccessCaption"),
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        

    }
}

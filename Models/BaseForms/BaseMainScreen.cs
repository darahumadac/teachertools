using System;
using System.Collections.Generic;
using System.Reflection;
using System.Resources;
using System.Windows.Forms;
using Models.Repositories;

namespace Models.BaseForms
{
    public partial class BaseMainScreen<T> : Form, IMainView<T> where T : class
    {
        protected readonly ResourceManager _resource;
        protected readonly BaseManager<T> _recordManager;
        private readonly Type _childForm;
        private Type[] _addRecordChildFormConstructor;
        private Type[] _editRecordChildFormConstructor;
        private string[] _excludedColumns;

        public string[] ExcludedColumns
        {
            get
            {
                if (_excludedColumns == null)
                {
                    return new string[0];
                }
                return _excludedColumns;
            }

            set { _excludedColumns = value; }
        }

        public BaseMainScreen(ResourceManager resource, BaseManager<T> recordManager, Type childFormType)
        {
            _resource = resource;
            _recordManager = recordManager;
            _childForm = childFormType;

            InitializeTypesForChildFormConstructor();
            InitializeComponent();
        }

        private void InitializeTypesForChildFormConstructor()
        {
            _addRecordChildFormConstructor = new Type[3];
            _addRecordChildFormConstructor[0] = _recordManager.GetType();
            _addRecordChildFormConstructor[1] = GetType();
            _addRecordChildFormConstructor[2] = typeof(ResourceManager);

            int addRecordConstructorTypesCount = _addRecordChildFormConstructor.Length;
            int editRecordConstructorTypesCount = addRecordConstructorTypesCount + 1;

            _editRecordChildFormConstructor = new Type[editRecordConstructorTypesCount];

            for (int i = 0; i < addRecordConstructorTypesCount; i++)
            {
                _editRecordChildFormConstructor[i] = _addRecordChildFormConstructor[i];
            }
            _editRecordChildFormConstructor[editRecordConstructorTypesCount - 1] = typeof(T);
        }

        protected override void OnActivated(EventArgs e)
        {
            DisplayAllRecords();
            base.OnActivated(e);
        }

        private void DisplayAllRecords()
        {
            if (ExcludedColumns.Length > 0)
            {
                ShowAllRecords(ExcludedColumns);
            }
            else
            {
                ShowAllRecords();
            }
        }

        public void ShowAllRecords()
        {
            List<T> recordList = _recordManager.GetAllRecords();
            bindDataAndDisplayRecordCount(recordList);
        }

        public void ShowAllRecords(string[] excludeColumns)
        {
            List<T> recordList = _recordManager.GetAllRecords();
            bindDataAndDisplayRecordCount(recordList);
            removeColumns(excludeColumns);
        }

        protected virtual void resetBtn_Click(object sender, EventArgs e)
        {
            DisplayAllRecords();
        }

        private void bindDataAndDisplayRecordCount(List<T> recordList)
        {
            baseGridView.DataSource = recordList;
            shownRecordsLbl.Text = String.Format("{0} of {1} records shown", 
                recordList.Count, _recordManager.TotalRecordCount);
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
            bindDataAndDisplayRecordCount(recordList);
            removeColumns(excludeColumns);
        }

        public void ShowFilteredRecords(List<T> recordList)
        {
            bindDataAndDisplayRecordCount(recordList);
        }

        private void addRecordBtn_Click(object sender, EventArgs e)
        {
            AddRecord();
        }

        public void AddRecord()
        {
            ConstructorInfo addRecordConstructorInfo = _childForm.GetConstructor(_addRecordChildFormConstructor);

            Form addForm = (Form)addRecordConstructorInfo.Invoke(new object[] { _recordManager, this, _resource });
            addForm.Show();

        }

        private void editRecordBtn_Click(object sender, EventArgs e)
        {
            EditSelectedRecord();
        }

        public void EditSelectedRecord()
        {
            T selectedRecord = (T)baseGridView.SelectedRows[0].DataBoundItem;

            ConstructorInfo editRecordConstructorInfo = _childForm.GetConstructor(_editRecordChildFormConstructor);

            Form editForm = (Form)editRecordConstructorInfo.Invoke(new object[] { _recordManager, this, _resource, selectedRecord });
            editForm.Show();
        }

        private void deleteRecordBtn_Click(object sender, EventArgs e)
        {
            DeleteSelectedRecord();
        }

        public void DeleteSelectedRecord()
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

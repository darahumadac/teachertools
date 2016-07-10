using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Resources;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Models.AppModels;
using Models.BaseForms;
using Models.Repositories;
using TeacherTools.Repositories;
using TeacherTools.Utils;

namespace TeacherTools.Forms
{
    public partial class StudentMainScreen : BaseMainScreen<Student>
    {
        private int _validInputCount;
        private bool _willSearchByStudentInfo;
        private StudentManager _studentManager;
        private List<Control> _searchControlsCanDisable;

        public StudentMainScreen(ResourceManager resource, BaseManager<Student> recordManager, Type childFormType)
            : base(resource, recordManager, childFormType)
        {
            InitializeComponent();

            _studentManager = (StudentManager)_recordManager;
            string[] excludedColumns = new string[2];
            excludedColumns[0] = "StudentId";
            excludedColumns[1] = "Name";

            ExcludedColumns = excludedColumns;

            _willSearchByStudentInfo = true;
            _searchControlsCanDisable = GetSearchControlsExcept(studentNoTxt);

            
        }

        private List<Control> GetSearchControlsExcept(Control control)
        {
            List<Control> searchControls = new List<Control>();
            searchControls.AddRange(GetControlsFromContainer(searchGroupBox, typeof(TextBox)));
            searchControls.AddRange(GetControlsFromContainer(studentNameSearchGroupBox, typeof(TextBox)));
            searchControls.AddRange(GetControlsFromContainer(batchInfoSearchGroupBox, typeof(TextBox)));
            searchControls.AddRange(GetControlsFromContainer(batchInfoSearchGroupBox, typeof(NumericUpDown)));

            searchControls.Remove(control);

            return searchControls;
        }

        private void searchBtn_Click(object sender, EventArgs e)
        {
            _validInputCount = 0;
            if (ValidateChildren() && _validInputCount == 1)
            {
                List<Student> studentResult = new List<Student>();

                if (_willSearchByStudentInfo)
                {
                    Name searchName = new Name(firstNameTxt.Text, middleNameTxt.Text, lastNameTxt.Text);
                    Student searchedStudent = new Student(searchName, (int)gradeLevelNum.Value, sectionTxt.Text);

                    studentResult.AddRange(_studentManager.SearchByProfile(searchedStudent));
                }
                else
                {
                    Student matchedStudent = _studentManager.SearchByStudentNumber(studentNoTxt.Text);

                    if (!matchedStudent.StudentId.Equals(GlobalConstants.STUDENT_DOES_NOT_EXIST))
                    {
                        studentResult.Add(matchedStudent);
                    }

                }

                ShowFilteredRecords(ExcludedColumns, studentResult);
                
            }
        }

        protected override void resetBtn_Click(object sender, EventArgs e)
        {
            base.resetBtn_Click(sender, e);
            clearBtn_Click(this, e);
        }

        private void clearBtn_Click(object sender, EventArgs e)
        {
            ResetFormControls(searchGroupBox, typeof(TextBox));
            ResetStudentInfoSearchControls();
        }

        private void ResetFormControls(GroupBox groupBoxContainer, Type typeOfControl)
        {
            List<Control> controlsToReset = GetControlsFromContainer(groupBoxContainer, typeOfControl);

            foreach (Control control in controlsToReset)
            {
                control.ResetText();
            }
        }

        private void ResetFormControls(GroupBox groupBoxContainer, Type typeOfControl, string defaultValue)
        {
            List<Control> controlsToReset = GetControlsFromContainer(groupBoxContainer, typeOfControl);

            foreach (Control control in controlsToReset)
            {
                control.ResetText();
                control.Text = defaultValue;
            }
        }

        private void ResetStudentInfoSearchControls()
        {
            ResetFormControls(studentNameSearchGroupBox, typeof(TextBox));
            ResetFormControls(batchInfoSearchGroupBox, typeof(NumericUpDown), gradeLevelNum.Minimum.ToString());
            ResetFormControls(batchInfoSearchGroupBox, typeof(TextBox));
        }

        private List<Control> GetControlsFromContainer(GroupBox groupBoxContainer, Type typeOfControl)
        {
            List<Control> controls = new List<Control>();

            foreach (Control control in groupBoxContainer.Controls)
            {
                Type controlType = control.GetType();
                if (controlType == typeOfControl)
                {
                    controls.Add(control);
                }
            }

            return controls;
        }

        private void studentNoTxt_TextChanged(object sender, EventArgs e)
        {
            if (_willSearchByStudentInfo && !InputValidator.IsEmpty(studentNoTxt.Text))
            {
                ResetStudentInfoSearchControls();
                EnableControls(false, _searchControlsCanDisable);
                _willSearchByStudentInfo = false;
            }
            else if (!_willSearchByStudentInfo && InputValidator.IsEmpty(studentNoTxt.Text))
            {
                EnableControls(true, _searchControlsCanDisable);
                _willSearchByStudentInfo = true;
            }

        }

        private void EnableControls(bool isEnabled, List<Control> controls)
        {
            foreach (Control control in controls)
            {
                control.Enabled = isEnabled;
            }
        }

        private void studentNoTxt_Validating(object sender, CancelEventArgs e)
        {
            if (!InputValidator.IsNumeric(studentNoTxt.Text) && !InputValidator.IsEmpty(studentNoTxt.Text))
            {
                studentNoError.SetError(studentNoTxt, _resource.GetString("StudentNoNumericMsg"));
            }
            else
            {
                _validInputCount++;
                studentNoError.Clear();
            }
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Resources;
using System.Web.UI.WebControls;
using System.Windows.Forms;
using TeacherTools.Models;
using TeacherTools.Repositories;
using TeacherTools.Utils;
using TextBox = System.Windows.Forms.TextBox;

namespace TeacherTools.Forms
{
    //TODO: Add paging for student list
    public partial class StudentScreen : Form
    {
        private StudentManager _studentManager;
        private bool _willSearchByStudentInfo;
        private List<Control> _searchControlsCanDisable;
        private int _validInputCount;
        private ResourceManager _resource;

        public StudentScreen() { }
        public StudentScreen(DataRepository appDataRepository, ResourceManager resource)
        {
            InitializeComponent();

            IRepository<Student> studentRepository = (IRepository<Student>)appDataRepository;
            _studentManager = new StudentManager(studentRepository);
            _resource = resource;

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

        private void StudentScreen_Load(object sender, EventArgs e)
        {
            ShowAllStudents();
        }

        private void ShowAllStudents()
        {
            List<Student> studentList = _studentManager.GetAllStudents();
            ShowStudentList(studentList);
        }

        private void ShowStudentList(List<Student> studentList)
        {
            studentGridView.DataSource = studentList;
            studentGridView.Columns.Remove("StudentId");
            studentGridView.Columns.Remove("Name");

            shownRecordsLbl.Text = String.Format("{0} records shown", studentList.Count);
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

                ShowStudentList(studentResult);
            }
            
        }

        private void resetBtn_Click(object sender, EventArgs e)
        {
            ShowAllStudents();
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

        private void ResetFormControls(GroupBox groupBoxContainer, Type typeOfControl, string defaultValue)
        {
            List<Control> controlsToReset = GetControlsFromContainer(groupBoxContainer, typeOfControl);

            foreach (Control control in controlsToReset)
            {
                control.ResetText();
                control.Text = defaultValue;
            }
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

        private void addStudentBtn_Click(object sender, EventArgs e)
        {
            StudentInfoScreen studentInfoScreen = new StudentInfoScreen(_studentManager, this, _resource);
            studentInfoScreen.Show();
        }

        private void studentNoTxt_Validating(object sender, System.ComponentModel.CancelEventArgs e)
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

        private void editStudentBtn_Click(object sender, EventArgs e)
        {
            Student selectedStudent = (Student)studentGridView.SelectedRows[0].DataBoundItem;
            StudentInfoScreen studentInfoScreen = new StudentInfoScreen(_studentManager, this, _resource, selectedStudent);
            studentInfoScreen.Show();
        }

        private void deleteStudentBtn_Click(object sender, EventArgs e)
        {
            Student selectedStudent = (Student)studentGridView.SelectedRows[0].DataBoundItem;

            DialogResult confirmResult = MessageBox.Show(_resource.GetString("DeleteConfirmMsg"),
                _resource.GetString("DeleteConfirmCaption"),
                MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

            if (confirmResult == DialogResult.Yes)
            {
                _studentManager.Delete(selectedStudent);
                MessageBox.Show(_resource.GetString("DeleteSuccessMsg"),
                    _resource.GetString("DeleteSuccessCaption"), 
                    MessageBoxButtons.OK, MessageBoxIcon.Information);

            }
        }

    }
}

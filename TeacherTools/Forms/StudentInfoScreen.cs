using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Entity.Infrastructure;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Resources;
using System.Text;
using System.Threading.Tasks;
using System.Web.UI.WebControls;
using System.Windows.Forms;
using TeacherTools.Models;
using TeacherTools.Properties;
using TeacherTools.Repositories;
using TeacherTools.Utils;
using TextBox = System.Windows.Forms.TextBox;

namespace TeacherTools.Forms
{
    public partial class StudentInfoScreen : Form
    {
        private readonly StudentManager _studentManager;
        private readonly StudentScreen _studentScreen;
        private readonly ResourceManager _resource;
        private readonly FormViewMode _formViewMode;
        private int _validInputCount;
        private Student _student;
        

        public StudentInfoScreen(StudentManager studentManager, StudentScreen studentScreen, ResourceManager resource)
        {
            _studentManager = studentManager;
            _studentScreen = studentScreen;
            _resource = resource;
            _formViewMode = FormViewMode.Insert;
            InitializeComponent();
                
        }

        public StudentInfoScreen(StudentManager studentManager, StudentScreen studentScreen, ResourceManager resource, Student selectedStudent)
        {
            _studentManager = studentManager;
            _studentScreen = studentScreen;
            _formViewMode = FormViewMode.Edit;
            _resource = resource;
            _student = selectedStudent;
            InitializeComponent();

            InitializeEditStudentScreen();
            InitializeStudentInfo(_student);
            
        }

        private void InitializeEditStudentScreen()
        {
            Text = _resource.GetString("EditStudentScreenTitle");
            studentNoTxt.Enabled = false;
            addStudentBtn.Text = _resource.GetString("EditStudentSaveBtnText");
            ActiveControl = firstNameTxt;
        }

        private void InitializeStudentInfo(Student student)
        {
            studentNoTxt.Text = student.StudentNumber;
            firstNameTxt.Text = student.FirstName;
            middleNameTxt.Text = student.MiddleName;
            lastNameTxt.Text = student.LastName;
            gradeLevelNum.Value = student.GradeLevel;
            sectionTxt.Text = student.Section;
        }


        private void addEditStudentBtn_Click(object sender, EventArgs e)
        {
            _validInputCount = 0;

            if (_formViewMode == FormViewMode.Insert)
            {
                ValidateAndAddStudent();
            }
            else
            {
                ValidateAndUpdateStudent();
            }
            
        }

        private void ValidateAndAddStudent()
        {
            if (ValidateChildren() && _validInputCount == 5)
            {
                DialogResult dialogResult =
                    MessageBox.Show(_resource.GetString("AddStudentConfirmMsg"),
                                    _resource.GetString("AddStudentConfirmCaption"),
                                    MessageBoxButtons.OKCancel,
                                    MessageBoxIcon.Question);

                if (dialogResult == DialogResult.OK)
                {
                    _student = new Student(studentNoTxt.Text, firstNameTxt.Text,
                    lastNameTxt.Text, middleNameTxt.Text,
                    (int)gradeLevelNum.Value, sectionTxt.Text);

                    AddStudent(_student);
                }
            }
        }

        private void ValidateAndUpdateStudent()
        {
            if (ValidateChildren(ValidationConstraints.Enabled) && _validInputCount == 4)
            {
                _student.FirstName = firstNameTxt.Text;
                _student.MiddleName = middleNameTxt.Text;
                _student.LastName = lastNameTxt.Text;
                _student.GradeLevel = (int)gradeLevelNum.Value;
                _student.Section = sectionTxt.Text;

                UpdateStudent(_student);
            }
        }

        private void AddStudent(Student student)
        {
            try
            {
                _studentManager.AddStudent(student);
                _studentScreen.Activate();
                Dispose();
            }
            catch (DbUpdateException ex)
            {
                MessageBox.Show(ex.Message, _resource.GetString("AddStudentErrorCaption"),
                    MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
        }

        private void UpdateStudent(Student student)
        {
            try
            {
                _studentManager.UpdateStudentDetails(student);
                MessageBox.Show(_resource.GetString("EditStudentSuccessMsg"),
                    _resource.GetString("EditStudentSuccessCaption"),
                        MessageBoxButtons.OK, MessageBoxIcon.Information);

                _studentScreen.Activate();
                Dispose();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, _resource.GetString("EditStudentErrorCaption"),
                    MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
        }

        private void studentNoTxt_Validating(object sender, CancelEventArgs e)
        {
            if (!InputValidator.IsEmpty(studentNoTxt.Text) &&
            !InputValidator.IsNumeric(studentNoTxt.Text))
            {
                studentNumError.SetError(studentNoTxt, _resource.GetString("StudentNoNumericMsg"));
            }
            else if (InputValidator.IsEmpty(studentNoTxt.Text))
            {
                studentNumError.SetError(studentNoTxt, _resource.GetString("StudentNoRequiredMsg"));
            }
            else
            {
                _validInputCount++;
                studentNumError.Clear();
            }
            
        }

        private void firstNameTxt_Validating(object sender, CancelEventArgs e)
        {
            ValidateRequiredTextboxes(firstNameTxt, "First Name", firstNameError, e);
        }

        private void middleNameTxt_Validating(object sender, CancelEventArgs e)
        {
            ValidateRequiredTextboxes(middleNameTxt, "Middle Name", middleNameError, e);
        }

        private void lastNameTxt_Validating(object sender, CancelEventArgs e)
        {
            ValidateRequiredTextboxes(lastNameTxt, "Last Name", lastNameError, e);
        }

        private void sectionTxt_Validating(object sender, CancelEventArgs e)
        {
            ValidateRequiredTextboxes(sectionTxt, "Section", sectionError, e);
        }

        private void ValidateRequiredTextboxes(TextBox textbox, string fieldName, ErrorProvider errorProvider, CancelEventArgs e)
        {
            if (InputValidator.IsEmpty(textbox.Text))
            {
                errorProvider.SetError(textbox, 
                    String.Format(_resource.GetString("RequiredFieldsErrorMsg"), fieldName));
            }
            else
            {
                _validInputCount++;
                errorProvider.Clear();
            }
        }

        private void cancelBtn_Click(object sender, EventArgs e)
        {
            Dispose();
        }

        


    }
}

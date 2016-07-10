using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Resources;
using System.Text;
using System.Windows.Forms;
using Models.AppModels;
using Models.BaseForms;
using Models.Repositories;
using TeacherTools.Repositories;
using TeacherTools.Utils;

namespace TeacherTools.Forms
{
    public partial class SubjectMainScreen : BaseMainScreen<Subject>
    {
        private SubjectManager _subjectManager;
        private bool _willSearchTeacherName;


        public SubjectMainScreen(ResourceManager resource, BaseManager<Subject> recordManager, Type childFormType)
            : base(resource, recordManager, childFormType)
        {
            InitializeComponent();

            _subjectManager = (SubjectManager)_recordManager;
            string[] excludedColumns = new string[3];
            excludedColumns[0] = "SubjectId";
            excludedColumns[1] = "Class";
            excludedColumns[2] = "SubjectTeacher";

            _willSearchTeacherName = false;

            ExcludedColumns = excludedColumns;
        }

        private void searchBtn_Click(object sender, EventArgs e)
        {
            List<Subject> searchResults = _subjectManager.GetAllRecords();

            if (!IsTeacherNameEmpty() && !IsSubjectNameEmpty())
            {
                Name teacherName = new Name(firstNameTxt.Text, middleNameTxt.Text, lastNameTxt.Text);
                searchResults = _subjectManager.SearchBySubjectAndTeacher(subjectNameTxt.Text, teacherName);
            }
            else if (!IsSubjectNameEmpty())
            {
                searchResults = _subjectManager.SearchBySubjectName(subjectNameTxt.Text);
            }
            else if(!IsTeacherNameEmpty())
            {
                Name teacherName = new Name(firstNameTxt.Text, middleNameTxt.Text, lastNameTxt.Text);
                searchResults = _subjectManager.SearchByTeacherName(teacherName);
            }

            if (gradeLevelNum.Value > 0)
            {
                searchResults = searchResults.FindAll(s => s.GradeLevel == gradeLevelNum.Value);
            }

            if (!InputValidator.IsEmpty(sectionTxt.Text))
            {
                searchResults =
                    searchResults.FindAll(
                        s => s.Section.Equals(sectionTxt.Text, 
                            StringComparison.InvariantCultureIgnoreCase));
            }
           
            ShowFilteredRecords(searchResults);
        }

        private bool IsTeacherNameEmpty()
        {
            return (
                InputValidator.IsEmpty(firstNameTxt.Text) &&
                InputValidator.IsEmpty(middleNameTxt.Text) &&
                InputValidator.IsEmpty(lastNameTxt.Text)
            );
        }

        private bool IsSubjectNameEmpty()
        {
            return InputValidator.IsEmpty(subjectNameTxt.Text);
        }

        private void clearBtn_Click(object sender, EventArgs e)
        {
            ResetFormControls(searchGroupBox, typeof(TextBox));
            ResetTeacherInfoSearchControls();
        }

        private void ResetTeacherInfoSearchControls()
        {
            ResetFormControls(teacherNameSearchGroupBox, typeof(TextBox));
            ResetFormControls(batchInfoSearchGroupBox, typeof(NumericUpDown), gradeLevelNum.Minimum.ToString());
            ResetFormControls(batchInfoSearchGroupBox, typeof(TextBox));
        }

        protected override void resetBtn_Click(object sender, EventArgs e)
        {
            base.resetBtn_Click(sender, e);
            clearBtn_Click(sender, e);
        }

    }
}

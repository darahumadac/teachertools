using System;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using TeacherTools.Utils;

namespace Models.AppModels
{
    public class Student
    {
        public int StudentId { get; set; }
        [DisplayName("Student No.")]
        [Index(IsUnique = true)]
        [StringLength(10)]
        public string StudentNumber { get; set; }

        [DisplayName("Grade Level")]
        public int GradeLevel { get; set; }
        public string Section { get; set; }

        [DisplayName("First Name")]
        public string FirstName { get; set; }
        [DisplayName("Middle Name")]
        public string MiddleName { get; set; }
        [DisplayName("Last Name")]
        public string LastName { get; set; }

        public string Gender { get; set; }
        [DisplayName("Birth Date")]
        public DateTime BirthDate { get; set; }

        public Name Name
        {
            get
            {
                return new Name(FirstName, MiddleName, LastName);
            }
        }

        public Student()
        {
            StudentId = GlobalConstants.STUDENT_DOES_NOT_EXIST;
        }

        public Student(string studentNumber, string firstName, string lastName,
            string middleName, int gradeLevel, string section, string gender, DateTime birthDate)
        {
            StudentNumber = studentNumber;
            FirstName = firstName;
            LastName = lastName;
            MiddleName = middleName;
            GradeLevel = gradeLevel;
            Section = section;
            Gender = gender;
            BirthDate = birthDate;
        }

        public Student(Name studentName, int gradeLevel, string section)
        {
            StudentNumber = GlobalConstants.STUDENT_NUM_NOT_PROVIDED;
            FirstName = studentName.FirstName;
            LastName = studentName.LastName;
            MiddleName = studentName.MiddleName;
            GradeLevel = gradeLevel;
            Section = section;
        }
    }
}

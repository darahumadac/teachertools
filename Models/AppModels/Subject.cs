using System.Collections.Generic;
using System.ComponentModel;

namespace Models.AppModels
{
    public class Subject
    {
        public int SubjectId { get; set; }

        [DisplayName("Subject")]
        public string SubjectName { get; set; }

        [DisplayName("Teacher")]
        public virtual Teacher SubjectTeacher { get; set; }

        public virtual ClassInformation Class { get; set; }
        public List<SubjectRequirement> Requirements { get; set; }

        [DisplayName("Grade Level")]
        public int GradeLevel
        {
            get { return Class.GradeLevel; }
        }

        public string Section
        {
            get { return Class.Section; }
        }

        [DisplayName("Teacher First Name")]
        public string TeacherFirstName
        {
            get { return SubjectTeacher.FirstName; }
        }

        [DisplayName("Teacher Middle Name")]
        public string TeacherMiddleName
        {
            get { return SubjectTeacher.MiddleName; }
        }

        [DisplayName("Teacher Last Name")]
        public string TeacherLastName
        {
            get { return SubjectTeacher.LastName; }
        }


        public Subject()
        {
            
        }

        public Subject(string subjectName, Teacher teacher, ClassInformation classInformation)
        {
            SubjectName = subjectName;
            SubjectTeacher = teacher;
            Class = classInformation;
        }
    }
}

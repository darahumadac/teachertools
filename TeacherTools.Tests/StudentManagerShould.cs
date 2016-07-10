using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Models.AppModels;
using NUnit.Framework;
using TeacherTools.Repositories;

namespace TeacherTools.Tests
{
    [TestFixture]
    public class StudentManagerShould
    {
        private StudentManager _studentManager;
        private TeacherToolsDbContext _appDbContext;
        private string NO_NAME = String.Empty;

        public StudentManagerShould()
        {
            _appDbContext = new TeacherToolsDbContext();
            _studentManager = new StudentManager(new SqlRepository(_appDbContext));
        }

        private Student addTestStudent(string firstName, string middleName, string lastName,
            int gradeLevel, string section)
        {
            Student student = new Student()
            {
                FirstName = firstName,
                MiddleName = middleName,
                LastName = lastName,
                GradeLevel = gradeLevel,
                Section = section,
                StudentNumber = Guid.NewGuid().ToString().Substring(0, 10)
            };

            if (!isStudentExisting(student.StudentNumber))
            {
                _appDbContext.Students.Add(student);
                _appDbContext.SaveChanges();
            }

            return student;
        }

        private bool isStudentExisting(string studentNumber)
        {
            if (_appDbContext.Students.FirstOrDefault(s => s.StudentNumber == studentNumber) != null)
            {
                return true;
            }

            return false;
        }

        [Test]
        public void Not_Return_Student_If_No_Name_Match()
        {
            Name firstNameNoMatch = new Name("asdfghjkl", NO_NAME, NO_NAME);
            Name middleNameNoMatch = new Name(NO_NAME, "asdfghjkl", NO_NAME);
            Name lastNameNoMatch = new Name(NO_NAME, NO_NAME, "asdfghjkl");

            var firstNameNoMatchCount = _studentManager.SearchByName(firstNameNoMatch).Count();
            var middleNameNoMatchCount = _studentManager.SearchByName(middleNameNoMatch).Count();
            var lastNameNoMatchCount = _studentManager.SearchByName(lastNameNoMatch).Count();

            Assert.AreEqual(0, firstNameNoMatchCount);
            Assert.AreEqual(0, middleNameNoMatchCount);
            Assert.AreEqual(0, lastNameNoMatchCount);
        }

        [Test]
        public void Return_Students_If_Name_Contains_One_CompleteName_Only()
        {
            Student newStudent = addTestStudent("DarahOne", "FranciscoOne", "UmadacOne", 11, "Section 11");
            var firstNameOnly = new Name(newStudent.FirstName, NO_NAME, NO_NAME);
            var middleNameOnly = new Name(NO_NAME, newStudent.MiddleName, NO_NAME);
            var lastNameOnly = new Name(NO_NAME, NO_NAME, newStudent.LastName);

            var firstNameMatch = _studentManager.SearchByName(firstNameOnly).Count();
            var middleNameMatch = _studentManager.SearchByName(middleNameOnly).Count();
            var lastNameMatch = _studentManager.SearchByName(lastNameOnly).Count();

            Assert.AreEqual(1, firstNameMatch);
            Assert.AreEqual(1, middleNameMatch);
            Assert.AreEqual(1, lastNameMatch);
        }

        [Test]
        public void Return_Students_If_CombinationOfNames()
        {
            Student newStudent = addTestStudent("TestCombination", "CombinationTwo", "NamesTest", 10, "Section 10");

            var fullName = new Name(newStudent.FirstName, newStudent.MiddleName, newStudent.LastName);
            var firstLastOnly = new Name(newStudent.FirstName, NO_NAME, newStudent.LastName);
            var firstMiddleOnly = new Name(newStudent.FirstName, newStudent.MiddleName, NO_NAME);
            var middleLastOnly = new Name(NO_NAME, newStudent.MiddleName, newStudent.LastName);

            var fullNameMatch = _studentManager.SearchByName(fullName).Count();
            var firstLastMatch = _studentManager.SearchByName(firstLastOnly).Count();
            var firstMiddleMatch = _studentManager.SearchByName(firstMiddleOnly).Count();
            var middleLastMatch = _studentManager.SearchByName(middleLastOnly).Count();

            Assert.AreEqual(1, fullNameMatch);
            Assert.AreEqual(1, firstLastMatch);
            Assert.AreEqual(1, firstMiddleMatch);
            Assert.AreEqual(1, middleLastMatch);
        }

        [Test]
        public void Return_Students_If_Name_IsNotSameCase()
        {
            Student newStudent = addTestStudent("darah", "franCisCo", "uMADac", 11, "Section 11");
            var fullName = new Name(newStudent.FirstName.ToUpper(), newStudent.MiddleName, newStudent.LastName);

            var fullNameMatch =
                _studentManager.SearchByName(fullName).FirstOrDefault(s => s.StudentId.Equals(newStudent.StudentId));

            Assert.AreEqual(newStudent.StudentId, fullNameMatch.StudentId);
        }

        [Test]
        public void Return_Students_IfMatch_Name_Section_GradeLevel()
        {
            Student newStudent1 = addTestStudent("My", "Test", "Student", 11, "Section 11");
            Student newStudent2 = addTestStudent("My2", "Test2", "Student1", 11, "Section 11");

            Student searchStudent1 = new Student(newStudent1.Name, newStudent1.GradeLevel, newStudent1.Section);
            Student searchStudent2 = new Student(newStudent2.Name, newStudent2.GradeLevel, newStudent2.Section);

            List<Student> studentMatch = _studentManager.SearchByProfile(searchStudent1);

            Assert.IsNotNull(studentMatch.FirstOrDefault(s => s.StudentId == newStudent1.StudentId));
            Assert.IsNotNull(studentMatch.FirstOrDefault(s => s.StudentId == newStudent2.StudentId));
        }

        [Test]
        public void Return_Students_SearchProfile_IfMatch_Name_Only()
        {
            Student newStudent1 = addTestStudent("My", "Test", "Student", 11, "Section 11");

            Student searchStudent1 = new Student(newStudent1.Name, 0, string.Empty);

            List<Student> studentMatch = _studentManager.SearchByProfile(searchStudent1);

            Assert.IsNotNull(studentMatch.FirstOrDefault(s => s.StudentId == newStudent1.StudentId));
            
        }

        

    }
}

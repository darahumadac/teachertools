using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Models.AppModels;
using Models.Repositories;
using NUnit.Framework;
using TeacherTools.Repositories;

namespace TeacherTools.Tests
{
    [TestFixture]
    public class SubjectManagerShould
    {
        private TeacherToolsDbContext _appDbContext;
        private IRepository<Subject> _appRepository; 
        private SubjectManager _subjectManager;
        private string NO_NAME = string.Empty;

        public SubjectManagerShould()
        {
            _appDbContext = new TeacherToolsDbContext();
            _appRepository = new SqlRepository(_appDbContext);
            _subjectManager = new SubjectManager(_appRepository);

            removeAllSubjects();
            addTestSubjects();
        }

        private void removeAllSubjects()
        {
            _appDbContext.Subjects.RemoveRange(_appDbContext.Subjects);
            _appDbContext.SaveChanges();
        }

        private void addTestSubjects()
        {
            for (int i = 1; i <= 5; i++)
            {
                Teacher teacher = new Teacher(i + " Teacher", "Test", "LastName");
                ClassInformation classInformation = new ClassInformation(i, i.ToString());

                _appDbContext.Subjects.Add(new Subject("Subject " + i, teacher, classInformation));
            }

            _appDbContext.SaveChanges();
        }

        [Test]
        public void Return_Subject_When_SearchBySubjectName_Only()
        {
            string subjectNameOnly = "Subject 1";
            Name teacherName = new Name(NO_NAME,NO_NAME,NO_NAME);

            List<Subject> matchedSubjects = 
                _subjectManager.SearchBySubjectName(subjectNameOnly);

            Assert.AreEqual(1, matchedSubjects.Count);
        }

        [Test]
        public void Return_Subject_When_SearchByTeacherName_Only()
        {
            string subjectName = NO_NAME;
            Name teacherNameOnly = new Name("1 Teacher", NO_NAME, NO_NAME);

            List<Subject> matchedSubjects =
                _subjectManager.SearchByTeacherName(teacherNameOnly);

            Assert.AreEqual(1, matchedSubjects.Count);
        }

        [Test]
        public void Return_Subject_When_SearchBySubjectAndTeacherName()
        {
            string subjectName = "Subject 1";
            Name teacherName = new Name("1 Teacher", NO_NAME, NO_NAME);

            List<Subject> matchedSubjects =
                _subjectManager.SearchBySubjectAndTeacher(subjectName, teacherName);

            Assert.AreEqual(1, matchedSubjects.Count);
        }

        [Test]
        public void Return_Subject_When_SearchBySubjectAndTeacherName_NoMatch()
        {
            string subjectName = "Subject 15";
            Name teacherName = new Name("1 Teacher", NO_NAME, NO_NAME);

            List<Subject> matchedSubjects =
                _subjectManager.SearchBySubjectAndTeacher(subjectName, teacherName);

            Assert.AreEqual(0, matchedSubjects.Count);
        }
    }
}

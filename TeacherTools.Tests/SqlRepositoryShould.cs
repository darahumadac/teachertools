using System;
using System.Collections.Generic;
using System.Linq;
using System.Data.Entity;
using System.Data.Entity.Infrastructure;
using System.Runtime.InteropServices;
using System.Security.Cryptography;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;
using Models.AppModels;
using NUnit.Framework;
using TeacherTools.Repositories;


namespace TeacherTools.Tests
{
    [TestFixture]
    public class SqlRepositoryShould
    {
        private TeacherToolsDbContext _appDbContext;
        private SqlRepository _sqlRepository;
        private Student testStudent;
        private string NO_NAME = String.Empty;

        public SqlRepositoryShould()
        {
            initialize();
            testStudent = addTestStudent();
        }

        private void initialize()
        {
            _appDbContext = new TeacherToolsDbContext();
            _sqlRepository = new SqlRepository(_appDbContext);

            removeAllDatabaseRecords();
            
        }

        private void removeAllDatabaseRecords()
        {
            _appDbContext.Students.RemoveRange(_appDbContext.Students);
            _appDbContext.SaveChanges();
        }

        private Student addTestStudent()
        {
            Student testStudent = new Student()
            {
                FirstName =  "Test",
                MiddleName = "Default",
                LastName = "LastNameStudent",
                GradeLevel = 12,
                Section = "Section 12",
                StudentNumber = Guid.NewGuid().ToString().Substring(0,10),
                Gender = "Female",
                BirthDate = new DateTime(1992, 6, 28)
            };

            _appDbContext.Students.Add(testStudent);
            _appDbContext.SaveChanges();

            return testStudent;
        }

       

        
        [Test]
        public void Get_All_Records_From_Database()
        {
            addTestStudent();

            var recordCount = _sqlRepository.GetAll().Count();
            Assert.IsFalse(recordCount == 0);
        }

        [Test]
        public void Add_Student_To_Database()
        {
            string newStudentNumber = new Guid().ToString().Substring(0,10);

            var newStudent = new Student(newStudentNumber, 
                "Darah", "Umadac", "Francisco", 12, "Belardo", "Female", new DateTime(1992, 6, 28));
            _sqlRepository.Add(newStudent);

            var retrievedStudent = _appDbContext.Students.FirstOrDefault(s => s.StudentNumber == newStudentNumber);
            Assert.NotNull(retrievedStudent);

        }


        [Test]
        public void Update_Student_Details()
        {
            var existingStudent = _appDbContext.Students.First();
            existingStudent.FirstName = "Updated Darah";
            existingStudent.Section = "S23";

            _sqlRepository.Update(existingStudent);

            existingStudent = _appDbContext.Students.Find(existingStudent.StudentId);
            Assert.AreEqual("Updated Darah", existingStudent.FirstName);
            Assert.AreEqual("S23", existingStudent.Section);
        }

        [Test]
        public void Return_0_StudentId_When_Searched_StudentNum_Not_Found()
        {
            var retrievedStudent = _sqlRepository.GetByIdentifier("");
            Assert.AreEqual(0, retrievedStudent.StudentId);
        }

        [Test]
        public void Return_Student_When_ValidStudent_Is_Searched_By_StudentNumber()
        {
            var existingStudent = _appDbContext.Students.First();

            var retrievedStudent = _sqlRepository.GetByIdentifier(existingStudent.StudentNumber);
            Assert.AreNotEqual(0, retrievedStudent.StudentId);
        }

        [Test]
        public void Not_Add_Students_With_Existing_Student_Numbers()
        {
            var existingStudent = _appDbContext.Students.First();
            Assert.Throws<DbUpdateException>(() => _sqlRepository.Add(existingStudent));
        }

        [Test]
        public void Remove_Student()
        {
            var existingStudent = _appDbContext.Students.First();

            _sqlRepository.Delete(existingStudent);

            var searchedStudent = _appDbContext.Students.Find(existingStudent.StudentId);
            Assert.IsNull(searchedStudent);
        }

    }
}

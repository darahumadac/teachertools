using System;
using System.Collections.Generic;
using System.Linq;
using TeacherTools.Forms;
using TeacherTools.Models;
using TeacherTools.Utils;

namespace TeacherTools.Repositories
{
    public class StudentManager //: IRecordManager<Student>
    {
        private readonly IRepository<Student> _studentRepository;

        public StudentManager(IRepository<Student> studentRepository)
        {
            _studentRepository = studentRepository;
        }

        public void AddStudent(Student student)
        {
            _studentRepository.Add(student);
        }

        public void UpdateStudentDetails(Student student)
        {
            _studentRepository.Update(student);
        }

        //public void Add(Student entity)
        //{
        //    _studentRepository.Add(entity);
        //}

        //public void Update(Student entity)
        //{
        //    _studentRepository.Update(entity);
        //}

        //public void Delete(Student entity)
        //{
        //    _studentRepository.Delete(entity);
        //}

        public void Delete(Student student)
        {
            _studentRepository.Delete(student);
        }

        public List<Student> GetAllRecords()
        {
            return _studentRepository.GetAll();
        }

        public Student SearchByStudentNumber(string studentNumber)
        {
            return _studentRepository.GetByIdentifier(studentNumber);
        }
        
        public List<Student> SearchByProfile(Student student)
        {
            List<Student> searchResults;
            List<Student> matchedStudentNames = SearchByName(student.Name);

            if (student.GradeLevel > 0)
            {
                searchResults = matchedStudentNames.FindAll(s => s.GradeLevel == student.GradeLevel);
            }
            else
            {
                searchResults = matchedStudentNames;
            }

            if (!InputValidator.IsEmpty(student.Section))
            {
                searchResults = searchResults.FindAll(s => s.Section.Equals(student.Section, StringComparison.InvariantCultureIgnoreCase));
            }


            return searchResults;
        }

        public List<Student> SearchByName(Name name)
        {

            List<Student> searchResults =
                _studentRepository.GetAll().Where(s => isSubstringFound(name.FirstName, s.Name.FirstName)
                                                       && isSubstringFound(name.MiddleName, s.Name.MiddleName)
                                                       && isSubstringFound(name.LastName, s.Name.LastName)).ToList();

            return searchResults;
        }

        private bool isSubstringFound(string substring, string searchedString)
        {
            int foundIndex = searchedString.IndexOf(substring, StringComparison.OrdinalIgnoreCase);

            if (foundIndex >= 0)
            {
                return true;
            }

            return false;
        }

        public List<Student> GetAllStudents()
        {
            return _studentRepository.GetAll();
        }

        

    }

}

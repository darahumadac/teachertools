using System;
using System.Collections.Generic;
using System.Linq;
using Models.AppModels;
using Models.Repositories;
using TeacherTools.Utils;

namespace TeacherTools.Repositories
{
    public class StudentManager : BaseManager<Student>
    {
        public StudentManager(IRepository<Student> studentRepository) 
            : base(studentRepository)
        {
            
        }

        public Student SearchByStudentNumber(string studentNumber)
        {
            return Repository.GetByIdentifier(studentNumber).First();
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
                Repository.GetAll().Where(s 
                    => InputValidator.IsSubstringFound(name.FirstName, s.Name.FirstName)
                    && InputValidator.IsSubstringFound(name.MiddleName, s.Name.MiddleName)
                    && InputValidator.IsSubstringFound(name.LastName, s.Name.LastName)).ToList();

            return searchResults;
        }

    }

}

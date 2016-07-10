using System.Collections.Generic;
using System.Linq;
using Models.AppModels;
using Models.Repositories;
using TeacherTools.Utils;

namespace TeacherTools.Repositories
{
    public class SubjectManager : BaseManager<Subject>
    {
        public SubjectManager(IRepository<Subject> repository) 
            : base(repository)
        {
        }

        public List<Subject> SearchBySubjectAndTeacher(string subjectName, Name teacherName)
        {
            List<Subject> subjectResults_Name = SearchBySubjectName(subjectName);
            List<Subject> subjectResults_Teacher = SearchByTeacherName(teacherName);

            return subjectResults_Teacher.Intersect(subjectResults_Name).ToList();
        }

        public List<Subject> SearchBySubjectName(string subjectName)
        {
            return Repository.GetByIdentifier(subjectName);
        }

        public List<Subject> SearchByTeacherName(Name teacherName)
        {
            List<Subject> searchResults =
                Repository.GetAll().Where(s 
                    => InputValidator.IsSubstringFound(teacherName.FirstName, s.TeacherFirstName)
                    && InputValidator.IsSubstringFound(teacherName.MiddleName, s.TeacherMiddleName)
                    && InputValidator.IsSubstringFound(teacherName.LastName, s.TeacherLastName)).ToList();

            return searchResults;
        }
       
    }
}
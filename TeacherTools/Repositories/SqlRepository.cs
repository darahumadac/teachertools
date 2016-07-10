using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Data.Entity.Infrastructure;
using System.Linq;
using Models.AppModels;
using Models.Repositories;

namespace TeacherTools.Repositories
{
    public class SqlRepository : DataRepository, IRepository<Student>, IRepository<Models.AppModels.Subject>
    {
        private readonly TeacherToolsDbContext _appDbContext;


        public SqlRepository(TeacherToolsDbContext appDbContext)
        {
            _appDbContext = appDbContext;

        }

        public void Add(Student entity)
        {
            try
            {
                _appDbContext.Students.Add(entity);
                _appDbContext.SaveChanges();
            }
            catch (DbUpdateException ex)
            {
                _appDbContext.Students.Remove(entity);
                throw new DbUpdateException(String.Format("Student with Student Number {0} " +
                                                            "is already in the system.", entity.StudentNumber), ex);

            }

        }

        public void Update(Student student)
        {
            _appDbContext.Entry(student).State = EntityState.Modified;
            _appDbContext.SaveChanges();
        }

        public void Delete(Student student)
        {
            _appDbContext.Students.Remove(student);
            _appDbContext.SaveChanges();
        }

        public void Add(Subject entity)
        {
            _appDbContext.Subjects.Add(entity);
            _appDbContext.SaveChanges();
        }

        public void Update(Subject entity)
        {
            _appDbContext.Entry(entity).State = EntityState.Modified;
            _appDbContext.SaveChanges();
        }

        public void Delete(Subject entity)
        {
            _appDbContext.Subjects.Remove(entity);
            _appDbContext.SaveChanges();
        }

        List<Subject> IRepository<Subject>.GetAll()
        {
            return _appDbContext.Subjects.ToList();
        }

        List<Subject> IRepository<Subject>.GetByIdentifier(string subjectName)
        {
            List<Subject> searchResult = 
                _appDbContext.Subjects.Where(
                    s => s.SubjectName.Equals(subjectName, 
                        StringComparison.InvariantCultureIgnoreCase)).ToList();

            return searchResult;
        }

        public List<Student> GetAll()
        {
            return _appDbContext.Students.ToList();
        }

        public List<Student> GetByIdentifier(string studentNumber)
        {
            List<Student> searchResult = new List<Student>();
            var student = _appDbContext.Students.FirstOrDefault(s => s.StudentNumber == studentNumber);

            if (student != null)
            {
                searchResult.Add(student);
            }
            else
            {
                searchResult.Add(new Student());
            }
            return searchResult;
        }

    }
}

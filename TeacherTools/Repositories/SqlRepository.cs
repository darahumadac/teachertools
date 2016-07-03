using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Data.Entity.Infrastructure;
using System.Linq;
using TeacherTools.Models;

namespace TeacherTools.Repositories
{
    public class SqlRepository : DataRepository, IRepository<Student>, IRepository<Subject>
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
            throw new NotImplementedException();
        }

        public void Update(Subject entity)
        {
            throw new NotImplementedException();
        }

        public void Delete(Subject entity)
        {
            throw new NotImplementedException();
        }

        List<Subject> IRepository<Subject>.GetAll()
        {
            throw new NotImplementedException();
        }

        Subject IRepository<Subject>.GetByIdentifier(string numberOrCode)
        {
            throw new NotImplementedException();
        }

        public List<Student> GetAll()
        {
            return _appDbContext.Students.ToList();
        }

        public Student GetByIdentifier(string numberOrCode)
        {
            var student = _appDbContext.Students.FirstOrDefault(s => s.StudentNumber == numberOrCode);

            if (student != null)
            {
                return student;
            }

            return new Student();
        }

    }
}

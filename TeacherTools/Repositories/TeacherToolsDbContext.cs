using System.Data.Entity;
using Models.AppModels;

namespace TeacherTools.Repositories
{
    public class TeacherToolsDbContext : DbContext
    {
        public virtual DbSet<Student> Students { get; set; }
        public virtual DbSet<Teacher> Teachers { get; set; }
        public virtual DbSet<ClassInformation> Classes { get; set; }
        public virtual DbSet<Subject> Subjects { get; set; }

        public TeacherToolsDbContext()
            : base("name=TeacherToolsDbContext")
        {
        }

        public TeacherToolsDbContext(string connectionName) : base(connectionName)
        {
        }

    }
  
}
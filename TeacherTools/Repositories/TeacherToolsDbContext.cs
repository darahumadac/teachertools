using System.Data.Entity;
using TeacherTools.Models;

namespace TeacherTools.Repositories
{
    public class TeacherToolsDbContext : DbContext
    {
        public virtual DbSet<Student> Students { get; set; }

        public TeacherToolsDbContext()
            : base("name=TeacherToolsDbContext")
        {
        }

        public TeacherToolsDbContext(string connectionName) : base(connectionName)
        {
        }

    }
  
}
using System.Collections.Generic;
using Models.AppModels;
using TeacherTools.Repositories;

namespace TeacherTools.Migrations
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;

    internal sealed class Configuration : DbMigrationsConfiguration<TeacherToolsDbContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = false;
        }

        protected override void Seed(TeacherToolsDbContext context)
        {
            
            for (int i = 0; i < 5; i++)
            {
                context.Students.AddOrUpdate(
                        new Student(i.ToString(),
                                        "Student" + i,
                                        i + "surname",
                                        "middleName" + i,
                                        i,
                                        "Section " + i)
                    );
            }

           
        }
    }
}

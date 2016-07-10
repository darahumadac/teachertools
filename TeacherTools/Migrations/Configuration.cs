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
                                        "Section " + i,
                                        "Female",
                                        new DateTime(1992, 6, 28))
                    );
            }

            for (int i = 1; i <= 3; i++)
            {
                context.Subjects.AddOrUpdate(
                    new Subject("Subject " + i,
                        new Teacher(i + "Teacher", "Test", "Teacher"),
                        new ClassInformation(i, "Section " + i)
                    )
                );
            }

           
        }
    }
}

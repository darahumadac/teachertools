namespace TeacherTools.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class SubjectModuleClasses : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Subjects",
                c => new
                    {
                        SubjectId = c.Int(nullable: false, identity: true),
                        SubjectName = c.String(),
                        Class_ClassInformationId = c.Int(),
                        SubjectTeacher_TeacherId = c.Int(),
                    })
                .PrimaryKey(t => t.SubjectId)
                .ForeignKey("dbo.ClassInformations", t => t.Class_ClassInformationId)
                .ForeignKey("dbo.Teachers", t => t.SubjectTeacher_TeacherId)
                .Index(t => t.Class_ClassInformationId)
                .Index(t => t.SubjectTeacher_TeacherId);
            
            CreateTable(
                "dbo.ClassInformations",
                c => new
                    {
                        ClassInformationId = c.Int(nullable: false, identity: true),
                        GradeLevel = c.Int(nullable: false),
                        Section = c.String(),
                    })
                .PrimaryKey(t => t.ClassInformationId);
            
            CreateTable(
                "dbo.SubjectRequirements",
                c => new
                    {
                        SubjectRequirementId = c.Int(nullable: false, identity: true),
                        RequirementType = c.String(),
                        RequirementPercentage = c.Decimal(nullable: false, precision: 18, scale: 2),
                        Subject_SubjectId = c.Int(),
                    })
                .PrimaryKey(t => t.SubjectRequirementId)
                .ForeignKey("dbo.Subjects", t => t.Subject_SubjectId)
                .Index(t => t.Subject_SubjectId);
            
            CreateTable(
                "dbo.Requirements",
                c => new
                    {
                        RequirementId = c.Int(nullable: false, identity: true),
                        Name = c.String(),
                        MaxGrade = c.Decimal(nullable: false, precision: 18, scale: 2),
                        SubjectRequirement_SubjectRequirementId = c.Int(),
                    })
                .PrimaryKey(t => t.RequirementId)
                .ForeignKey("dbo.SubjectRequirements", t => t.SubjectRequirement_SubjectRequirementId)
                .Index(t => t.SubjectRequirement_SubjectRequirementId);
            
            CreateTable(
                "dbo.Teachers",
                c => new
                    {
                        TeacherId = c.Int(nullable: false, identity: true),
                        FirstName = c.String(),
                        MiddleName = c.String(),
                        LastName = c.String(),
                    })
                .PrimaryKey(t => t.TeacherId);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Subjects", "SubjectTeacher_TeacherId", "dbo.Teachers");
            DropForeignKey("dbo.SubjectRequirements", "Subject_SubjectId", "dbo.Subjects");
            DropForeignKey("dbo.Requirements", "SubjectRequirement_SubjectRequirementId", "dbo.SubjectRequirements");
            DropForeignKey("dbo.Subjects", "Class_ClassInformationId", "dbo.ClassInformations");
            DropIndex("dbo.Requirements", new[] { "SubjectRequirement_SubjectRequirementId" });
            DropIndex("dbo.SubjectRequirements", new[] { "Subject_SubjectId" });
            DropIndex("dbo.Subjects", new[] { "SubjectTeacher_TeacherId" });
            DropIndex("dbo.Subjects", new[] { "Class_ClassInformationId" });
            DropTable("dbo.Teachers");
            DropTable("dbo.Requirements");
            DropTable("dbo.SubjectRequirements");
            DropTable("dbo.ClassInformations");
            DropTable("dbo.Subjects");
        }
    }
}

namespace TeacherTools.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddedUniqueIXtoStudentNum : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.Students", "StudentNumber", c => c.String(maxLength: 10));
            CreateIndex("dbo.Students", "StudentNumber", unique: true);
        }
        
        public override void Down()
        {
            DropIndex("dbo.Students", new[] { "StudentNumber" });
            AlterColumn("dbo.Students", "StudentNumber", c => c.String());
        }
    }
}

namespace TeacherTools.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddGenderAndBirthdateForStudent : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Students", "Gender", c => c.String());
            AddColumn("dbo.Students", "BirthDate", c => c.DateTime(nullable: false));
        }
        
        public override void Down()
        {
            DropColumn("dbo.Students", "BirthDate");
            DropColumn("dbo.Students", "Gender");
        }
    }
}

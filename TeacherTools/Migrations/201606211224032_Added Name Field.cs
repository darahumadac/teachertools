namespace TeacherTools.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddedNameField : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Students", "Name_FirstName", c => c.String());
            AddColumn("dbo.Students", "Name_LastName", c => c.String());
            AddColumn("dbo.Students", "Name_MiddleName", c => c.String());
            DropColumn("dbo.Students", "FirstName");
            DropColumn("dbo.Students", "LastName");
            DropColumn("dbo.Students", "MiddleName");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Students", "MiddleName", c => c.String());
            AddColumn("dbo.Students", "LastName", c => c.String());
            AddColumn("dbo.Students", "FirstName", c => c.String());
            DropColumn("dbo.Students", "Name_MiddleName");
            DropColumn("dbo.Students", "Name_LastName");
            DropColumn("dbo.Students", "Name_FirstName");
        }
    }
}

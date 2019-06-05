namespace DrakeTest.DataAccess.SQL.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class InitialTest2 : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Patients", "UserId", c => c.String());
            AddColumn("dbo.Patients", "FirstName", c => c.String());
            AddColumn("dbo.Patients", "LastName", c => c.String());
            AddColumn("dbo.Patients", "DOB", c => c.String());
            AddColumn("dbo.Patients", "PhoneNumber", c => c.String());
            AddColumn("dbo.Patients", "Email", c => c.String());
        }
        
        public override void Down()
        {
            DropColumn("dbo.Patients", "Email");
            DropColumn("dbo.Patients", "PhoneNumber");
            DropColumn("dbo.Patients", "DOB");
            DropColumn("dbo.Patients", "LastName");
            DropColumn("dbo.Patients", "FirstName");
            DropColumn("dbo.Patients", "UserId");
        }
    }
}

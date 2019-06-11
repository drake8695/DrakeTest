namespace DrakeTest.DataAccess.SQL.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class PatientRecords2 : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.PatientRecords", "UserId", c => c.String());
            DropColumn("dbo.PatientRecords", "Email");
        }
        
        public override void Down()
        {
            AddColumn("dbo.PatientRecords", "Email", c => c.String());
            DropColumn("dbo.PatientRecords", "UserId");
        }
    }
}

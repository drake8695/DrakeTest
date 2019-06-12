namespace DrakeTest.DataAccess.SQL.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class PatientRecords3 : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.PatientRecords", "height", c => c.Double(nullable: false));
            AlterColumn("dbo.PatientRecords", "weight", c => c.Double(nullable: false));
        }
        
        public override void Down()
        {
            AlterColumn("dbo.PatientRecords", "weight", c => c.String());
            AlterColumn("dbo.PatientRecords", "height", c => c.String());
        }
    }
}

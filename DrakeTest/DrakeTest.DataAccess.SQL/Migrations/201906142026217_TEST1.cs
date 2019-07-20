namespace DrakeTest.DataAccess.SQL.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class TEST1 : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.Patients", "Email", c => c.String(maxLength: 50));
        }
        
        public override void Down()
        {
            AlterColumn("dbo.Patients", "Email", c => c.String());
        }
    }
}

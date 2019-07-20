namespace DrakeTest.DataAccess.SQL.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class TEST2 : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Patients", "Gender", c => c.String());
        }
        
        public override void Down()
        {
            DropColumn("dbo.Patients", "Gender");
        }
    }
}

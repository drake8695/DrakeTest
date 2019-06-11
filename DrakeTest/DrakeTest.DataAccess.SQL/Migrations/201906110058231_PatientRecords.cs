namespace DrakeTest.DataAccess.SQL.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class PatientRecords : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.PatientRecords",
                c => new
                    {
                        Id = c.String(nullable: false, maxLength: 128),
                        height = c.String(),
                        weight = c.String(),
                        test = c.String(),
                        CreatedAt = c.DateTimeOffset(nullable: false, precision: 7),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.Patients",
                c => new
                    {
                        Id = c.String(nullable: false, maxLength: 128),
                        UserId = c.String(),
                        FirstName = c.String(),
                        LastName = c.String(),
                        DOB = c.String(),
                        PhoneNumber = c.String(),
                        Email = c.String(),
                        CreatedAt = c.DateTimeOffset(nullable: false, precision: 7),
                    })
                .PrimaryKey(t => t.Id);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.Patients");
            DropTable("dbo.PatientRecords");
        }
    }
}

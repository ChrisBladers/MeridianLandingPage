namespace Meridian.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class InitialCreate : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.HomeDetails",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        EnrollmentText = c.String(),
                        EnrollementSubText = c.String(),
                        PrimaryButtonText = c.String(),
                        SecondaryButtonText = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.HomeDetails");
        }
    }
}

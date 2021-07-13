namespace Meridian.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddBanner : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Banners",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        BannerImage = c.String(nullable: false),
                        BannerTitle = c.String(),
                        BannerSubtitle = c.String(),
                        BannerPrimaryButtonText = c.String(),
                        BannerSecondaryButtonText = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.Banners");
        }
    }
}

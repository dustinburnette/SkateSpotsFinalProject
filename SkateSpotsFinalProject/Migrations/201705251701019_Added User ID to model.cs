namespace SkateSpotsFinalProject.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddedUserIDtomodel : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.SkateSpots", "UserID", c => c.String(maxLength: 128));
            CreateIndex("dbo.SkateSpots", "UserID");
            AddForeignKey("dbo.SkateSpots", "UserID", "dbo.AspNetUsers", "Id");
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.SkateSpots", "UserID", "dbo.AspNetUsers");
            DropIndex("dbo.SkateSpots", new[] { "UserID" });
            DropColumn("dbo.SkateSpots", "UserID");
        }
    }
}

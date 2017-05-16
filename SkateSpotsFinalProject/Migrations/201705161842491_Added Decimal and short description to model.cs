namespace SkateSpotsFinalProject.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddedDecimalandshortdescriptiontomodel : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.SkateSpots", "ShortDescription", c => c.String());
            AlterColumn("dbo.SkateSpots", "Lat", c => c.Double(nullable: false));
            AlterColumn("dbo.SkateSpots", "Long", c => c.Double(nullable: false));
        }
        
        public override void Down()
        {
            AlterColumn("dbo.SkateSpots", "Long", c => c.Int(nullable: false));
            AlterColumn("dbo.SkateSpots", "Lat", c => c.Int(nullable: false));
            DropColumn("dbo.SkateSpots", "ShortDescription");
        }
    }
}

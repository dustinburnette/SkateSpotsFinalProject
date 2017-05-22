namespace SkateSpotsFinalProject.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddedSkateLoggerModelandControllerwithpropertiesassignedtoit : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.SkateLoggers",
                c => new
                    {
                        SkateLoggerID = c.Int(nullable: false, identity: true),
                        TrickName = c.String(),
                        Attempts = c.Int(nullable: false),
                        Landed = c.Boolean(nullable: false),
                        HowLongMinutes = c.Time(nullable: false, precision: 7),
                    })
                .PrimaryKey(t => t.SkateLoggerID);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.SkateLoggers");
        }
    }
}

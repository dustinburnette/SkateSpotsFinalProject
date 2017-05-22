namespace SkateSpotsFinalProject.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class LearnTricksModelandControlleradded : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.LearnTricks",
                c => new
                    {
                        LearnTrickID = c.Int(nullable: false, identity: true),
                    })
                .PrimaryKey(t => t.LearnTrickID);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.LearnTricks");
        }
    }
}

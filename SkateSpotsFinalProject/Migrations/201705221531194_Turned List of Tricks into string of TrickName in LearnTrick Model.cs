namespace SkateSpotsFinalProject.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class TurnedListofTricksintostringofTrickNameinLearnTrickModel : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.LearnTricks", "TrickName", c => c.String());
        }
        
        public override void Down()
        {
            DropColumn("dbo.LearnTricks", "TrickName");
        }
    }
}

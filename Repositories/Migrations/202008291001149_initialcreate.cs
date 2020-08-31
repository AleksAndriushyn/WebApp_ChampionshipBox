namespace Repositories.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class initialcreate : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.ChampionshipBoxes",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        Date = c.DateTime(nullable: false),
                        AmountOfRounds = c.Int(nullable: false),
                        BoxerWin = c.String(),
                        Boxer = c.String(),
                        RefereePoints = c.Int(nullable: false),
                        Result = c.Boolean(nullable: false),
                    })
                .PrimaryKey(t => t.ID);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.ChampionshipBoxes");
        }
    }
}

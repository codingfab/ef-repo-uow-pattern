namespace RepositoryPatternEfCodeFirst.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class InitialCreate : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.RugbyPlayers",
                c => new
                    {
                        RugbyPlayerId = c.Int(nullable: false, identity: true),
                        FirstName = c.String(),
                        LastName = c.String(),
                        Number = c.Byte(nullable: false),
                    })
                .PrimaryKey(t => t.RugbyPlayerId);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.RugbyPlayers");
        }
    }
}

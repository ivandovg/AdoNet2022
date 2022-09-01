namespace AdoNet9_2.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Initial : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Competitions",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Date = c.DateTime(nullable: false, storeType: "date"),
                        CityName = c.String(nullable: false, maxLength: 100),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.Results",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Place = c.Int(nullable: false),
                        CompetitionId = c.Int(nullable: false),
                        PaticipantId = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Competitions", t => t.CompetitionId, cascadeDelete: true)
                .ForeignKey("dbo.Paticipants", t => t.PaticipantId, cascadeDelete: true)
                .Index(t => t.CompetitionId)
                .Index(t => t.PaticipantId);
            
            CreateTable(
                "dbo.Paticipants",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Name = c.String(nullable: false, maxLength: 100),
                        Birth = c.DateTime(nullable: false, storeType: "date"),
                        CountryName = c.String(nullable: false, maxLength: 100),
                        Weight = c.Double(nullable: false),
                        Height = c.Double(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Results", "PaticipantId", "dbo.Paticipants");
            DropForeignKey("dbo.Results", "CompetitionId", "dbo.Competitions");
            DropIndex("dbo.Results", new[] { "PaticipantId" });
            DropIndex("dbo.Results", new[] { "CompetitionId" });
            DropTable("dbo.Paticipants");
            DropTable("dbo.Results");
            DropTable("dbo.Competitions");
        }
    }
}

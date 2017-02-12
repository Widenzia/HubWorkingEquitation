namespace WorkingEquitation.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Init4 : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Classes",
                c => new
                    {
                        ClassNo = c.String(nullable: false, maxLength: 128),
                        ShowId = c.Int(nullable: false),
                        Level = c.String(),
                        ClassCrewId = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.ClassNo);
            
            CreateTable(
                "dbo.Crews",
                c => new
                    {
                        CrewId = c.Int(nullable: false, identity: true),
                        Position = c.String(),
                    })
                .PrimaryKey(t => t.CrewId);
            
            CreateTable(
                "dbo.Entries",
                c => new
                    {
                        EntryId = c.Int(nullable: false, identity: true),
                        ShowId = c.Int(nullable: false),
                        ClassNo = c.String(),
                        RiderId = c.Int(nullable: false),
                        HorseId = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.EntryId);
            
            CreateTable(
                "dbo.EntryScores",
                c => new
                    {
                        EntryScoreId = c.Int(nullable: false, identity: true),
                        ShowId = c.Int(nullable: false),
                        ClassNo = c.String(),
                        EntryId = c.Int(nullable: false),
                        CrewId = c.Int(nullable: false),
                        Position = c.String(),
                        TotalPoints = c.Double(nullable: false),
                        PointsPercent = c.Double(nullable: false),
                    })
                .PrimaryKey(t => t.EntryScoreId);
            
            CreateTable(
                "dbo.Horses",
                c => new
                    {
                        HorseId = c.Int(nullable: false, identity: true),
                        ShowId = c.Int(nullable: false),
                        HorseName = c.String(),
                    })
                .PrimaryKey(t => t.HorseId);
            
            CreateTable(
                "dbo.Riders",
                c => new
                    {
                        RiderId = c.Int(nullable: false, identity: true),
                        ShowId = c.Int(nullable: false),
                        FirstName = c.String(),
                        LastName = c.String(),
                        ClubTeam = c.String(),
                        HorseId = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.RiderId);
            
            CreateTable(
                "dbo.ShowCrews",
                c => new
                    {
                        ShowCrewId = c.Int(nullable: false, identity: true),
                        ShowId = c.Int(nullable: false),
                        CrewId = c.Int(nullable: false),
                        FirstName = c.String(),
                        LastName = c.String(),
                        PhoneNo = c.Int(nullable: false),
                        Email = c.String(),
                    })
                .PrimaryKey(t => t.ShowCrewId);
            
            CreateTable(
                "dbo.Shows",
                c => new
                    {
                        ShowId = c.Int(nullable: false, identity: true),
                        Date = c.DateTime(nullable: false),
                        ShowName = c.String(),
                    })
                .PrimaryKey(t => t.ShowId);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.Shows");
            DropTable("dbo.ShowCrews");
            DropTable("dbo.Riders");
            DropTable("dbo.Horses");
            DropTable("dbo.EntryScores");
            DropTable("dbo.Entries");
            DropTable("dbo.Crews");
            DropTable("dbo.Classes");
        }
    }
}

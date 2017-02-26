namespace WorkingEquitation.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Init : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Classes",
                c => new
                    {
                        ClassId = c.Int(nullable: false, identity: true),
                        MeetingId = c.Int(nullable: false),
                        ClassNo = c.String(),
                        Level = c.String(),
                        ClassCrewId = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.ClassId);
            
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
                        MeetingId = c.Int(nullable: false),
                        ClassId = c.String(nullable: false, maxLength: 128),
                        EntryId = c.Int(nullable: false),
                        RiderId = c.Int(nullable: false),
                        HorseId = c.Int(nullable: false),
                    })
                .PrimaryKey(t => new { t.MeetingId, t.ClassId, t.EntryId });
            
            CreateTable(
                "dbo.EntryScores",
                c => new
                    {
                        MeetingId = c.Int(nullable: false),
                        ClassId = c.String(nullable: false, maxLength: 128),
                        EntryId = c.Int(nullable: false),
                        EntryScoreId = c.Int(nullable: false),
                        CrewId = c.Int(nullable: false),
                        Position = c.String(),
                        TotalPoints = c.Double(nullable: false),
                        PointsPercent = c.Double(nullable: false),
                    })
                .PrimaryKey(t => new { t.MeetingId, t.ClassId, t.EntryId, t.EntryScoreId });
            
            CreateTable(
                "dbo.Horses",
                c => new
                    {
                        MeetingId = c.Int(nullable: false),
                        HorseId = c.Int(nullable: false),
                        HorseName = c.String(),
                    })
                .PrimaryKey(t => new { t.MeetingId, t.HorseId });
            
            CreateTable(
                "dbo.MeetingCrews",
                c => new
                    {
                        MeetingCrewId = c.Int(nullable: false, identity: true),
                        MeetingId = c.Int(nullable: false),
                        CrewId = c.Int(nullable: false),
                        FirstName = c.String(),
                        LastName = c.String(),
                        PhoneNo = c.Int(nullable: false),
                        Email = c.String(),
                    })
                .PrimaryKey(t => t.MeetingCrewId);
            
            CreateTable(
                "dbo.Meetings",
                c => new
                    {
                        MeetingId = c.Int(nullable: false),
                        Date = c.DateTime(nullable: false),
                        MeetingName = c.String(),
                    })
                .PrimaryKey(t => new { t.MeetingId, t.Date });
            
            CreateTable(
                "dbo.Riders",
                c => new
                    {
                        MeetingId = c.Int(nullable: false),
                        RiderId = c.Int(nullable: false),
                        HorseId = c.Int(nullable: false),
                        FirstName = c.String(),
                        LastName = c.String(),
                        ClubTeam = c.String(),
                    })
                .PrimaryKey(t => new { t.MeetingId, t.RiderId })
                .ForeignKey("dbo.Horses", t => new { t.MeetingId, t.HorseId }, cascadeDelete: true)
                .Index(t => new { t.MeetingId, t.HorseId });
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Riders", new[] { "MeetingId", "HorseId" }, "dbo.Horses");
            DropIndex("dbo.Riders", new[] { "MeetingId", "HorseId" });
            DropTable("dbo.Riders");
            DropTable("dbo.Meetings");
            DropTable("dbo.MeetingCrews");
            DropTable("dbo.Horses");
            DropTable("dbo.EntryScores");
            DropTable("dbo.Entries");
            DropTable("dbo.Crews");
            DropTable("dbo.Classes");
        }
    }
}

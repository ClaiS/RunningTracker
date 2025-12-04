namespace RunningWinForm.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class InitialCreate : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.HeartRateZoneDetails",
                c => new
                    {
                        ZoneDetailID = c.Int(nullable: false, identity: true),
                        Zone = c.Int(nullable: false),
                        TimeInZone = c.Decimal(nullable: false, precision: 18, scale: 2),
                        RunID = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.ZoneDetailID)
                .ForeignKey("dbo.RunSessions", t => t.RunID, cascadeDelete: true)
                .Index(t => t.RunID);
            
            CreateTable(
                "dbo.RunSessions",
                c => new
                    {
                        RunID = c.Int(nullable: false, identity: true),
                        RunType = c.String(nullable: false),
                        RunDate = c.DateTime(nullable: false),
                        Distance = c.Decimal(nullable: false, precision: 18, scale: 2),
                        Duration = c.Decimal(nullable: false, precision: 18, scale: 2),
                        RPE = c.Int(nullable: false),
                        Terrain = c.String(),
                        AvgHR = c.Int(nullable: false),
                        UserID = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.RunID)
                .ForeignKey("dbo.Users", t => t.UserID, cascadeDelete: true)
                .Index(t => t.UserID);
            
            CreateTable(
                "dbo.Users",
                c => new
                    {
                        UserID = c.Int(nullable: false, identity: true),
                        Username = c.String(nullable: false, maxLength: 50),
                        Password = c.String(nullable: false, maxLength: 100),
                    })
                .PrimaryKey(t => t.UserID);
            
            CreateTable(
                "dbo.MonthlySummaries",
                c => new
                    {
                        SummaryID = c.Int(nullable: false, identity: true),
                        Year = c.Int(nullable: false),
                        Month = c.Int(nullable: false),
                        TotalDistance = c.Decimal(nullable: false, precision: 18, scale: 2),
                        TotalTrainingLoad = c.Decimal(nullable: false, precision: 18, scale: 2),
                        TotalRuns = c.Int(nullable: false),
                        DominantRunType = c.String(maxLength: 20),
                        UserID = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.SummaryID)
                .ForeignKey("dbo.Users", t => t.UserID, cascadeDelete: true)
                .Index(t => t.UserID);
            
            CreateTable(
                "dbo.TrainingPlans",
                c => new
                    {
                        PlanID = c.Int(nullable: false, identity: true),
                        PlanType = c.String(nullable: false, maxLength: 20),
                        StartDate = c.DateTime(nullable: false),
                        EndDate = c.DateTime(nullable: false),
                        TargetDistance = c.Decimal(nullable: false, precision: 18, scale: 2),
                        TargetPace = c.Decimal(nullable: false, precision: 18, scale: 2),
                        UserID = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.PlanID)
                .ForeignKey("dbo.Users", t => t.UserID, cascadeDelete: true)
                .Index(t => t.UserID);
            
            CreateTable(
                "dbo.WeeklySummaries",
                c => new
                    {
                        SummaryID = c.Int(nullable: false, identity: true),
                        Year = c.Int(nullable: false),
                        WeekNumber = c.Int(nullable: false),
                        TotalDistance = c.Decimal(nullable: false, precision: 18, scale: 2),
                        TotalTrainingLoad = c.Decimal(nullable: false, precision: 18, scale: 2),
                        TotalRuns = c.Int(nullable: false),
                        DominantRunType = c.String(maxLength: 20),
                        UserID = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.SummaryID)
                .ForeignKey("dbo.Users", t => t.UserID, cascadeDelete: true)
                .Index(t => t.UserID);
            
            CreateTable(
                "dbo.YearlySummaries",
                c => new
                    {
                        SummaryID = c.Int(nullable: false, identity: true),
                        Year = c.Int(nullable: false),
                        TotalDistance = c.Decimal(nullable: false, precision: 18, scale: 2),
                        TotalTrainingLoad = c.Decimal(nullable: false, precision: 18, scale: 2),
                        TotalRuns = c.Int(nullable: false),
                        DominantRunType = c.String(maxLength: 20),
                        UserID = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.SummaryID)
                .ForeignKey("dbo.Users", t => t.UserID, cascadeDelete: true)
                .Index(t => t.UserID);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.HeartRateZoneDetails", "RunID", "dbo.RunSessions");
            DropForeignKey("dbo.RunSessions", "UserID", "dbo.Users");
            DropForeignKey("dbo.YearlySummaries", "UserID", "dbo.Users");
            DropForeignKey("dbo.WeeklySummaries", "UserID", "dbo.Users");
            DropForeignKey("dbo.TrainingPlans", "UserID", "dbo.Users");
            DropForeignKey("dbo.MonthlySummaries", "UserID", "dbo.Users");
            DropIndex("dbo.YearlySummaries", new[] { "UserID" });
            DropIndex("dbo.WeeklySummaries", new[] { "UserID" });
            DropIndex("dbo.TrainingPlans", new[] { "UserID" });
            DropIndex("dbo.MonthlySummaries", new[] { "UserID" });
            DropIndex("dbo.RunSessions", new[] { "UserID" });
            DropIndex("dbo.HeartRateZoneDetails", new[] { "RunID" });
            DropTable("dbo.YearlySummaries");
            DropTable("dbo.WeeklySummaries");
            DropTable("dbo.TrainingPlans");
            DropTable("dbo.MonthlySummaries");
            DropTable("dbo.Users");
            DropTable("dbo.RunSessions");
            DropTable("dbo.HeartRateZoneDetails");
        }
    }
}

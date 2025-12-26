namespace RunningWinForm.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class RemoveSummaries : DbMigration
    {
        public override void Up()
        {
            DropForeignKey("dbo.WeeklySummaries", "UserID", "dbo.Users");
            DropForeignKey("dbo.YearlySummaries", "UserID", "dbo.Users");
            DropForeignKey("dbo.MonthlySummaries", "UserID", "dbo.Users");
            DropIndex("dbo.MonthlySummaries", new[] { "UserID" });
            DropIndex("dbo.WeeklySummaries", new[] { "UserID" });
            DropIndex("dbo.YearlySummaries", new[] { "UserID" });
            DropTable("dbo.MonthlySummaries");
            DropTable("dbo.WeeklySummaries");
            DropTable("dbo.YearlySummaries");
        }
        
        public override void Down()
        {
            CreateTable(
                "dbo.YearlySummaries",
                c => new
                    {
                        SummaryID = c.Int(nullable: false, identity: true),
                        Year = c.Int(nullable: false),
                        TotalDistance = c.Decimal(nullable: false, precision: 18, scale: 2),
                        TotalTrainingLoad = c.Decimal(nullable: false, precision: 18, scale: 2),
                        TotalRuns = c.Int(nullable: false),
                        AvgPace = c.Int(nullable: false),
                        UserID = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.SummaryID);
            
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
                        AvgPace = c.Int(nullable: false),
                        UserID = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.SummaryID);
            
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
                        AvgPace = c.Int(nullable: false),
                        UserID = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.SummaryID);
            
            CreateIndex("dbo.YearlySummaries", "UserID");
            CreateIndex("dbo.WeeklySummaries", "UserID");
            CreateIndex("dbo.MonthlySummaries", "UserID");
            AddForeignKey("dbo.MonthlySummaries", "UserID", "dbo.Users", "UserID", cascadeDelete: true);
            AddForeignKey("dbo.YearlySummaries", "UserID", "dbo.Users", "UserID", cascadeDelete: true);
            AddForeignKey("dbo.WeeklySummaries", "UserID", "dbo.Users", "UserID", cascadeDelete: true);
        }
    }
}

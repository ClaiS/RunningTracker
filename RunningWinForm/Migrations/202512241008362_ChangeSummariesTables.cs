namespace RunningWinForm.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class ChangeSummariesTables : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.MonthlySummaries", "AvgPace", c => c.Int(nullable: false));
            AddColumn("dbo.WeeklySummaries", "AvgPace", c => c.Int(nullable: false));
            AddColumn("dbo.YearlySummaries", "AvgPace", c => c.Int(nullable: false));
            DropColumn("dbo.MonthlySummaries", "DominantRunType");
            DropColumn("dbo.WeeklySummaries", "DominantRunType");
            DropColumn("dbo.YearlySummaries", "DominantRunType");
        }
        
        public override void Down()
        {
            AddColumn("dbo.YearlySummaries", "DominantRunType", c => c.String(maxLength: 20));
            AddColumn("dbo.WeeklySummaries", "DominantRunType", c => c.String(maxLength: 20));
            AddColumn("dbo.MonthlySummaries", "DominantRunType", c => c.String(maxLength: 20));
            DropColumn("dbo.YearlySummaries", "AvgPace");
            DropColumn("dbo.WeeklySummaries", "AvgPace");
            DropColumn("dbo.MonthlySummaries", "AvgPace");
        }
    }
}

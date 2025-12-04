namespace RunningWinForm.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class RemoveHeartRateZoneDetail : DbMigration
    {
        public override void Up()
        {
            DropForeignKey("dbo.HeartRateZoneDetails", "RunID", "dbo.RunSessions");
            DropIndex("dbo.HeartRateZoneDetails", new[] { "RunID" });
            DropTable("dbo.HeartRateZoneDetails");
        }
        
        public override void Down()
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
                .PrimaryKey(t => t.ZoneDetailID);
            
            CreateIndex("dbo.HeartRateZoneDetails", "RunID");
            AddForeignKey("dbo.HeartRateZoneDetails", "RunID", "dbo.RunSessions", "RunID", cascadeDelete: true);
        }
    }
}

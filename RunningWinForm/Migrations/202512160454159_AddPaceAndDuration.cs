namespace RunningWinForm.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddPaceAndDuration : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.RunSessions", "Pace", c => c.Decimal(nullable: false, precision: 18, scale: 2));
        }
        
        public override void Down()
        {
            DropColumn("dbo.RunSessions", "Pace");
        }
    }
}

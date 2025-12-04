namespace RunningWinForm.Migrations
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;

    internal sealed class Configuration : DbMigrationsConfiguration<RunningWinForm.Data.RunningContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = false;
        }

        protected override void Seed(RunningWinForm.Data.RunningContext context)
        {
            context.Users.AddOrUpdate(
              u => u.Username,
              new Models.User { Username = "admin", Password = "admin" }
            );
        }
    }
}

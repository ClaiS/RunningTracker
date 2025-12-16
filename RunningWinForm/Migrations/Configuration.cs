namespace RunningWinForm.Migrations
{
    using RunningWinForm.Models;
    using RunningWinForm.Services;
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
            var adminRole = new Role { RoleID = 1, RoleName = "Admin" };
            var userRole = new Role { RoleID = 2, RoleName = "User" };
            context.Roles.AddOrUpdate(r => r.RoleID, adminRole, userRole);

            string adminPasswordHash = PasswordHelper.HashPassword("admin");
            string userPasswordHash = PasswordHelper.HashPassword("user1");
            string user2PasswordHash = PasswordHelper.HashPassword("user2");

            var admin = new User
            {
                UserID = 1,
                Username = "admin",
                Password = adminPasswordHash, // ← ĐÃ MÃ HÓA
                FullName = "Administrator",
                Email = "admin@email.local"
            };
            context.Users.AddOrUpdate(u => u.UserID, admin);

            var user1 = new User
            {
                UserID = 2,
                Username = "user1",
                Password = userPasswordHash, // ← ĐÃ MÃ HÓA
                FullName = "Người dùng 1",
                Email = "user1@email.local"
            };
            context.Users.AddOrUpdate(u => u.UserID, user1);

            var user2 = new User
            {
                UserID = 3,
                Username = "user2",
                Password = user2PasswordHash, // ← ĐÃ MÃ HÓA
                FullName = "Người dùng 2",
                Email = "user2@email.local"
            };
            context.Users.AddOrUpdate(u => u.UserID, admin, user2);

            context.UserRoles.AddOrUpdate(
                ur => new { ur.UserID, ur.RoleID },
                new UserRole { UserID = 1, RoleID = 1 }, 
                new UserRole { UserID = 2, RoleID = 2 },
                new UserRole { UserID = 3, RoleID = 2 } 
            );
            context.SaveChanges();
        }
    }
}

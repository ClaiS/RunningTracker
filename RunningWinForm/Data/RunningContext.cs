using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using RunningWinForm.Models;

namespace RunningWinForm.Data
{
    public class RunningContext : DbContext
    {
        public RunningContext() : base("name=RunningTrackerDB")
        {
            
        }

        // DbSet cho các bảng trong cơ sở dữ liệu
        public DbSet<User> Users { get; set; }
        public DbSet<Role> Roles { get; set; }
        public DbSet<UserRole> UserRoles { get; set; }
        public DbSet<RunSession> RunSessions { get; set; }
        public DbSet<TrainingPlan> TrainingPlans { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            //Thiêt lập quan hệ các bảng
             
            base.OnModelCreating(modelBuilder);

            modelBuilder.Entity<UserRole>()
                .HasKey(ur => new { ur.UserID, ur.RoleID });

            modelBuilder.Entity<UserRole>()
                .HasRequired(ur => ur.User)
                .WithMany(u => u.UserRoles)
                .HasForeignKey(ur => ur.UserID);

            modelBuilder.Entity<UserRole>()
                .HasRequired(ur => ur.Role)
                .WithMany(r => r.UserRoles)
                .HasForeignKey(ur => ur.RoleID);

            modelBuilder.Entity<RunSession>()
                .HasRequired(rs => rs.User)
                .WithMany(u => u.RunSessions)
                .HasForeignKey(rs => rs.UserID);

            modelBuilder.Entity<TrainingPlan>()
                .HasRequired(tp => tp.User)
                .WithMany(u => u.TrainingPlans)
                .HasForeignKey(tp => tp.UserID);

            modelBuilder.Entity<User>().ToTable("Users");
            modelBuilder.Entity<RunSession>().ToTable("RunSessions");
            modelBuilder.Entity<TrainingPlan>().ToTable("TrainingPlans");
        }
    }
}

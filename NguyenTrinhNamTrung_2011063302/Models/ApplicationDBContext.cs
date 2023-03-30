using Microsoft.AspNet.Identity.EntityFramework;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace NguyenTrinhNamTrung_2011063302.Models
{
    public class ApplicationDbContext : IdentityDbContext<ApplicationUser>
    {
        public DbSet<Course> Courses { get; set; }
        public DbSet<Category> Categories { get; set; }
        public DbSet<Attendance> Attendances { get; set; }
        public ApplicationDbContext()
            : base("DefaultConnection", throwIfV1Schema: false)
        {
        }
        public static ApplicationDbContext Create()
        {
            return new ApplicationDbContext();
        }

        protected override void OnModeCreating(DbModeBuilder modelBuider)
        {
            modelBuider.Entity<Attendance>()
                .HasRequired(a => a.Course)
                .WithMany()
                .WillCascadeOnDelete(false);
            base.OnModelCreating(modelBulder);
        }
    }
}   
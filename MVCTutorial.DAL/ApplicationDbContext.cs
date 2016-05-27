using System.Data.Entity;
using Microsoft.AspNet.Identity.EntityFramework;
using MVCTutorial.DAL.Entities.Identity;
using MVCTutorial.DAL.Migrations;

namespace MVCTutorial.DAL
{
    public class ApplicationDbContext : IdentityDbContext<ApplicationUser>
    {
       // static ApplicationDbContext()
       // {
       //     Database.SetInitializer(new MigrateDatabaseToLatestVersion<ApplicationDbContext, Configuration>());
       // }

        public ApplicationDbContext()
            : base("DefaultConnection")
        {
        }

        public System.Data.Entity.DbSet<MVCTutorial.DAL.Entities.Testclass> Testclasses { get; set; }

        public System.Data.Entity.DbSet<MVCTutorial.DAL.Entities.Location> Locations { get; set; }
    }
}

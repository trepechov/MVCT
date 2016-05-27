using System.Data.Entity;
using Microsoft.AspNet.Identity.EntityFramework;
using MVCTutorial.DAL.Entities;
using MVCTutorial.DAL.Entities.Application;
using MVCTutorial.DAL.Entities.Identity;
using MVCTutorial.DAL.EntitiesConfiguration;

namespace MVCTutorial.DAL
{
    public class ApplicationDbContext : IdentityDbContext<ApplicationUser>
    {
        public ApplicationDbContext()
            : base("DefaultConnection")
        { }

        public IDbSet<Testclass> Testclasses { get; set; }
        public IDbSet<Location> Locations { get; set; }
        public IDbSet<Hotel> Hotels { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            this.Configuration.LazyLoadingEnabled = false;
            this.Configuration.ProxyCreationEnabled = false;

            modelBuilder.Configurations.Add(new LocationCfg());
            modelBuilder.Configurations.Add(new HotelCfg());

            base.OnModelCreating(modelBuilder);
        }
    }
}

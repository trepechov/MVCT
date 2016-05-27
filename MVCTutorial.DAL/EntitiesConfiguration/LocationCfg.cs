using System.Data.Entity.ModelConfiguration;
using MVCTutorial.DAL.Entities.Application;

namespace MVCTutorial.DAL.EntitiesConfiguration
{
    public class LocationCfg : EntityTypeConfiguration<Location>
    {
        public LocationCfg()
        {
            HasKey(x => x.Id);
        }
    }
}
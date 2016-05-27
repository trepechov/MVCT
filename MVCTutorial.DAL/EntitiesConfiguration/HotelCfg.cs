using System.Data.Entity.ModelConfiguration;
using MVCTutorial.DAL.Entities.Application;

namespace MVCTutorial.DAL.EntitiesConfiguration
{
    public class HotelCfg : EntityTypeConfiguration<Hotel>
    {
        public HotelCfg()
        {
            HasKey(x => x.Id);
            HasRequired(x => x.Location).WithMany().HasForeignKey(x => x.LocationId);
        }
    }
}
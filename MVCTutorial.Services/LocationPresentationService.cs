using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using MVCTutorial.DAL;
using MVCTutorial.DAL.Entities.Application;
using MVCTutorial.Services.Mapping;
using MVCTutorial.ViewModels.Controllers.Location;


namespace MVCTutorial.Services
{
    public class LocationPresentationService
    {
        public List<LocationViewModel> GetLocations()
        {
            using (var db = new ApplicationDbContext())
            {
                var entities = db.Locations.ToList();
                var result = entities.Select(LocationMapper.Map).ToList();
                return result;
            }
        }

        public LocationViewModel GetLocationById(int locationId)
        {
            using (var db = new ApplicationDbContext())
            {
                var entity = db.Locations.Find(locationId);
                var result = LocationMapper.Map(entity);
                return result;
            }
        }

        public void SaveLocation(LocationViewModel model)
        {
            using (var db = new ApplicationDbContext())
            {
                var location = LocationMapper.Map(model);
                db.Entry(location).State = model.Id == 0 ? EntityState.Added : EntityState.Modified;
                db.SaveChanges();
            }
        }

        public void Delete(int locationId)
        {
            using (var db = new ApplicationDbContext())
            {
                var location = new Location { Id = locationId };
                db.Entry(location).State = EntityState.Deleted;
                db.SaveChanges();
            }
        }
    }
}

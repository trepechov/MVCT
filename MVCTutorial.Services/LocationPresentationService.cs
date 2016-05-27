using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MVCTutorial.DAL;
using MVCTutorial.ViewModels.Controllers.Location;


namespace MVCTutorial.Services
{
    public class LocationPresentationService
    {
        // private ApplicationDbContext db = new ApplicationDbContext();

        public List<LocationViewModel> GetLocations()
        {
            //return View(db.Locations.ToList());
            var result = new List<LocationViewModel>();
            return result;
        }
    }
}

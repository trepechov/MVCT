using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MVCTutorial.DAL.Entities.Application;
using MVCTutorial.ViewModels.Controllers.Location;

namespace MVCTutorial.Services.Mapping
{
    class LocationMapper
    {
        public static LocationViewModel Map(Location entity)
        {
            var result = new LocationViewModel
            {
                Id = entity.Id,
                Country = entity.Country,
                City = entity.City,
                DisplayName = entity.DisplayName
            };

            return result;
        }

        public static Location Map(LocationViewModel model)
        {
            var result = new Location
            {
                Id = model.Id,
                Country = model.Country,
                City = model.City,
                DisplayName = model.DisplayName
            };

            return result;
        }
    }
}

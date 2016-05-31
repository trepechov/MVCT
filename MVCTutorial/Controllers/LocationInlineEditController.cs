using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using MVCTutorial.ViewModels.Controllers.Location;
using MVCTutorial.Services;
using Kendo.Mvc.UI;
using Kendo.Mvc.Extensions;

namespace MVCTutorial.Controllers
{
    public class LocationInlineEditController : Controller
    {
        private readonly LocationPresentationService _locationPresentationService = new LocationPresentationService();
        
        // GET: /LocationInlineEdit/
        public ActionResult Index()
        {
            var model = new List<LocationViewModel>();
            return View(model);
        }

        public ActionResult Read([DataSourceRequest]DataSourceRequest request)
        {
            var locations = _locationPresentationService.GetLocations();
            DataSourceResult result = locations.ToDataSourceResult(request);
            return Json(result);
        }
	}
}

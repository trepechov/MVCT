using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using MVCTutorial.DAL.Entities;
using MVCTutorial.DAL;
using MVCTutorial.DAL.Entities.Application;
using MVCTutorial.Services;
using MVCTutorial.ViewModels.Controllers.Location;

namespace MVCTutorial.Controllers
{
    [Authorize(Roles="Agent")]
    public class LocationController : Controller
    {
        private readonly LocationPresentationService _locationService = new LocationPresentationService();

        // GET: /Location/
        public ActionResult Index()
        {
            var list = _locationService.GetLocations();
            return View(list);
        }

        // GET: /Location/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }

            var location = _locationService.GetLocationById(id.Value);
            if (location == null)
            {
                return HttpNotFound();
            }
            return View(location);
        }

        // GET: /Location/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: /Location/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "Id,Country,City,DisplayName")] LocationViewModel location)
        {
            if (ModelState.IsValid)
            {
                _locationService.SaveLocation(location);
                return RedirectToAction("Index");
            }

            return View(location);
        }

        // GET: /Location/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }

            var location = _locationService.GetLocationById(id.Value);
            if (location == null)
            {
                return HttpNotFound();
            }
            return View(location);
        }

        // POST: /Location/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "Id,Country,City,DisplayName")] LocationViewModel location)
        {
            if (ModelState.IsValid)
            {
                _locationService.SaveLocation(location);
                return RedirectToAction("Index");
            }
            return View(location);
        }

        // GET: /Location/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            var location = _locationService.GetLocationById(id.Value);
            if (location == null)
            {
                return HttpNotFound();
            }
            return View(location);
        }

        // POST: /Location/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            _locationService.Delete(id);
            return RedirectToAction("Index");
        }
    }
}

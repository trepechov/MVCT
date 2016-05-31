using Microsoft.AspNet.Identity;
using Microsoft.AspNet.Identity.EntityFramework;
using MVCTutorial.DAL;
using MVCTutorial.DAL.Entities.Identity;
using MVCTutorial.ViewModels.Controllers.Admin;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Web;
using System.Web.Mvc;

namespace MVCTutorial.Controllers
{
    //[Authorize(Roles="Admin")]
    public class AdminController : Controller
    {
        private List<string> RoleList = new List<string> { "Admin", "Agent", "Tourist" };
        private UserManager<ApplicationUser> _userManager = new UserManager<ApplicationUser>(new UserStore<ApplicationUser>(new ApplicationDbContext()));

        public ActionResult Index()
        {
            var model = new List<UserWithRolesViewModel>();
            var currentId = User.Identity.GetUserId();

            using (var db = new ApplicationDbContext())
            {
                foreach (var user in db.Users)
                {
                    if (user.Id == currentId)
                    {
                        continue;
                    }

                    model.Add(new UserWithRolesViewModel
                    {
                        UserId = user.Id,
                        Name = user.UserName,
                        Roles = user.Roles.Select(x => x.Role.Name).ToList()
                    });
                }
            }

            return View(model);
        }

        public async Task<ActionResult> EditRoles(string userId)
        {
            ViewBag.UserId = userId;
            ViewBag.RoleList = RoleList;
            var roles = await _userManager.GetRolesAsync(userId);

            return View(roles);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<ActionResult> EditRoles(string userId, List<string> roles)
        {
            roles = roles ?? new List<string>();

            var existingRoles = await _userManager.GetRolesAsync(userId);
            foreach (var role in roles)
            {
                if (!RoleList.Contains(role))
                {
                    continue;
                }

                if (!existingRoles.Contains(role))
                {
                    await _userManager.AddToRoleAsync(userId, role);
                }
            }

            foreach (var roleToRemove in existingRoles.Except(roles))
            {
                await _userManager.RemoveFromRoleAsync(userId, roleToRemove);
            }

            return RedirectToAction("Index", "Admin");
        }
    }
}
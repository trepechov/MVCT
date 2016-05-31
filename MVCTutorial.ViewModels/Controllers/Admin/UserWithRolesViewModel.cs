using System;
using System.Collections.Generic;

namespace MVCTutorial.ViewModels.Controllers.Admin
{
    public class UserWithRolesViewModel
    {
        public string UserId { get; set; }
        public string Name { get; set; }
        public List<String> Roles { get; set; }
    }
}

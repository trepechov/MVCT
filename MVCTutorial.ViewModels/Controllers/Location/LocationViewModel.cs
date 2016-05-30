using System.ComponentModel.DataAnnotations;

namespace MVCTutorial.ViewModels.Controllers.Location
{
    public class LocationViewModel
    {
        public int Id { get; set; }
        public string Country { get; set; }
        public string City { get; set; }
        public string DisplayName { get; set; }
    }
}

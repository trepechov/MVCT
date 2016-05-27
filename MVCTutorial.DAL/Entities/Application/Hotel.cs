namespace MVCTutorial.DAL.Entities.Application
{
    public class Hotel
    {
        public int Id { get; set; }
        public int LocationId { get; set; }
        public int Stars { get; set; }
        public string DisplayName { get; set; }

        public Location Location { get; set; }
    }
}
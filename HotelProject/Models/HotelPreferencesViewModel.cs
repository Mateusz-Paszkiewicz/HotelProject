namespace HotelProject.Models
{
    public class HotelPreferencesViewModel
    {
        public string? Country { get; set; }
        public string? City { get; set; }
        public float Price { get; set; }
        public float DistanceToCenter { get; set; }
        public float DistanceToPOI { get; set; }
        public int Stars { get; set; }

    }
}

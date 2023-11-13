namespace HotelProject.Models
{
    public class HotelPreferencesViewModel
    {
        public HotelPreferencesViewModel()
        {
            AccommodationType = "Hotel";
            Price = 126.0f;  // Set a neutral default price
            DistanceToCenter = 1.0f;  // Set a neutral default distance to center
            DistanceToPOI = 2.0f;  // Set a neutral default distance to points of interest
            Stars = 3;  // Set a neutral default stars
        }

        public string City { get; set; }
        public string AccommodationType { get; set; }
        public float Price { get; set; }
        public float DistanceToCenter { get; set; }
        public float DistanceToPOI { get; set; }
        public int Stars { get; set; }
    }
}

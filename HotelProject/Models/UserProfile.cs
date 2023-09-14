namespace HotelProject.Models
{
    public class UserProfile
    {
        public string Country { get; set; }
        public string City { get; set; }
        public decimal PriceMin { get; set; }
        public decimal PriceMax { get; set; }
        public string CheckInTimeMax { get; set; }
        public string CheckOutTimeMin { get; set; }
        public string Amenities { get; set; }
        public int Rating { get; set; }
    }
}

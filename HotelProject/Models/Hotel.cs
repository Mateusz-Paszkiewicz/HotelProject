using System.ComponentModel.DataAnnotations;

namespace HotelProject.Models
{
    public class Hotel
    {
        [Key]
        public int Id { get; set; }
        [Required]
        public string Country { get; set; }
        [Required]
        public string City { get; set; }
        [Required]
        public double DistanceToCenter { get; set; }
        public double DistanceToPOI { get; set; }
        public string POI { get; set; }
        [Required]
        public int Price { get; set; }
        [Required]
        public int PriceNight { get; set; }
        [Required]
        public double Stars { get; set; }
        [Required]
        public string AccommodationType { get; set; }
        public bool IsOffer { get; set; }
        public string Offer { get; set; }
    }
}

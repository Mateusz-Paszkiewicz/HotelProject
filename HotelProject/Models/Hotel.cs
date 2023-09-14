using System.ComponentModel.DataAnnotations;

namespace HotelProject.Models
{
    public class Hotel
    {
        [Key]
        public int Id { get; set; }
        public string Name { get; set; }
        [Required]
        public string Country { get; set; }
        [Required]
        public string City { get; set; }
        [Required]
        public string Address { get; set; }
        [Required]
        public decimal Price { get; set; }
        public int Stars { get; set; }
        [Required]
        public int Rooms { get; set; }
        [Required]
        public string CheckInTime { get; set; }
        [Required]
        public string CheckOutTime { get; set; }
        public string Description { get; set; }
        public string Amenities { get; set; }
        public double Latitude { get; set; }
        public double Longitude { get; set; }
        public int Rating { get; set; }
    }
}

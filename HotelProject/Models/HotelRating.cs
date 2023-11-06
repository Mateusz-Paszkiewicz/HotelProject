using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace HotelProject.Models
{
    [Table("HotelRatings")]
    public class HotelRating
    {
        [Key]
        public int Id { get; set; }
        [Required]
        public int HotelId { get; set; }
        [Required]
        public string UserId { get; set; }
        [Required]
        public int RatingValue { get; set; }

        public Hotel Hotel { get; set; }
        public User User { get; set; }
    }
}

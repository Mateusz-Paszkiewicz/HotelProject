﻿using System.ComponentModel.DataAnnotations;
using System.Drawing.Text;

namespace HotelProject.Models
{
    public class UserHotelInteraction
    {
        [Key]
        public int Id { get; set; }
        [Required]
        public int HotelId { get;  set; }
        [Required]
        public string UserId { get; set; }
        [Required]
        public DateTime TimeStamp { get; set; }

        public Hotel Hotel { get; set; }
        public User User { get; set; }
    }
}

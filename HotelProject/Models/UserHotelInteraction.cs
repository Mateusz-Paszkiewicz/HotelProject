using System.Drawing.Text;

namespace HotelProject.Models
{
    public class UserHotelInteraction
    {
        private int Id { get; set; }
        public int HotelId { get;  set; }
        public string UserId { get; set; }
        private DateTime TimeStamp { get; set; }

        public void setTimeStampNow()
        {
            TimeStamp = DateTime.Now;
        }
    }
}

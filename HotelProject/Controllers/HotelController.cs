using HotelProject.Models;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Identity;
using System.Security.Claims;
using X.PagedList;

namespace HotelProject.Controllers
{
    public class HotelController : Controller
    {
        private readonly UserManager<User> _userManager;
        private readonly UserDbContext _context;

        public HotelController(UserDbContext context, UserManager<User> userManager)
        {
            _context = context;
            _userManager = userManager;
        }

        [Authorize]
        public IActionResult Index(int page = 1, int pageSize = 10)
        {
            var hotels = _context.Hotels.OrderBy(h => h.Id);
            var pagedHotels = hotels.ToPagedList(page, pageSize);

            return View(pagedHotels);
        }

        public IActionResult Details(int id)
        {
            var userId = User.FindFirstValue(ClaimTypes.NameIdentifier);
            if (userId == null)
            {
                return View();
            }

            var hotelId = _context.Hotels.FirstOrDefault(h => h.Id == id);

            if (hotelId == null)
            {
                return NotFound();
            }

            var userHotelInteraction = new UserHotelInteraction
            {
                HotelId = id,
                UserId = userId,
                TimeStamp = DateTime.Now
            };

            _context.UserHotelInteractions.Add(userHotelInteraction);
            _context.SaveChanges();

            return View(hotelId);
        }

        [HttpPost]
        public IActionResult Rate(int hotelId, int rating)
        {
            var userId = User.FindFirstValue(ClaimTypes.NameIdentifier);

            var existingRating = _context.HotelRatings
                .FirstOrDefault(hr => hr.HotelId == hotelId && hr.UserId == userId);

            if (existingRating != null) 
            {
                existingRating.RatingValue = rating;
            } 
            else 
            {
                var hotelRating = new HotelRating
                {
                    HotelId = hotelId,
                    UserId = userId,
                    RatingValue = rating
                };

                _context.HotelRatings.Add(hotelRating);
            }

            int savedChanges = _context.SaveChanges();

            if (savedChanges > 0)
            {
                // SaveChanges was successful, return a JSON response with success flag
                return Json(new { success = true, message = "Rating submitted successfully" });
            }
            else
            {
                // SaveChanges was not successful, return a JSON response with an error message
                return Json(new { success = false, message = "Failed to submit rating" });
            }
        }
    }
}

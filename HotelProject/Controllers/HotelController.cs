using HotelProject.Models;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Identity;
using System.Security.Claims;

namespace HotelProject.Controllers
{
    public class HotelController : Controller
    {
        private readonly UserManager<User> _userManager;
        private readonly HotelDbContext _context;

        public HotelController(HotelDbContext context, UserManager<User> userManager)
        {
            _context = context;
            _userManager = userManager;
        }

        [Authorize]
        public IActionResult Index(string searchTerm)
        {
            var query = _context.Hotels.AsQueryable();

            if (!string.IsNullOrWhiteSpace(searchTerm))
            {
                query = query.Where(h => h.Name != null && h.Name.Contains(searchTerm));
            }

            var hotels = query.ToList();
            return View(hotels);
        }

        public IActionResult Details(int id)
        {
            UserHotelInteraction userHotelInteraction = new UserHotelInteraction();

            userHotelInteraction.HotelId = id;
            userHotelInteraction.UserId = User.FindFirstValue(ClaimTypes.NameIdentifier);
            if (userHotelInteraction.UserId == null)
            {
                return View();
            }
            userHotelInteraction.setTimeStampNow();

            var hotel = _context.Hotels.FirstOrDefault(h => h.Id == id);

            if (hotel == null)
            {
                return NotFound();
            }

            return View(hotel);
        }
    }
}

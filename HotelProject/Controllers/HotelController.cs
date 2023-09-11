using HotelProject.Models;
using Microsoft.AspNetCore.Mvc;

namespace HotelProject.Controllers
{
    public class HotelController : Controller
    {
        private readonly HotelDbContext _context;

        public HotelController(HotelDbContext context)
        {
            _context = context;
        }

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

    }
}

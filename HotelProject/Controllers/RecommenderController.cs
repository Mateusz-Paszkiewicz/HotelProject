using Microsoft.AspNetCore.Mvc;
using HotelRecommender;
using HotelProject.Models;
using Microsoft.AspNetCore.Identity;
using System.Security.Claims;
using Microsoft.AspNetCore.Authorization;

namespace HotelProject.Controllers
{
    public class RecommenderController : Controller
    {
        private readonly UserManager<User> _userManager;
        private readonly UserDbContext _context;

        public RecommenderController(UserDbContext context, UserManager<User> userManager)
        {
            _context = context;
            _userManager = userManager;
        }

        [Authorize]
        [HttpGet]
        public IActionResult Index()
        {
            return View();
        }

        [Authorize]
        [HttpPost]
        public IActionResult ProcessHotelPreferences(HotelPreferencesViewModel model)
        {
            return RedirectToAction("Predict", model);
        }

        [Authorize]
        [HttpGet]
        public IActionResult Predict(HotelPreferencesViewModel model)
        { 
            var userId = User.FindFirstValue(ClaimTypes.NameIdentifier);
            var hotels = _context.Hotels.OrderBy(h => h.Id).ToList();
            var hotelRatings = new List<(Hotel Hotel, float PredictedRating)>();

            foreach (var h in hotels)
            {
                var predictionInput = new HotelRecommenderCollab.ModelInput()
                {
                    HotelId = h.Id,
                    UserId = @"009adf28-bdc3-47ae-ab0d-df272291595c",
                };

                var result = HotelRecommenderCollab.Predict(predictionInput);

                hotelRatings.Add((h, result.Score));
            }

            var topRecommendedHotels = hotelRatings.OrderByDescending(r => r.PredictedRating).Take(30).ToList();

            return View(topRecommendedHotels);
        }
    }
}
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
            /*var user = _context.Users.FirstOrDefault(h => h.Id == "009adf28-bdc3-47ae-ab0d-df272291595c");
            Console.Write(user.Email);
            user.PasswordHash = null;

            _context.SaveChanges();*/

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
        public IActionResult Predict(HotelPreferencesViewModel hotelPreferences)
        { 
            var userId = User.FindFirstValue(ClaimTypes.NameIdentifier);
            var hotels = _context.Hotels.OrderBy(h => h.Id).ToList();
            var hotelRatings = new List<(Hotel Hotel, float PredictedRating)>();

            foreach (var h in hotels)
            {
                var predictionInput = new HotelRecommenderCollab.ModelInput()
                {
                    HotelId = h.Id,
                    UserId = /*userId*/ @"009adf28-bdc3-47ae-ab0d-df272291595c",
                };

                var result = HotelRecommenderCollab.Predict(predictionInput);

                hotelRatings.Add((h, result.Score));
            }

            var topRecommendedHotels = hotelRatings.OrderByDescending(r => r.PredictedRating).Take(30).ToList();

            var finalPredictedRatings = new List<(Hotel Hotel, double HotelRating)>();

            foreach (var item in topRecommendedHotels)
            {
                var ratingContentBased = 10 - (Math.Abs(hotelPreferences.Price - (item.Hotel.Price/item.Hotel.PriceNight))) * 0.01
                                            - (Math.Abs(hotelPreferences.Stars - item.Hotel.Stars)) * 1
                                            - (Math.Abs(hotelPreferences.DistanceToCenter - item.Hotel.DistanceToCenter)) * 0.01
                                            - (Math.Abs(hotelPreferences.DistanceToPOI - item.Hotel.DistanceToPOI)) * 0.01;

                var finalPredictedRating = (item.PredictedRating + ratingContentBased) / 2;
                finalPredictedRatings.Add((item.Hotel, finalPredictedRating));
            }

            finalPredictedRatings = finalPredictedRatings.OrderByDescending(r => r.HotelRating).Take(5).ToList();

            return View(finalPredictedRatings);
        }
    }
}
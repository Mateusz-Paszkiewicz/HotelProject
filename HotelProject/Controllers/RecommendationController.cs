using HotelProject.Models;
using Microsoft.AspNetCore.Mvc;

namespace HotelProject.Controllers
{
    public class RecommendationController : Controller
    {
        public IActionResult Index()
        {
            var userProfile = new UserProfile();

            return View(userProfile);
        }
        [HttpPost]
        public IActionResult Submit(UserProfile userProfile) 
        {
            return View("Submit", userProfile);
        }
    }
}

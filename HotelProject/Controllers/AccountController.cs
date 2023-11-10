using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Identity;
using HotelProject.Models;
using AutoMapper;
using Microsoft.AspNetCore.Authentication;
using System.Security.Claims;

namespace HotelProject.Controllers
{
    public class AccountController : Controller
    {
        private UserDbContext _context;
        private readonly IMapper _mapper;
        private readonly UserManager<User> _userManager;
        private readonly SignInManager<User> _signInManager;
        public AccountController(IMapper mapper, UserManager<User> userManager, SignInManager<User> signInManager, UserDbContext context)
        {
            _context = context;
            _mapper = mapper;
            _userManager = userManager;
            _signInManager = signInManager;
        }

        [HttpGet]
        public IActionResult Register()
        {
            return View();
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> RegisterAsync(UserRegistrationModel userModel)
        {
            if (!ModelState.IsValid)
            {
                return View(userModel);
            }
            var user = _mapper.Map<User>(userModel);
            var result = await _userManager.CreateAsync(user, userModel.Password);
            if (!result.Succeeded)
            {
                foreach (var error in result.Errors)
                {
                    ModelState.TryAddModelError(error.Code, error.Description);
                }
                return View(userModel);
            }
            await _userManager.AddToRoleAsync(user, "User");
            return RedirectToAction(nameof(HomeController.Index), "Home");
        }

        [HttpGet]
        public IActionResult Login(string? returnUrl)
        {
            ViewData["ReturnUrl"] = returnUrl;
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Login(UserLoginModel userModel, string? returnUrl)
        {
            if (!ModelState.IsValid)
            {
                return View(userModel);
            }

            // THIS IS A WORKAROUND
            var user = _context.Users.FirstOrDefault(h => h.Id == "");

            //var result = await _signInManager.PasswordSignInAsync(userModel.Email, userModel.Password, userModel.RememberMe, false);
            await _signInManager.SignInAsync(user, false, null);

            if (result.Succeeded)
            {
                if (string.IsNullOrEmpty(returnUrl))
                {
                    return RedirectToAction(nameof(HomeController.Index), "Home");
                }
                else
                {
                    return RedirectToLocal(returnUrl);
                }
            }
            else
            {
                ModelState.AddModelError("", "Invalid UserName or Password");
                return View();
            }
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Logout()
        {
            await _signInManager.SignOutAsync();
            return RedirectToAction(nameof(HomeController.Index), "Home");
        }

        private IActionResult RedirectToLocal(string returnUrl)
        {
            if (Url.IsLocalUrl(returnUrl))
                return Redirect(returnUrl);
            else
                return RedirectToAction(nameof(HomeController.Index), "Home");

        }
    }
}

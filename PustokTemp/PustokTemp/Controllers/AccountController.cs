using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using PustokTemp.ViewModels;
using PustokTemp.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PustokTemp.Controllers
{
    public class AccountController : Controller
    {
        private readonly UserManager<AppUser> _userManager;
        private readonly SignInManager<AppUser> _signInManager;

        public AccountController(UserManager<AppUser> userManager, SignInManager<AppUser> signInManager)
        {
            _userManager = userManager;
            _signInManager = signInManager;
        }
        public IActionResult Register()
        {
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Register(MemberRegisterViewModel registerVM)
        {
            if (!ModelState.IsValid) return View();

            AppUser member = await _userManager.FindByNameAsync(registerVM.UserName);

            if (member != null)
            {
                ModelState.AddModelError("UserName", "UserName already taken!");
                return View();
            }

            member = await _userManager.FindByEmailAsync(registerVM.Email);
            if (member != null)
            {
                ModelState.AddModelError("Email", "Email already taken!");
                return View();
            }

            member = new AppUser
            {
                Fullname = registerVM.FullName,
                UserName = registerVM.UserName,
                Email = registerVM.Email
            };

            var result = await _userManager.CreateAsync(member, registerVM.Password);

            if (!result.Succeeded)
            {
                foreach (var error in result.Errors)
                {
                    ModelState.AddModelError("", error.Description);
                }

                return View();
            }

            var roleResult = await _userManager.AddToRoleAsync(member, "Member");
            await _signInManager.SignInAsync(member, true);

            return RedirectToAction("index", "home");
        }

        public IActionResult Login()
        {
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]

        public async Task<IActionResult> Login(MemberLoginViewModel loginVM)
        {
            if (!ModelState.IsValid) return View();


            AppUser member = _userManager.Users.FirstOrDefault(x => x.UserName == loginVM.UserName && x.IsAdmin == false);

            if (member == null)
            {
                ModelState.AddModelError("", "istifadeci adi ve ya sifre yanlisdir!");
                return View();
            }

            var result = await _signInManager.PasswordSignInAsync(member, loginVM.Password, loginVM.IsPersistent, false);

            if (!result.Succeeded)
            {
                ModelState.AddModelError("", "istifadeci adi ve ya sifre yanlisdir!");
                return View();
            }

            return RedirectToAction("index", "home");

        }

        public async Task<IActionResult> Logout()
        {
            await _signInManager.SignOutAsync();

            return RedirectToAction("index", "home");
        }
    }
}

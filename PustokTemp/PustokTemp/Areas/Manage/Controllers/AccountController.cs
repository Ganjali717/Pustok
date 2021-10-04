using System;
using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Identity;
using PustokTemp.Models;
using PustokTemp.Areas.Manage.ViewModels;

namespace PustokTemp.Areas.Manage.Controllers
{
    [Area("manage")]
    public class AccountController:Controller
    {
        private readonly UserManager<AppUser> _userManager;
        private readonly RoleManager<IdentityRole> _roleManager;
        private readonly SignInManager<AppUser> _signInManager;

        public AccountController(UserManager<AppUser> userManager, RoleManager<IdentityRole> roleManager, SignInManager<AppUser> signInManager)
        {
            _userManager = userManager;
            _roleManager = roleManager;
            _signInManager = signInManager;
        }


        public async Task<IActionResult> Index()
        {
            /*    AppUser admin = new AppUser
                {
                    UserName = "SuperAdmin",
                    Fullname = "Ganjali Imanov"
                };

                var result = await _userManager.CreateAsync(admin, "genceli");

                List<string> errors = new List<string>();   
                if (!result.Succeeded)
                {
                    foreach (var item in result.Errors)
                    {
                        errors.Add(item.Description);
                    }

                    return Ok(errors);
                }*/


            //IdentityRole role1 = new IdentityRole("SuperAdmin");
            //await _roleManager.CreateAsync(role1);

            //IdentityRole role2 = new IdentityRole("Admin");
            //await _roleManager.CreateAsync(role2);

            //IdentityRole role3 = new IdentityRole("Member");
            //await _roleManager.CreateAsync(role3);

            /*  AppUser appUser = await _userManager.FindByNameAsync("SuperAdmin");
              await _userManager.AddToRoleAsync(appUser, "SuperAdmin");*/




            return View();
        }

        public IActionResult Login()
        {
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Login(LoginViewModel loginVM)
        {
            if (!ModelState.IsValid) return View();

            AppUser admin = _userManager.Users.FirstOrDefault(x => x.UserName == loginVM.UserName  && x.IsAdmin == true);

            if (admin == null)
            {
                ModelState.AddModelError("", "istifadeci adi ve ya sifre yanlisdir!");
                return View();
            }

            var result = await _signInManager.PasswordSignInAsync(admin, loginVM.Password, loginVM.IsPersistent, false);

            if (!result.Succeeded)
            {
                ModelState.AddModelError("", "istifadeci adi ve ya sifre yanlisdir!");
                return View();
            }

            return RedirectToAction("index", "dashboard");
        }
    }
}

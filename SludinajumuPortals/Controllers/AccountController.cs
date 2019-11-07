using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using SludinajumuPortals; //ja kas, >>
using SludinajumuPortals.Logic;
using SludinajumuPortals.Models;

namespace SludinajumuPortals.Controllers
{
    public class AccountController : Controller
    {
        UserManager _users;
        AdManager _ads;

        public AccountController(UserManager manager, AdManager adManager)
        {
            _users = manager;
            _ads = adManager;
        }
       
        public IActionResult SignIn()
        {
            return View();
        }
        public IActionResult SignUp()
        {
            return View();
        }

        [HttpPost]
        public IActionResult SignUp(UserModel model)
        {
            if (ModelState.IsValid)
            {

                if (_users.GetByEmail(model.Email) != null)
                {
                    ModelState.AddModelError("error", "Šāds epasts jau eksistē!");
                }
                else
                {
                    _users.Create(new Logic.User()
                    {
                        Email = model.Email,
                        Password = model.Password
                    });

                    TempData["message"] = "Konts izveidots!";
                    return RedirectToAction("SignIn");
                }
            }
            return View();
        }
        [HttpPost]
        public IActionResult SignIn(UserModel model)
        {
            
            if (ModelState.IsValid)
            {
                var user = _users.GetByEmailAndPassword(model.Email, model.Password);

                if (user == null)
                {
                    ModelState.AddModelError("error", "Email not found!");
                }

                else
                {
                    HttpContext.Session.SetUserId(user.Id);
                    HttpContext.Session.SetUserEmail(user.Email);

                    
                    return RedirectToAction("Index", "Home");
                }
            }

            return View();
        }
        public IActionResult SignOut()
        {
            HttpContext.Session.Clear();

            return RedirectToAction("Index", "Home"); 
        }

        public IActionResult MyAds()
        {
            var ads = _ads.GetByUser(HttpContext.Session.GetUserEmail());

            return View(ads);
        }
    }
}
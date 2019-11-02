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
        UserManager manager = new UserManager();
       
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
                UserManager manager = new UserManager();

                if (manager.GetByEmail(model.Email) != null)
                {
                    ModelState.AddModelError("error", "Šāds epasts jau eksistē!");
                }
                else
                {
                    manager.Create(new Logic.User()
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
                var user = manager.GetByEmailAndPassword(model.Email, model.Password);

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
    }
}
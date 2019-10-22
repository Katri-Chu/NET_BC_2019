using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using WebShop.Logic;
using WebShop.Models;

namespace WebShop.Controllers
{
    public class AccountController : Controller
    {
        public IActionResult Index()
        {
            var manager = new UserManager();
            manager.Seed();
            
            return View();
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
        public IActionResult SignUp (UserModel model)
        {
            if(ModelState.IsValid)
            {
                UserManager manager = new UserManager();

                if (manager.GetByEmail(model.Email) != null)
                {
                    ModelState.AddModelError("error", "Email already exists!");
                }
                else
                {
                    manager.Create(new Logic.User()
                    {
                        Email = model.Email,
                        Password = model.Password
                    });

                    TempData["message"] = "Account created!";  //temporary data (pagaidu paziņojumi)
                    return RedirectToAction("SignIn");
                }
            }
            return View();
        }
        [HttpPost]
        public IActionResult SignIn(UserModel model)
        {
            ModelState.Remove("PasswordRepeat");
            if (ModelState.IsValid)
            {
                UserManager manager = new UserManager();

                if (manager.GetByEmailAndPassword(model.Email, model.Password) == null)
                {
                    ModelState.AddModelError("error", "Email not found!");
                }
                //else if() //password
                //{
                //    ModelState.AddModelError("error", "Password incorrect!");
                //}
                
                else
                {
                    
                    TempData["message1"] = "You are signed in!";  //temporary data (pagaidu paziņojumi)
                    return RedirectToAction("Index", "Home");
                }
            }

            return View();
        }
    }
}
using loginproject_new.Models;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace loginproject_new.Controllers
{
    public class logincontroller : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult ProcessLogin(usermodel usermodel)
        {
            if (usermodel.username == "serhat" && usermodel.password == "demir")
            {
                return View("Login Success", usermodel);
            }
            else
            {
                return View("Login Failure", usermodel);
            }
            
        }
    }
}

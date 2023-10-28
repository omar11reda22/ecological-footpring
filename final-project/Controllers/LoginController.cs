using Microsoft.AspNetCore.Mvc;
using System.Data;
using System.Data.SqlClient;
using System.Collections.Generic;
using System.Linq;
using final_project.Models;
using final_project.myContext;
using final_project.viewmodel;

namespace final_project.Controllers
{
    public class LoginController : Controller
    {
        [HttpGet]
        public IActionResult Index()
        {

            return View();
        }
        public IActionResult checklol(User user)
        {
            ITIContext contextcontext = new ITIContext();
            var data = contextcontext.users.Where(x => x.Email == user.Email && x.Password == user.Password).Count();
            if(data > 0)
            {
                RedirectToAction("Home" , "Home");
            }
            else
            {
                return View();
            }
            return View();
        }
        [HttpGet]
        public IActionResult register()
        {

            return View();
        }
        [HttpPost]
        public IActionResult saveregister(User user )
        {
            ITIContext context = new ITIContext();

           
            


            try
            {
                if(ModelState.IsValid)
                {
                    context.users.Add(user);
                    context.SaveChanges();
                    return RedirectToAction("Index");
                }
            }
            catch (Exception ex) { }
            return RedirectToAction("register");

        }
    }
}

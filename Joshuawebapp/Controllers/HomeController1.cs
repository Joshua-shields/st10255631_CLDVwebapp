using Microsoft.AspNetCore.Mvc;

namespace Joshuawebapp.Controllers
{
    public class HomeController1 : Controller
    { 
        public userTable ustbl = new userTable();

        public ActionResult About(userTable Users)
        {
            var results = usrtbl.insert_User(User);
            return RedirectToAction("index", "Home");

        }
        public IActionResult About()
        {
            return View(usrtbl);
        }
    }
}

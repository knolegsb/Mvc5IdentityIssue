using Mvc5IdentityIssue.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Mvc5IdentityIssue.Controllers
{
    public class UserController : Controller
    {
        // GET: User
        public ActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public JsonResult Register(LoginUser u)
        {
            string message = "";
            if (ModelState.IsValid)
            {
                using (ApplicationDbContext db = new ApplicationDbContext())
                {                  
                    var user = db.LoginUsers.Where(a => a.Username.Equals(u.Username)).FirstOrDefault();
                    if (user == null)
                    {
                        db.LoginUsers.Add(u);
                        db.SaveChanges();
                        message = "Success";
                    }
                    else
                    {
                        message = "Username is not available!";
                    }
                }
            }
            else
            {
                message = "Failed!";
            }
            return new JsonResult { Data = message, JsonRequestBehavior = JsonRequestBehavior.AllowGet };
        }
    }
}
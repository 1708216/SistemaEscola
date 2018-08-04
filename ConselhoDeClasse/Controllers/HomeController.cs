using Microsoft.AspNet.Identity;
using Microsoft.AspNet.Identity.Owin;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;


namespace ConselhoDeClasse.Controllers
{

    //incorporei a anotação para só permitir acesso de pessoas logadas no sistema.
 
    [Authorize(Roles ="admin,user")]
    public class HomeController : Controller
    {
      
        public ActionResult Index()
        {
            var userManager = HttpContext.GetOwinContext().GetUserManager<ApplicationUserManager>();
            if (userManager.IsInRole(User.Identity.GetUserId(), "admin"))
            {
                return View();
            }
            return View("IndexProfessor");
        }
     
        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }
     
        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
    }
}
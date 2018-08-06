using ConselhoDeClasse.Models;
using ConselhoDeClasse.Models.Dal;
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

        public MeuContexto Contexto = new MeuContexto(); 

        public ActionResult Index()
        {
            var userManager = HttpContext.GetOwinContext().GetUserManager<ApplicationUserManager>();
            var userId = HttpContext.User.Identity.GetUserId();
            var user = (new ApplicationDbContext()).Users.FirstOrDefault(s => s.Id == userId);
            string matricula = user.Matricula;

            var TurmasProfessor = from f in Contexto.Professores
                                  where f.Matricula.Equals(matricula)
                                  select f;

            if (userManager.IsInRole(User.Identity.GetUserId(), "admin"))
            {
                return View();
            }
            return View("IndexProfessor",TurmasProfessor);
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
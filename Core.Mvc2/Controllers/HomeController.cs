using Core.BO;
using Core.Entity.Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Core.Mvc.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            UsuarioBO b = new UsuarioBO();
            UsuarioEntidade user = new UsuarioEntidade();
            user.Nome = "jose da silva";
            user.Cpf = "0245154-14";
            user.UserName = "jose";
            user.Senha = "123456";

            try
            {
                b.Insert(user);

            }
            catch (Exception ex)
            {

               
            }

            return View();
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
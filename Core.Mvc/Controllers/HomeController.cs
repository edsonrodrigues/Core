using Core.BO.Layout;
using Core.Entity.Entidades.Layout;
using Core.Mvc.DAO;
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
            NoticiaBO bo = new NoticiaBO();
            List<NoticiaEntidade> lst = bo.SelectAll().Where(p => p.Tipo != 1).ToList();
            ViewBag.Noticias = lst;

            MenuDAO menuDAO = new MenuDAO();
            ViewBag.Menus = menuDAO.Lista();

     

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
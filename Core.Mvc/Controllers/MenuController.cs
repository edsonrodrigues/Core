using Core.Mvc.DAO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Core.Mvc.Controllers
{
    public class MenuController : Controller
    {
        //
        //Menu vertical

        public ActionResult Index()
        {           
            MenuDAO menuDAO = new MenuDAO();
            ViewBag.Menus = menuDAO.Lista();

            return View();
        }

    }
}

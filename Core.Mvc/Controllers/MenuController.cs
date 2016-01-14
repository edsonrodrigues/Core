using Core.BO.Layout;
using Core.Entity.Entidades.Layout;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Core.Mvc.Models.Grids;
using Core.Mvc.DAO;

namespace Core.Mvc.Controllers
{
    public class MenuController : Controller
    {

        MenuBO bo = new MenuBO();
       
        #region List
        public ActionResult Index()
        {
            var menus = bo.SelectAll().ToList();
                        
            ViewBag.Menus = bo.SelectAll().ToList();

            return View(menus);
        }


        public ViewResult Details(int id)
        {
            MenuEntidade menu = bo.SelectById(id);

            return View(menu);
        }
        #endregion

        #region Create 
        public ActionResult Create()
        {
            return View(new MenuEntidade());
        }

        [HttpPost]
        public ActionResult Create(MenuEntidade menu)
        {
            bo.Insert(menu);
            return RedirectToAction("Index");
        }
        #endregion
        #region Edit Noticia 
        public ActionResult Edit(int id)
        {
            MenuEntidade menu = bo.SelectById(id);
            return View(menu);
        }
        [HttpPost]
        public ActionResult Edit(MenuEntidade menu)
        {
            MenuEntidade not = bo.SelectById(menu.Id);
            if (not != null)
            {
                not.Status = menu.Status;
                not.SubMenu = menu.SubMenu;
                not.Nome = menu.Nome;
                not.Url = menu.Url;
                bo.Edit(not);

                return RedirectToAction("Index");
            }
            return View(menu);
        }
        #endregion
        #region Delete noticia 
        public ActionResult Delete(int id)
        {
            MenuEntidade menu = bo.SelectById(id);
            bo.Delete(menu);
            return RedirectToAction("Index");
        }

        #endregion

    }
}

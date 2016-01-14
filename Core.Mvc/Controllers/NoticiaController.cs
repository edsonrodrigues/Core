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
    public class NoticiaController : Controller
    {
        
        NoticiaBO bo = new NoticiaBO();
        public NoticiaController()
        {
            
        }
        #region List and Details noticia
        public ActionResult Index()
        {
            var noticias = bo.SelectAll().ToList();
            MenuDAO menuDAO = new MenuDAO();
            ViewBag.Menus = menuDAO.Lista();
            return View(noticias);
        }

 
        public ViewResult Details(int id)
        {
            NoticiaEntidade noticia = bo.SelectById(id);
            
            return View(noticia);
        }
        #endregion

        #region Create 
        public ActionResult Create()
        {
            return View(new NoticiaEntidade());
        }

        [HttpPost]
        public ActionResult Create(NoticiaEntidade noticia)
        {
            bo.Insert(noticia);
            return RedirectToAction("Index");
        }
        #endregion
        #region Edit Noticia 
        public ActionResult Edit(int id)
        {
            NoticiaEntidade noticia = bo.SelectById(id);
            return View(noticia);
        }
        [HttpPost]
        public ActionResult Edit(NoticiaEntidade noticia)
        {
            NoticiaEntidade not = bo.SelectById(noticia.Id);
            if (not != null)
            {
                not.Status = noticia.Status;
                not.Texto = noticia.Texto;
                not.Tipo = noticia.Tipo;
                not.Titulo = noticia.Titulo;
                not.Url = noticia.Url;
                bo.Edit(not);

                return RedirectToAction("Index");
            }
            return View(noticia);
        }
        #endregion
        #region Delete noticia 
        public ActionResult Delete(int id)
        {
            NoticiaEntidade noticia = bo.SelectById(id);
            bo.Delete(noticia);
            return RedirectToAction("Index");
        }

       #endregion
    
}
}

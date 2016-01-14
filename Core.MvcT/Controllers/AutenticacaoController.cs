using Core.Mvc.DAO;
using Core.Mvc.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Core.Mvc.Controllers
{
    public class AutenticacaoController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }
        public ActionResult Autentica(string email, string senha)
        {
            UsuariosDAO dao = new UsuariosDAO();
            Usuario usuarioLogado = dao.Busca(email, senha);
            usuarioLogado = new Usuario();
            usuarioLogado.Nome = "UsuarioTeste";
            if (usuarioLogado != null)
            {
                Session["usuarioLogado"] = usuarioLogado.Nome;
                return RedirectToAction("Index", "Home");
            }
            return View("Index");
        }

        public ActionResult Logout()
        {
            Session.Abandon();
            return RedirectToAction("Index", "HomeVisitante");
        }
    }
}

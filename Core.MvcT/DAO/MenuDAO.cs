using Core.Mvc.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Core.Mvc.DAO
{
    public class MenuDAO
    {
        public IList<Menu> Lista()
        {
            return new List<Menu>()
            {
                NovoMenu("Cadastros","Noticias", "Pessoas", "Paginas", "Equipamentos"),
                NovoMenu("Fianceiro", "Consultas", "relatorios", "projetos", "pendencias"),
                NovoMenu("Clientes", "Agenda", "previsoes"),
                NovoMenu("Configuracoes", "Perfil", "Usuarios", "Acessos", "historicos", "etc")
            };
        }

        private Menu NovoMenu(string nome, params string[] SubMenus)
        {
            Menu menu = new Menu();
            menu.Nome = nome;
            foreach (string nomeSubMenu in SubMenus)
            {
                Menu submenu = new Menu();
                submenu.Nome = nomeSubMenu;
                menu.SubMenu.Add(submenu);
            }
            return menu;
        }
    }
}
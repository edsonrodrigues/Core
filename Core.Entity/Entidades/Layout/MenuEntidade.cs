using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Core.Entity.Entidades.Layout
{
    public class MenuEntidade : BaseEntity
    {
        public string Nome { get; set; }

        public string Descricao { get; set; }

        public string UrlPag { get; set; }
        
        public IList<MenuEntidade> SubMenu { get; set; }

        public MenuEntidade()
        {
            SubMenu = new List<MenuEntidade>();
        }
    }
    
}
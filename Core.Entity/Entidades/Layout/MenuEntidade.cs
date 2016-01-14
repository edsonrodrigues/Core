using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace Core.Entity.Entidades.Layout
{
    public class MenuEntidade : BaseEntity
    {
        public string Nome { get; set; }

        public string Descricao { get; set; }

        public string Url { get; set; }

        public int? ParentId { get; set; }

        public MenuEntidade SubMenu { get; set; }

        public MenuEntidade()
        {
            //SubMenu = new List<MenuEntidade>();
        }
    }
    
}
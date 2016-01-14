using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Core.Mvc.Models
{
    public class Menu
    {
        public string Nome { get; set; }

        public string Descricao { get; set; }

        public string Url { get; set; }
        
        public IList<Menu> SubMenu { get; set; }

        public Menu()
        {
            SubMenu = new List<Menu>();
        }
    }
    
}
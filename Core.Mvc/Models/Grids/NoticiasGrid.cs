using Core.Entity.Entidades.Layout;
using GridMvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using GridMvc.Pagination;

namespace Core.Mvc.Models.Grids
{
    public class NoticiasGrid : Grid<NoticiaEntidade>
    {
        public NoticiasGrid(IQueryable<NoticiaEntidade> items)
            : base(items)
        {
        }

    }
}
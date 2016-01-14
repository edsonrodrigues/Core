using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Entity.Entidades.Layout
{
   public class BannerEntidade : BaseEntity
    {
        public string Descicao { get; set; }
    
        public IList<ImagemEntidade> Imagens { get; set; }


    }
}

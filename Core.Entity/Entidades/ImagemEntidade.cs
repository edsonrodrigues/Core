using Core.Entity.Entidades.Layout;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Entity.Entidades
{
   public class ImagemEntidade : BaseEntity
    {
        public string Nome { get; set; }
        public string Descicao { get; set; }
        public string Diretorio { get; set; }

        public BannerEntidade Banner { get; set; }

    }
}

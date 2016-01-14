using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Core.Mvc.Models
{
   
    public class Noticia
    {

        public string Titulo { get; set; }

        public string Descricao { get; set; }

        public string Url { get; set; }


        public Noticia(string titulo, string descricao, string url)
        {
            this.Titulo = titulo;
            this.Descricao = descricao;
            this.Url = url;
        }
    }
}
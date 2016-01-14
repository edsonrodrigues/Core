using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Core.Entity.Entidades.Layout
{
   
    public class NoticiaEntidade : BaseEntity
    {
        public string Titulo { get; set; }

        public string Descricao { get; set; }

        public string Texto { get; set; }
        
        /// <summary>
        /// se é principal, secundaria
        /// </summary>
        public int Tipo { get; set; }

        /// <summary>
        /// as noticias podem ser de direcionadas a um usuario assim como aos visitantes
        /// </summary>
        //public UsuarioEntidade Usuario { get; set; }

        //public ImagemEntidade imagem { get; set; }

        public string Url { get; set; }


      /*  public NoticiaEntidade(string titulo, string descricao, string url)
        {
            this.Titulo = titulo;
            this.Descricao = descricao;
            this.Url = url;
        }*/
    }
}
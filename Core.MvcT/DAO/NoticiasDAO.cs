using Core.Mvc.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Core.Mvc.DAO
{
   
    public class NoticiasDAO
    {
        public IList<Noticia> Ultimas()
        {
            return new List<Noticia>() {
                new Noticia("Novidades", "Pode ser informado novidades ordenando por data de publicacao!","/Home/"),
                new Noticia("Noticias", " este campo devera conter uma breve descricao, imagem e link para a materia completa","/Home/"),
                new Noticia("Titulo 1", "descricao, desc auhuna uhauhan uhbau buahubau hub uab s ","/Home/")
           
            };
        }
    }
}
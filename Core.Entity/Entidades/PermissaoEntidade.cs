using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace Core.Entity.Entidades
{
    public class PermissaoEntidade
        {
            public int Id { get; set; }

            [Required(ErrorMessage = "Campo perfil é obrigatório.")]
            [Display(Name = "Perfil")]
            public string Nome { get; set; }

            [Required(ErrorMessage = "Campo obrigatório.")]
            [Display(Name = "Aplicação")]
            public int ApplicationId { get; set; }
            public virtual AplicacaoEntidade Aplicacao { get; set; }

            public virtual IList<UsuarioEntidade> Usuarios { get; set; }
        }
               
}

using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace Core.Entity.Entidades
{
    public class AplicacaoEntidade : BaseEntity
    {
        [Required(ErrorMessage = "Campo obrigatório.")]
        [Display(Name = "Aplicação")]
        public string Name { get; set; }

        public virtual IList<PermissaoEntidade> Permissoes { get; set; }

        
    }
}

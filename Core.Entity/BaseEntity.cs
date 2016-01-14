using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;



namespace Core.Entity
{
    public abstract class BaseEntity 
    {
        public int Id { get; set; }
        public bool? Status { get; set; }
        public DateTime? Dt_Criacao { get; set; }
        
        public BaseEntity()
        {
            this.Id = 0;
            this.Status = true;
            this.Dt_Criacao = DateTime.Now.Date;
        }

    }
}

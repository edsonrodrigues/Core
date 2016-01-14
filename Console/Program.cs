using Core.BO;
using Core.Entity.Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Console
{
    class Program
    {
        static void Main(string[] args)
        {

            UsuarioBO b = new UsuarioBO();

            UsuarioEntidade user = new UsuarioEntidade();
            user.Nome = "teste jose da silva";
            user.Cpf = "0245154-14";
            user.UserName = "jose";
            user.Senha = "123456";

            try
            {
                b.Insert(user);
               
            }
            catch (Exception ex)
            {

               
            }
           

        }
    }
}

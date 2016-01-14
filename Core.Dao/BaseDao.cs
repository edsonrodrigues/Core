using Core.Dao.Interface;
using Core.Entity;
using System.Linq;

namespace Core.Dao
{
    public class BaseDao<TEntity>
        where TEntity : BaseEntity
    {

        public BaseDao()
        {
            Context = new ContextFactory().GetContext();
            Repositorio = new Repositorio<TEntity>(Context);
        }

        public DatabaseContext Context { get; set; }
        internal IRepositorio<TEntity> Repositorio { get; set; }

        #region Crud

        public void Insert(TEntity T)
        {
            Repositorio.Inserir(T);

        }

        public void Delete(TEntity T)
        {

            Repositorio.Deletar(T);

        }

        public void Edit(TEntity T)
        {
            Repositorio.Editar(T);

        }

        public TEntity SelectById(int id)
        {

            return Repositorio.SelecionarPorId(id);

        }

        public IQueryable<TEntity> SelectAll()
        {

            return Repositorio.SelecionarTodos();

        }

        #endregion


    }
}

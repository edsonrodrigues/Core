using Core.Dao.Interface;
using System.Data;
using System.Data.Entity;
using System.Linq;

namespace Core.Dao
{
    public class Repositorio<T> : IRepositorio<T> where T : class
    {

        protected readonly DbContext _context;


        public Repositorio(DbContext contexto)
        {
            _context = contexto;
            _context.SaveChanges();
        }


        public T SelecionarPorId(int id)
        {
            return _context.Set<T>().Find(id);
            
        }

        public IQueryable<T> SelecionarTodos()
        {
            return _context.Set<T>();
            
        }

        public void Inserir(T item)
        {
            _context.Set<T>().Add(item);
            _context.SaveChanges();
        }

        public void Deletar(T item)
        {
            _context.Set<T>().Remove(item);
            _context.SaveChanges();
        }

        public void Editar(T item)
        {
            _context.Entry(item).State = System.Data.Entity.EntityState.Modified;
            _context.SaveChanges();
        }

        public void Dispose()
        {
            _context.Dispose();
        }
               
    }
}

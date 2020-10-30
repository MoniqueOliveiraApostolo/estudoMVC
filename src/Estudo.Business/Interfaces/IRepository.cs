using AppMvcBasica.Models;
using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace Estudo.Business.Interfaces
{
    public interface IRepository<T> : IDisposable where T : Entity
    {
        Task Insert(T obj);
        Task<T> GetById(Guid id);
        Task<List<T>> GetAll();
        Task Update(T obj);
        Task Delete(Guid id);
        Task<IEnumerable<T>> Find(Expression<Func<T, bool>> predicate);
        Task<int> SaveChanges();
    }
}
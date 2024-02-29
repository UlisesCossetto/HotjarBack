using Hotjar.Core.Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hotjar.Core.Interfaces.Repositories
{
    public interface IRepository<T> where T : EntidadBase
    {
        Task<IEnumerable<T>> GetAll();

        Task<T> GetById(int id);

        Task Add(T entity);

        void Update(T entity);

        Task Delete(int id);

        Task AddList(IEnumerable<T> entities);

        void UpdateList(IEnumerable<T> entity);
        IQueryable<T> GetAllQueries();
    }
}

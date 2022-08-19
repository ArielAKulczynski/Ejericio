using Ejercicio.Core.Repositorios.Base;
using Ejercicio.Infrastructure.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio.Infrastructure.Repositories.Base
{
   public class Repository<T>: IRepository<T> where T: class
    {
        protected readonly ApplicationContext _applicationContext;

        public Repository(ApplicationContext applicationContext)
        {
            _applicationContext = applicationContext;
        }
        public async Task<T> AddAsync(T entity)
        {
            await _applicationContext.Set<T>().AddAsync(entity);
            await _applicationContext.SaveChangesAsync();
            return entity;
        }
        public async Task DeleteAsync(T entity)
        {
            _applicationContext.Set<T>().Remove(entity);
            await _applicationContext.SaveChangesAsync();
        }
        public async Task<T>GetByIdAsync(int id)
        {
            return await _applicationContext.Set<T>().FindAsync(id);
        }
        public async Task UpdateAsync(T entity)
        {
            throw new NotImplementedException();
        }

    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using ShoeShop.Application.Repositories.Generic;

namespace ShoeShop.Infrastructure.Repositories
{
    public class GenericRepository<T> : IGenericRepository<T> where T : class
    {
        private ShoeShopDbContext _context;

        public GenericRepository(ShoeShopDbContext context)
        {
            _context = context;
        }
        public async Task<T> AddAsync(T entity)
        {
            try
            {
                await _context.AddAsync(entity);
                return entity;
            }
            catch (Exception)
            {

                throw;
            }
        }

        public async Task UpdateAsync(T entity)
        {
            _context.Entry(entity).State = EntityState.Modified;
        }

        public async Task DeleteAsync(T entity)
        {
            _context.Set<T>().Remove(entity);
        }

        public async Task<IQueryable<T>> GetAllAsync()
        {
            return _context.Set<T>();
        }

        public async Task<T> GetByIdAsync(dynamic id)
        {
            return await _context.Set<T>().FindAsync(id);
        }

        public async Task<bool> AddRangeAsync(IEnumerable<T> entities)
        {
            try
            {
                await _context.Set<T>().AddRangeAsync(entities);
                return true;
            }
            catch (Exception e)
            {
                return false;
            }
        }

        public async Task UpdateRangeAsync(IEnumerable<T> entities)
        {
            try
            {
                _context.Update(entities);
            }
            catch (Exception e)
            {
                var eMessage = e.Message;
            }
        }
    }
}

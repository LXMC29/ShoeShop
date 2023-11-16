﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShoeShop.Application.Repositories.Generic
{
    public interface IGenericRepository<T> where T : class
    {
        Task<T> AddAsync(T entity);
        Task UpdateAsync(T entity);
        Task DeleteAsync(T entity);
        Task<IQueryable<T>> GetAllAsync();
        Task<T> GetByIdAsync(dynamic id);

        // add list
        Task<bool> AddRangeAsync(IEnumerable<T> entities);
        //update list
        Task<bool> UpdateRangeAsync(IEnumerable<T> entities);
    }
}

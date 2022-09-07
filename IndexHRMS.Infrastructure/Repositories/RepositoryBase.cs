using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using IndexHRMS.Application.Interfaces;
using IndexHRMS.Entity.Entities;
using IndexHRMS.Infrastructure.Context;

namespace IndexHRMS.Infrastructure.Repositories
{
    public class RepositoryBase<T> : IAsyncRepository<T> where T : BaseEntity
    {
        protected readonly DataContext _context;

        public RepositoryBase(DataContext context)
        {
            _context = context;
        }
        public async Task<T> AddAsync(T entity)
        {
            try
            {
                _context.Set<T>().Add(entity);
                await _context.SaveChangesAsync();
                return entity;
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public async Task UpdateAsync(T entity)
        {
            _context.Entry(entity).State = EntityState.Modified;
            await _context.SaveChangesAsync();
        }

        public async Task DeleteAsync(T entity)
        {
            _context.Set<T>().Remove(entity);
            await _context.SaveChangesAsync();
        }

        public async Task<T> GetByIdAsync(string id)
        {
            return await _context.Set<T>().FindAsync(id);
        }

        public async Task<IReadOnlyList<T>> GetAllAsync()
        {
            return await _context.Set<T>().ToListAsync();
        }

        public async Task<IReadOnlyList<T>> GetAsync(Expression<Func<T, bool>> predicate)
        {
			try
			{
                return await _context.Set<T>().Where(predicate).ToListAsync();
			}
			catch (Exception ex)
			{
                throw ex;
			}
        }
        public async Task<string> GetIdAsync()
        {
            try
            {
                var idList = _context.Set<T>()
                    .Select(x => x.Id)
                    .ToList();
                return idList.Any() ? idList.Max(x => Convert.ToInt64(x) + 1).ToString() : "1";
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public async Task<string> CheckDb()
		{
            try
            {
                _context.Database.OpenConnection();
                _context.Database.CloseConnection();
                return "Connected";
            }
            catch (Exception ex)
            {
                return "Not Connected";
            }
        }
    }
}

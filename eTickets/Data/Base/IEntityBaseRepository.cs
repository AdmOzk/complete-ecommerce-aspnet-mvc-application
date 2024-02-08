using eTickets.Data;
using eTickets.Data.Services;
using Microsoft.AspNetCore.Mvc;
using eTickets.Data.Services;
using eTickets.Models;

namespace eTickets.Data.Base
{
    public interface IEntityBaseRepository<T> where T: class,IEntityBase,new()
    {
        Task<IEnumerable<T>> GetAllAsync();

        Task<T> GetByIdAsync(int id);

        Task AddAsync(T entity);

        Task UpdateAsync(int id, T entity);

        Task DeleteAsync(int id);



    }
}

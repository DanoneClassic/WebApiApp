using System.Collections.Generic;
using System.Threading.Tasks;
using WebApiApp.Domain.Entities;

namespace WebApiApp.Infrastructure.Repositories
{
    public interface IProductRepository
    {
        Task<Product> GetByIdAsync(int id);
        Task<IEnumerable<Product>> GetAllAsync();
        Task AddAsync(Product product);
        Task UpdateAsync(Product product);
        Task DeleteAsync(int id);
    }
}
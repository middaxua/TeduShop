using TeduShop.Data.Infrastructure;
using TeduShop.Model.Models;

namespace TeduShop.Data
{
    public interface IProductRepository
    {
    }

    public class ProductRepository : RepositoryBase<Product>, IProductRepository
    {
        public ProductRepository(IDbFactory dbFactory) : base(dbFactory)
        {
        }
    }
}
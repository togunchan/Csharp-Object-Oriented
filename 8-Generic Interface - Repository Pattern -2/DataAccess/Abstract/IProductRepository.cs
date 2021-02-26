using _8_Generic_Interface___Repository_Pattern__2.Entity;

namespace _8_Generic_Interface___Repository_Pattern__2.DataAccess.Abstract
{
    public interface IProductRepository: IRepository<Product>
    {
        Product[] GetProductByCategoryId(int id);

        Product[] GetPopularProducts();
 
    }
}
using _7_Interface___Repository_Pattern__1.Entity;

namespace _7_Interface___Repository_Pattern__1.DataAccess.Abstract
{
    public interface IProductRepository
    {
        Product GetById(int id);


        void Update(Product entity);


        void Create(Product entity);


        void Delete(int id);


        Product[] GetProductByCategoryId(int id);

    }
}
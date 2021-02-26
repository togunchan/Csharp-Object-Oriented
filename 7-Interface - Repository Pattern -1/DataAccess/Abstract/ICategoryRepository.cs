using _7_Interface___Repository_Pattern__1.Entity;

namespace _7_Interface___Repository_Pattern__1.DataAccess.Abstract
{
    public interface ICategoryRepository
    {
        void Create(Category entity);


        void Delete(int id);


        Product GetById(int id);


        Product[] GetProductByCategoryId(int id);


        void Update(Product entity);

    }
}
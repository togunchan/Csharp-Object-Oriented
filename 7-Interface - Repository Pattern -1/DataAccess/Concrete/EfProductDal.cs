using _7_Interface___Repository_Pattern__1.DataAccess.Abstract;
using _7_Interface___Repository_Pattern__1.Entity;

namespace _7_Interface___Repository_Pattern__1.DataAccess.Concrete
{
    public class EfProductDal : IProductRepository
    {
        public void Create(Product entity)
        {
            throw new System.NotImplementedException();
        }

        public void Delete(int id)
        {
            throw new System.NotImplementedException();
        }

        public Product GetById(int id)
        {
            throw new System.NotImplementedException();
        }

        public Product[] GetProductByCategoryId(int id)
        {
            throw new System.NotImplementedException();
        }

        public void Update(Product entity)
        {
            throw new System.NotImplementedException();
        }
    }
}
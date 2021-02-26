using System;
using _8_Generic_Interface___Repository_Pattern__2.DataAccess.Abstract;
using _8_Generic_Interface___Repository_Pattern__2.DataAccess.Concrete;
using _8_Generic_Interface___Repository_Pattern__2.Entity;

namespace _8_Generic_Interface___Repository_Pattern__2
{

    class ProductManager : IProductRepository
    {
        IProductRepository _repository;
        public ProductManager(IProductRepository repository)
        {
            this._repository = repository;
        }
        public void Create(Product entity)
        {
            _repository.Create(entity);
        }

        public void Delete(int id)
        {
            throw new NotImplementedException();
        }

        public Product GetById(int id)
        {
            throw new NotImplementedException();
        }

        public Product[] GetPopularProducts()
        {
            throw new NotImplementedException();
        }

        public Product[] GetProductByCategoryId(int id)
        {
            throw new NotImplementedException();
        }

        public void Update(Product entity)
        {
            throw new NotImplementedException();
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            // EfProductDal productDal = new EfProductDal();
            // MySQLProductDal productDal2 = new MySQLProductDal();
            // productDal.Create(new Product());
            // productDal2.Create(new Product());

            ProductManager productDal = new ProductManager(new EfProductDal());
            productDal.Create(new Product());
        }
    }
}

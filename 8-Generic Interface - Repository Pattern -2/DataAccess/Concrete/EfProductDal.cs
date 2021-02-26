using _8_Generic_Interface___Repository_Pattern__2.DataAccess.Abstract;
using _8_Generic_Interface___Repository_Pattern__2.Entity;
using System;

namespace _8_Generic_Interface___Repository_Pattern__2.DataAccess.Concrete
{
    public class EfProductDal : IProductRepository
    {
        public void Create(Product entity)
        {
            Console.WriteLine("EFProduct - create");
        }

        public void Delete(int id)
        {
            throw new System.NotImplementedException();
        }

        public Product GetById(int id)
        {
            throw new System.NotImplementedException();
        }

        public Product[] GetPopularProducts()
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
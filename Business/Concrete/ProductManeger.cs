using Business.Abstract;
using DataAccess.Abstract;
using DataAccess.Concrete.EntityFramework;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Concrete
{
    public class ProductManeger : IProductService
    {
        private IProductDal _productDal;

        public void Add(Product product)
        {
            // Bussiness Codes

           _productDal.Add(product);
        }

        public void Delete(Product product)
        {
            // Bussiness Codes
            _productDal.Delete(product);
        }

        

        public ProductManeger(IProductDal productDal)
        {
           _productDal = productDal;
        }

        public Product GetByID(int productID)
        {
            return _productDal.Get(filter: p => p.ProductID == productID);
        }

        public List<Product> GetList()
        {
           return _productDal.GetList().ToList();
        }

        public List<Product> GetListByCategory(int categoryID)
        {
            return _productDal.GetList(filter: p => p.CategoryID == categoryID).ToList();
        }

        public void Update(Product product)
        {
            // Bussiness Codes
            _productDal.Update(product);
        }
    }
}

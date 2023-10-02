using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Abstract
{
    public interface IProductService
    {
        Product GetByID(int productID);
        List<Product> GetList();
        List<Product> GetListByCategory(int CategoryId);
        void Add(Product product);
        void Delete(Product product);
        void Update(Product product);
        
    }
}

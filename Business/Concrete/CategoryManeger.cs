using Business.Abstract;
using Core.Utilities.Results;
using DataAccess.Abstract;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Concrete
{
    public class CategoryManeger : ICategoryService
    {
        private ICategoryDal _CategoryDal;

        public CategoryManeger(ICategoryDal categoryDal)
        {
            _CategoryDal = categoryDal;
        }

        public IDataResult<List<Category>> GetList()
        {
            return (IDataResult<List<Category>>)_CategoryDal.GetList().ToList();
        }
    }
}

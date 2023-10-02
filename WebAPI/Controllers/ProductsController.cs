using Business.Abstract;
using Entities.Concrete;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;


namespace WebAPII.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProductsController : ControllerBase
    {
        private IProductService _productService;

        public ProductsController(IProductService productService)
        {
            _productService = productService;
        }

        [HttpGet(template: "getAll")]
        public IActionResult GetList()
        {
            var result = _productService.GetList();

            return Ok(result);
        }

        [HttpGet(template: "getlistbycategory")]
        public IActionResult GetByListCategory(int categoryId)
        {
            var result = _productService.GetListByCategory(categoryId);

            return Ok(result);

        }

        [HttpGet(template: "getbyid")]
        public IActionResult GetById(int productId)
        {
            var result = _productService.GetByID(productId);

            return Ok(result);

        }


    }
}

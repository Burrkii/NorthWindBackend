using Business.Abstract;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace WebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CategoryController : ControllerBase
    {
        private ICategoryService _categoryService;

        [HttpGet(template: "getAll")]
        public IActionResult GetList()
        {
            var result = _categoryService.GetList();

            return Ok(result);
        }
    }
}

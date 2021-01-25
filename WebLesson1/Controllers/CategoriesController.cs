using Microsoft.AspNetCore.Mvc;
using PersonalBooking.Logic.Interfaces;
using PersonalBooking.ViewModels.Models;
using System.Collections.Generic;

using System.Threading.Tasks;

namespace WebLesson1.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class CategoriesController : ControllerBase
    {
        private readonly ICategoryService _categoryService;

        public CategoriesController(ICategoryService categoryService)
        {
            _categoryService = categoryService;
        }

        [HttpGet]
        public async Task<IEnumerable<CategoryModel>> Get()
        {
            var result = await _categoryService.GetCategoriesAsync();
            return result;
        }

        [HttpPost]
        public async Task<IActionResult> Post(CategoryModel category)
        {
            await _categoryService.SaveCategoryAsync(category);
            return NoContent();
        }
    }
}

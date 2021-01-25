using PersonalBooking.ViewModels.Models;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace PersonalBooking.Logic.Interfaces
{
    public interface ICategoryService
    {
        Task<IEnumerable<CategoryModel>> GetCategoriesAsync();

        Task SaveCategoryAsync(CategoryModel category);
        
    }
}

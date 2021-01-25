using PersonalBooking.Data.Models;
using PersonalBooking.ViewModels.Models;
using System.Collections.Generic;

namespace PersonalBooking.Logic.Interfaces
{
    public interface ICategoryFormatter
    {
        IEnumerable<CategoryModel> FormatCategories(IEnumerable<Category> dbCategories);
    }
}

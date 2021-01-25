using AutoMapper;
using PersonalBooking.Data.Models;
using PersonalBooking.Logic.Interfaces;
using PersonalBooking.ViewModels.Models;
using System.Collections.Generic;

namespace PersonalBooking.Logic.Services
{
    public class CategoryFormatter : ICategoryFormatter
    {
        private readonly IMapper _mapper;

        public CategoryFormatter(IMapper mapper)
        {
            _mapper = mapper;
        }

        public IEnumerable<CategoryModel> FormatCategories(IEnumerable<Category> dbCategories)
        {
            var formattedCategories = new List<CategoryModel>();
            foreach (var category in dbCategories)
            {
                var mappedCategory = _mapper.Map<CategoryModel>(category);
                mappedCategory.Name = $"SuperCategory:{mappedCategory.Name}";
                formattedCategories.Add(mappedCategory);
            }
            return formattedCategories;
        }
    }
}

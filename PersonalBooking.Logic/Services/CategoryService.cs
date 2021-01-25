using AutoMapper;
using Microsoft.EntityFrameworkCore;
using PersonalBooking.Data.Data;
using PersonalBooking.Data.Models;
using PersonalBooking.Logic.Interfaces;
using PersonalBooking.ViewModels.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PersonalBooking.Logic.Services
{
    public class CategoryService : ICategoryService
    {
        private readonly BookingDbContext _context;
        private readonly IMapper _mapper;
        private readonly ICategoryFormatter _categoryFormatter;

        public CategoryService(BookingDbContext context, IMapper mapper, ICategoryFormatter categoryFormatter)
        {
            _context = context;
            _mapper = mapper;
            _categoryFormatter = categoryFormatter;
        }

        public async Task<IEnumerable<CategoryModel>> GetCategoriesAsync()
        {
            var result = await _context.Categories.ToListAsync();
            return _categoryFormatter.FormatCategories(result);
        }

        public async Task SaveCategoryAsync(CategoryModel category)
        {
            var dbCategory = _mapper.Map<Category>(category);
            await _context.Categories.AddAsync(dbCategory);
            await _context.SaveChangesAsync();
        }
    }
}

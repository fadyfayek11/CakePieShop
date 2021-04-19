using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CakePieShop.Models
{
    public class CategoryRepository : ICategoryRepository
    {
        private readonly AppDbContext _dbContext;

        public CategoryRepository(AppDbContext dbContext)
        {
            _dbContext = dbContext;
        }
        public IEnumerable<Category> AllCategories => _dbContext.Categories;
    }
}

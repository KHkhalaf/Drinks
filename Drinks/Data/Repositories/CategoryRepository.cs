using Drinks.Data.Interfaces;
using System.Collections.Generic;
using Drinks.Data.Models;
using Drinks.Data;

namespace Drinks.Data.Repositories
{
    public class CategoryRepository : ICategoryRepository
    {
        private readonly AppDbContext _appDbContext;
        public CategoryRepository(AppDbContext appDbContext)
        {
            _appDbContext = appDbContext;
        }
        public IEnumerable<Category> Categories => _appDbContext.Categories;
    }
}

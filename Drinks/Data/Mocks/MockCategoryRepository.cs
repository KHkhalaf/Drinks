using Drinks.Data.Interfaces;
using Drinks.Data.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Drinks.Data.Mocks
{
    public class MockCategoryRepository : ICategoryRepository
    {
        public IEnumerable<Category> Categories
        {
            get
            {
                return new List<Category>
                     {
                         new Category { CategoryName = "Alcoholic", Description = "All alcoholic drinks" },
                         new Category { CategoryName = "Non-alcoholic", Description = "All non-alcoholic drinks" }
                     };
            }
        }
    }
}

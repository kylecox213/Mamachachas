using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Mamachachas.Models
{
    public class MockCategoryRepository : ICategoryRepository
    {
        public IEnumerable<Category> AllCategories =>
            new List<Category>
            {
                new Category{CategoryId=1, CategoryName="Pan Delicioso", Description="Fresh , wholegrain, home-baked bread"},
                new Category{CategoryId=2, CategoryName="Milnesas y Papas Fritas", Description=" Baked, golden-brown, thinly sliced cuts of beef"},
                new Category{CategoryId=3, CategoryName="Empanadas de la Mamita", Description="Family recipe style Empanadas"}
            };
    }
}


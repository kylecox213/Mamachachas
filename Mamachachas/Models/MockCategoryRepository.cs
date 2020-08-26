using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Mamachachas.Models
{
	public class MockCategoryRepository: ICategoryRepository
	{
		public IEnumerable<Category> AllCategories =>
			new List<Category>
			{
				new Category{CategoryId=1, CategoryName="Empanaditas", Description="Meat-filled or veggie filled"},
				new Category{CategoryId=2, CategoryName="Pan de los Alamos", Description="Freshly baked whole grain bread loaves"},
				new Category{CategoryId=3, CategoryName="Mamita Especial", Description="Variety of hand-selected daily specials"},
				new Category{CategoryId=4, CategoryName="Milanesas con Panitas", Description="Thinly sliced and hand-breaded beef with whole grain rolls"}
			};

	}
}

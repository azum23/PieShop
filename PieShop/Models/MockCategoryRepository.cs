using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PieShop.Models
{
    public class MockCategoryRepository : ICategoryRepository
    {
        public IEnumerable<Category> Categories =>
            new List<Category>(){
                new Category(){CategoryId =1, CategoryName="Fruit pies", Description="A lot of fruit"},
                new Category(){CategoryId =2, CategoryName="Cheese pies", Description="Cheese for mouse pie"},
                new Category(){CategoryId =3, CategoryName="Seasonal pies", Description="At summer tomato pie, at winter snow pie"}
            };
    }
}

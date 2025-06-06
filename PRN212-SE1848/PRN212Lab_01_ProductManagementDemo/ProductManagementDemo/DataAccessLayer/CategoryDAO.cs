using BusinessObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer
{
    public class CategoryDAO
    {
        public static List<Category> GetCatagories()
        {
            Category beverages = new Category(1, "beverages");
            Category condiments = new Category(2, "condiments");
            Category confections = new Category(3, "confections");
            Category dairy = new Category(4, "dairy");
            Category grains = new Category(5, "grains");
            Category meat = new Category(6, "meat");
            Category produce = new Category(7, "peoduce");
            Category seafood = new Category(8, "seafood");

            var listCategories = new List<Category>();
            try
            {
                listCategories.Add(beverages);
                listCategories.Add(condiments);
                listCategories.Add(confections);
                listCategories.Add(dairy);
                listCategories.Add(grains);
                listCategories.Add(meat);
                listCategories.Add(produce);
                listCategories.Add(seafood);
            }
            catch (Exception e)
            {
                throw new Exception(e.Message);
            }
            return listCategories;

        }
    }
}

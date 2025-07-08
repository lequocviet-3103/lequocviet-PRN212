using BusinessObjects;
using Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Services
{
    public class CategoryService : ICategoryService
    {
        private readonly ICategoryRepository iCatergoryRepository;

        // Ensure the CatergoryRepository class is properly referenced and exists in the Repositories namespace  
        public CategoryService()
        {
            iCatergoryRepository = new CategoryRepository();
        }

        public List<Category> GetCategories()
        {
            return iCatergoryRepository.GetCategories();
        }
    }
}

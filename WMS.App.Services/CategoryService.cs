using System.Collections.Generic;
using System.Linq;
using WMS.Model;

namespace WMS.App.Services
{
    public class CategoryService : ICategoryService
    {
        public List<Category> GetAllCategories()
        {
            using (var db = new WMSContext())
            {
                return db.Categories.OrderBy(p => p.CategoryCode).ThenBy(p => p.StatusSort).ToList();
            }
        }

        public List<Category> GetAllCategoriesByCode(string categoryCode)
        {
            using (var db = new WMSContext())
            {
                return db.Categories.Where(p => p.CategoryCode == categoryCode).OrderBy(p => p.StatusSort).ToList();
            }
        }
    }
}
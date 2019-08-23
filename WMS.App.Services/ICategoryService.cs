using System.Collections.Generic;
using System.Linq;
using WMS.Model;

namespace WMS.App.Services
{
    public interface ICategoryService
    {
        List<Category> GetAllCategories();

        List<Category> GetAllCategoriesByCode(string categoryCode);
    }
}
using System.Collections.Generic;
using WMS.Model;

namespace WMS.App.Services
{
    public interface IProductService
    {
        List<Product> GetAllProducts();

        Model.Product GetProduct(int productID);
        List<Product> SearchProducts(ProductSearchParameter parameter);
        Product SaveProduct(Product entity);
        bool DeleteProduct(int entityId);
    }
}
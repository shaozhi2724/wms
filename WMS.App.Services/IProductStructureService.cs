using System.Collections.Generic;
using WMS.Model;

namespace WMS.App.Services
{
    public interface IProductStructureService
    {
        List<ProductStructure> GetAllProductStructures();
        List<ProductStructure> SearchProductStructures();
        ProductStructure SaveProductStructure(ProductStructure entity);
        bool DeleteProductStructure(int entityId);
    }
}
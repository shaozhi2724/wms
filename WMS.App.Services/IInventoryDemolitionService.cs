using System.Collections.Generic;
using WMS.Model;

namespace WMS.App.Services
{
    public interface IInventoryDemolitionService
    {
        List<InventoryDemolition> GetAllInventoryDemolitions();
        List<InventoryDemolition> SearchInventoryDemolitions();
        InventoryDemolition SaveInventoryDemolition(InventoryDemolition entity);
        bool DeleteInventoryDemolition(int entityId);
    }
}
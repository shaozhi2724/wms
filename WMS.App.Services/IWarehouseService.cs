using System.Collections.Generic;
using WMS.Model;

namespace WMS.App.Services
{
    public interface IWarehouseService
    {
        List<Warehouse> GetAllWarehouses();
        List<Warehouse> SearchWarehouses();
        Warehouse GetWarehouse(int entityId);
        Warehouse SaveWarehouse(Warehouse entity);
        bool DeleteWarehouse(int entityId);
        void SaveWarehouseStatus(Warehouse warehouse);
    }
}
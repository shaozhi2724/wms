using System.Collections.Generic;

namespace WMS.App.Services
{
    public interface IInventoryService
    {
        List<InventoryViewModel> SearchInventory(string structureCode, string productName, string batchNumber, string areaType);
        List<InventoryViewModel> SearchStoreDetail(string productname);
        bool GenerateBusinessInventory(string changeUsername, string action);
        void UpdateCargoStoreAmountAndBusinessAmount(int inventoryStatisticId, bool updateBusinessInventory, string changeUsername);
        void CompleteTaskManually(int inventoryStatisticId);
    }
}
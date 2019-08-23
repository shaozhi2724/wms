using System.Collections.Generic;
using WMS.Model;

namespace WMS.App.Services
{
    public interface IStoreInHistoryService
    {
        List<StoreInHistory> GetAllStoreInHistories();
        List<StoreInHistory> SearchStoreInHistories();
        StoreInHistory SaveStoreInHistory(StoreInHistory entity);
        bool DeleteStoreInHistory(int entityId);
    }
}
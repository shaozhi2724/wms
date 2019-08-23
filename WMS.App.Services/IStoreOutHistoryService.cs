using System.Collections.Generic;
using WMS.Model;

namespace WMS.App.Services
{
    public interface IStoreOutHistoryService
    {
        List<StoreOutHistory> GetAllStoreOutHistories();
        List<StoreOutHistory> SearchStoreOutHistories();
        StoreOutHistory SaveStoreOutHistory(StoreOutHistory entity);
        bool DeleteStoreOutHistory(int entityId);
    }
}
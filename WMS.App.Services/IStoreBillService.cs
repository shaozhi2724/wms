using System;
using System.Collections;
using System.Collections.Generic;
using WMS.Model;

namespace WMS.App.Services
{
    public interface IStoreBillService
    {
        List<StoreBill> GetAllStoreOutBills();
        List<StoreBill> GetAllProcessingStoreOutBills();
        StoreBill GetStoreBill(int storeId);
        StoreBill GetStoreBillByCode(string storeCode);
        List<OutDetail> SplitStoreOutBillDetails(int storeID);
        List<OutDetail> SplitStoreOutBillDetailsForPDA(int storeId);
        List<StoreInBillDetailViewModel> SplitStoreInBillDetails(int storeId);
        List<StoreInBillDetailViewModel> SplitStoreInBillDetails(int storeId, bool systemSignPosition, bool printCargoBarcode);
        void UpdateStoreBillDetailStatus(string storeCode, Guid wmsDetailID,
            StoreBillStatuses storeBillStatus);
        void UpdateStoreBillStatus(string storeCode, StoreBillStatuses storeBillStatus);
        void UpdateStoreBillStatus(int storeId, StoreBillStatuses storeBillStatus);
        void UpdateStoreInBillStatus(int storeId, StoreBillStatuses storeBillStatus);
        void CheckRegulatoryCode(bool allowNoCodeStoreIn, string storeCode);
        void RelateRegulatoryCode(bool allowNoCodeStoreIn, string storeCode);
        List<StoreBillDetailViewModel> GetStoreBillDetails(int storeId);
        List<StoreInBillDetailViewModel> GetStoreInDetails(int storeId);
        List<StoreInBillDetailViewModel> GetStoreBillInDetails(int storeId);
        List<StoreBill> GetAllStoreInBills();
        List<StoreBill> GetAllCompletedStoreOutBills();
        List<StoreBill> GetAllNotReviewedCompletedStoreOutBills();
        List<StoreBill> GetNotReviewedCompletedStoreOutBillByReviewIdentity(string reviewIdentityCode);
        void UpdateCargoSpaceAmount(int billDetailId, int structureId, int productId, string batchNo, int amount);
        List<StoreBillOutDetailViewModel> GetAllStoreOutBillsByProductBarCode(string barcode);
        List<StoreBillOutDetailViewModel> GetAllCompletedStoreOutBillDetails(int storeId);

        List<StoreBill> SearchStoreHistories(string storeCode, int storeTypeId, string dealerName, DateTime startDate,
            DateTime endDate, bool isStoreIn);

        void ManuallyCompleteOutTask(int detailId);
        void CheckAndFixStoreInBillStatus();
        void CheckAndFixStoreOutBillStatus();
        List<InventoryDetailViewModel> GetAllInventoryDetails();
        bool GenerateInventoryStatisticTask(string taskCode, DateTime startDate, DateTime endDate, Guid userId);
        List<InventoryStatistic> SearchInventoryStatisticTasks(string inventoryStatisCode, DateTime startDate, DateTime endDate);
        List<InventoryStatisticDetail> GetInventoryStatisticDetails(int inventoryStatisticId);
        List<InventoryStatistic> SearchInventoryStatisticHistories(string inventoryStatisCode, DateTime startDate, DateTime endDate);
        List<string> GetLightChannels(string stockOutNo);
        List<StoreOutErrorLog> SearchStoreOutErrorLogs(int storeId);
        List<int> GetAllStoreOutErrorBills();
        void UpdateStoreBillRegulatoryStatus(int storeId);
        int getStoreBillID(string storeCode);
        List<StoreBill> GetStoreBill(string storeBillCode);
        List<StoreInBillDetailViewModel> GetStoreBillDetail(long storeId);
        bool DelStoreBill(string storeCode);
        bool PassStoreBill(string storeCode);
        bool DelStoreBillDetail(int detailID);
    }
}
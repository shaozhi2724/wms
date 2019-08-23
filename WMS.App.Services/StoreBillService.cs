using System;
using System.Collections.Generic;
using System.Data.Objects;
using System.Data.SqlClient;
using System.Linq;
using WMS.Model;

namespace WMS.App.Services
{
    public class StoreBillService : IStoreBillService
    {
        public List<StoreBill> GetAllStoreOutBills()
        {
            //不能在WMS显示采购退回出库单,采购退回出库由PDA完成
            using (var db = new WMSContext())
            {
                var waitingStatusID = ((int) StoreBillStatuses.Waiting).ToString();
                var processingStatusID = ((int) StoreBillStatuses.Processing).ToString();
                var bills = db.StoreBills.Where(p => p.IsBillIn.HasValue && !p.IsBillIn.Value && (p.BillStyle == null || p.BillStyle != "直调") && p.StoreTypeName != "采购退货" && (p.StoreStatusID == null || p.StoreStatusID == waitingStatusID || p.StoreStatusID == processingStatusID)).ToList();

                foreach (var storeBill in bills)
                {
                    if (string.IsNullOrWhiteSpace(storeBill.StoreStatusID))
                    {
                        storeBill.StoreStatusID = "0";
                    }
                    storeBill.StoreStatusName =
                        GetStoreBillStatusName((StoreBillStatuses) int.Parse(storeBill.StoreStatusID), false);
                }
                return bills;
            }
        }
        public List<StoreBill> GetAllProcessingStoreOutBills()
        {
            using (var db = new WMSContext())
            {
                var processingStatusID = ((int) StoreBillStatuses.Processing).ToString();
                var bills = db.StoreBills.Where(p => p.IsBillIn.HasValue && !p.IsBillIn.Value && (p.BillStyle == null || p.BillStyle != "直调") && p.StoreStatusID == processingStatusID).ToList();

                return bills;
            }
        }
        public List<StoreBill> GetAllProcessingStoreInBills()
        {
            using (var db = new WMSContext())
            {
                var processingStatusID = ((int) StoreBillStatuses.Processing).ToString();
                var bills = db.StoreBills.Where(p => p.IsBillIn.HasValue && p.IsBillIn.Value && (p.BillStyle == null || p.BillStyle != "直调") && p.StoreStatusID == processingStatusID).ToList();

                return bills;
            }
        }

        public List<StoreBill> GetAllStoreInBills()
        {
            //不能在WMS显示不合格品入库单,不合格品入库由PDA完成
            using (var db = new WMSContext())
            {
                var waitingStatusID = ((int)StoreBillStatuses.Waiting).ToString();
                var processingStatusID = ((int)StoreBillStatuses.Processing).ToString();
                var bills = db.StoreBills.Where(p => p.IsBillIn.HasValue && p.IsBillIn.Value && (p.BillStyle == null || p.BillStyle != "直调") && p.StoreTypeID != 3 && (p.StoreStatusID == null || p.StoreStatusID == waitingStatusID || p.StoreStatusID == processingStatusID)).ToList();

                foreach (var storeBill in bills)
                {
                    if (string.IsNullOrWhiteSpace(storeBill.StoreStatusID))
                    {
                        storeBill.StoreStatusID = "0";
                    }
                    storeBill.StoreStatusName =
                        GetStoreBillStatusName((StoreBillStatuses)int.Parse(storeBill.StoreStatusID), true);
                }
                return bills;
            }
        }
        public List<StoreBill> GetAllCompletedStoreOutBills()
        {
            using (var db = new WMSContext())
            {
                var statusID = ((int)StoreBillStatuses.Complete).ToString();
                var bills = db.StoreBills.Where(p => p.IsBillIn.HasValue && (p.BillStyle == null || p.BillStyle != "直调") && !p.IsBillIn.Value && p.StoreStatusID == statusID).ToList();

                foreach (var storeBill in bills)
                {
                    storeBill.StoreStatusName = GetStoreBillStatusName(StoreBillStatuses.Complete, false);

                }
                return bills;
            }
        }

        public List<StoreBill> GetAllNotReviewedCompletedStoreOutBills()
        {
            List<StoreBill> result = new List<StoreBill>();
            using (var db = new WMSContext())
            {
                var statusID = ((int)StoreBillStatuses.Complete).ToString();
                var bills = db.StoreBills.Where(p => p.IsBillIn.HasValue && (p.BillStyle == null || p.BillStyle != "直调") && !p.IsBillIn.Value && p.StoreStatusID == statusID).ToList();

                foreach (var storeBill in bills)
                {
                    storeBill.StoreStatusName = GetStoreBillStatusName(StoreBillStatuses.Complete, false);

                    if (!db.Reviews.Any(p => p.StoreOutID == storeBill.StoreID) && storeBill.ReviewID == null)
                    {
                        result.Add(storeBill);
                    }
                }
                return result;
            }
        }

        public List<StoreBill> GetNotReviewedCompletedStoreOutBillByReviewIdentity(string reviewIdentityCode)
        {
            List<StoreBill> result = new List<StoreBill>();
            using (var db = new WMSContext())
            {
                var statusID = ((int)StoreBillStatuses.Complete).ToString();
                var reviewIdentity =
                    db.StoreOutReviewIdentities.SingleOrDefault(
                                                                p =>
                                                                p.ReviewIdentityCode == reviewIdentityCode &&
                                                                p.IsReviewed == false);
                if (null != reviewIdentity)
                {
                    var bills = db.StoreBills.Where(p => p.IsBillIn.HasValue
                                                         && (p.BillStyle == null || p.BillStyle != "直调")
                                                         && !p.IsBillIn.Value
                                                         && p.StoreStatusID == statusID
                                                         && p.StoreID == reviewIdentity.StoreID).ToList();

                    foreach (var storeBill in bills)
                    {
                        storeBill.StoreStatusName = GetStoreBillStatusName(StoreBillStatuses.Complete, false);

                        if (!db.Reviews.Any(p => p.StoreOutID == storeBill.StoreID) && storeBill.ReviewID == null)
                        {
                            result.Add(storeBill);
                        }
                    }
                }
                return result;
            }
        }

        public void UpdateCargoSpaceAmount(int billDetailId, int structureId, int productId, string batchNo, int amount)
        {
            using (var db = new WMSContext())
            {
                var cargoSpace = db.CargoSpaceStoreDetails.FirstOrDefault(p => p.ProductID == productId && p.ProductBatchNumber == batchNo && p.StructureID == structureId);
                if (null != cargoSpace)
                {
                    cargoSpace.ProductAmount = cargoSpace.ProductAmount - amount;
                    
                }
                var billDetail = db.StoreBillDetails.FirstOrDefault(p => p.DetailID == billDetailId);
                if (null != billDetail)
                {
                    billDetail.StoreAmount = billDetail.StoreAmount - amount;
                }
                db.SaveChanges();
            }
        }

        public StoreBill GetStoreBill(int storeId)
        {
            using (var db = new WMSContext())
            {
                return db.StoreBills.FirstOrDefault(p => p.StoreID == storeId);
            }
        }
        public StoreBill GetStoreBillByCode(string storeCode)
        {
            using (var db = new WMSContext())
            {
                return db.StoreBills.FirstOrDefault(p => p.StoreCode == storeCode);
            }
        }

        public void UpdateStoreBillDetailStatus(string storeCode, Guid wmsDetailID,
            StoreBillStatuses storeBillStatus)
        {
            using (var db = new WMSContext())
            {
                var wmsDetail = db.WMSStoreBillDetails.FirstOrDefault(p => p.WMSDetailID == wmsDetailID);
                if (null == wmsDetail)
                {
                    return;
                }
                wmsDetail.StatusID = ((int) storeBillStatus).ToString();
                wmsDetail.StatusName = GetStoreBillStatusName(storeBillStatus, false);
                db.SaveChanges();

                if (db.WMSStoreBillDetails.Where(
                        p => p.StoreBillDetailID == wmsDetail.StoreBillDetailID).All(p => p.StatusID == wmsDetail.StatusID))
                {
                    var billDetails = db.StoreBillDetails.Where(p => p.DetailID == wmsDetail.StoreBillDetailID);
                    foreach (var storeBillDetail in billDetails)
                    {
                        storeBillDetail.StatusID = ((int)storeBillStatus).ToString();
                        storeBillDetail.StatusName = GetStoreBillStatusName(storeBillStatus, false);
                    }
                }


                if (db.StoreBillDetails.Where(p => p.StoreID == wmsDetail.StoreID && !p.StatusName.Contains("入库")).All(p => p.StatusID == wmsDetail.StatusID))
                {
                    var storeBill = db.StoreBills.Where(p => p.StoreID == wmsDetail.StoreID);
                    foreach (var bill in storeBill)
                    {
                        bill.StoreStatusID = ((int)storeBillStatus).ToString();

                        bill.StoreStatusName = GetStoreBillStatusName(storeBillStatus, false);
                    }
                }
                db.SaveChanges();
            }
        }

        public List<StoreBillOutDetailViewModel> GetAllStoreOutBillsByProductBarCode(string barcode)
        {
            using (var db = new WMSContext())
            {
                var billDetails = from sd in db.StoreBillDetails
                    join s in db.StoreBills
                        on sd.StoreID equals s.StoreID into sg
                    from sgp in sg.DefaultIfEmpty()
                    where sgp.IsBillIn == false
                    join p in db.Products on sd.ProductID equals p.ProductID into g
                    from gp in g.DefaultIfEmpty()
                    where gp.ProductBarCode == barcode
                    select new StoreBillOutDetailViewModel
                    {
                        StoreID = sd.StoreID,
                        StoreCode = sgp.StoreCode,
                        ProductID = gp.ProductID,
                        ProductBarCode = gp.ProductBarCode,
                        ProductName = gp.ProductName,
                        ProductCode = gp.ProductCode,
                        ProductSpell = gp.ProductSpell,
                        Amount = sd.Amount,
                        StoreAmount = sd.StoreAmount,
                        BatchNo = sd.BatchNo,
                        DetailID = sd.DetailID,
                        ProductSpec = gp.ProductSpec,
                        PackageSpec = gp.PackageSpec,
                        ProducerName = gp.ProducerName,
                        ProduceDate = sd.ProduceDate,
                        ValidateDate = sd.ValidateDate,
                        AuthorizedNo = gp.AuthorizedNo,
                        PhysicType = gp.PhysicType,
                        ProductLocation = gp.Reservation1
                    };
                return billDetails.ToList();
            }
        }

        public List<StoreBillOutDetailViewModel> GetAllCompletedStoreOutBillDetails(int storeId)
        {
            using (var db = new WMSContext())
            {

                var billDetails = from sd in db.StoreBillDetails
                    join s in db.StoreBills
                        on sd.StoreID equals s.StoreID into sg
                    from sgp in sg.DefaultIfEmpty()
                    where sgp.IsBillIn == false && (sgp.BillStyle == null || sgp.BillStyle != "直调")
                    join p in db.Products on sd.ProductID equals p.ProductID into g
                    from gp in g.DefaultIfEmpty()
                    where sgp.StoreID == storeId
                    select new StoreBillOutDetailViewModel
                    {
                        StoreID = sd.StoreID,
                        StoreCode = sgp.StoreCode,
                        ProductID = gp.ProductID,
                        ProductBarCode = gp.ProductBarCode,
                        ProductName = gp.ProductName,
                        ProductCode = gp.ProductCode,
                        ProductSpell = gp.ProductSpell,
                        Amount = sd.Amount,
                        StoreAmount = sd.StoreAmount,
                        BatchNo = sd.BatchNo,
                        DetailID = sd.DetailID,
                        ProductSpec = gp.ProductSpec,
                        PackageSpec = gp.PackageSpec,
                        ProducerName = gp.ProducerName,
                        ProduceDate = sd.ProduceDate,
                        ValidateDate = sd.ValidateDate,
                        AuthorizedNo = gp.AuthorizedNo,
                        PhysicType = gp.PhysicType,
                        ProductLocation = gp.Reservation1
                    };
                return billDetails.ToList();
            }
        }

        public List<StoreBill> SearchStoreHistories(string storeCode, int storeTypeId, string dealerName, DateTime startDate,
            DateTime endDate, bool isStoreIn)
        {
            using (var db = new WMSContext())
            {
                endDate = endDate.Date.AddDays(1).AddSeconds(-1);
                var statusCompleted = ((int)StoreBillStatuses.Complete).ToString();
                var statusReviewed = ((int)StoreBillStatuses.Reviewed).ToString();
                var bills = db.StoreBills.Where(p => p.IsBillIn.HasValue && (p.BillStyle == null || p.BillStyle != "直调") && p.IsBillIn.Value == isStoreIn && (p.StoreStatusID == statusCompleted || p.StoreStatusID == statusReviewed));

                if (!string.IsNullOrWhiteSpace(storeCode))
                {
                    bills = bills.Where(p => p.StoreCode.Contains(storeCode));
                }

                if (storeTypeId > 0)
                {
                    bills = bills.Where(p => p.StoreTypeID == storeTypeId);
                }
                if (!string.IsNullOrWhiteSpace(dealerName))
                {
                    bills = bills.Where(p => p.DealerName.Contains(dealerName));
                }
                if (DateTime.MinValue != startDate)
                {
                    bills = bills.Where(p => p.StoreDate.HasValue && p.StoreDate >= startDate);
                }

                if (DateTime.MinValue != endDate)
                {
                    if (startDate.Date == endDate.Date)
                    {
                        endDate = startDate.Date.AddDays(1).AddSeconds(-1);
                    }
                    bills = bills.Where(p => p.StoreDate.HasValue && p.StoreDate <= endDate);
                }

                var result = bills.ToList();
                foreach (var storeBill in result)
                {
                    storeBill.StoreStatusName = GetStoreBillStatusName(StoreBillStatuses.Complete, isStoreIn);
                }
                return result;
            }
        }

        public void ManuallyCompleteOutTask(int detailId)
        {
            using (var db = new WMSContext())
            {
                var wmsStoreBillDetail = db.WMSStoreBillDetails.FirstOrDefault(p => p.StoreBillDetailID == detailId);
                if (null != wmsStoreBillDetail)
                {
                    var tasks =
                        db.LabelTasks.Where(
                            p =>
                                p.BillDetailID == detailId && p.WMSDetailID == wmsStoreBillDetail.WMSDetailID &&
                                p.TaskStatus == 1).ToList();
                    foreach (var labelTask in tasks)
                    {
                        labelTask.TaskStatus = (int) TaskStatuses.Complete;
                        var cargoSpace =
                            db.CargoSpaceStoreDetails.FirstOrDefault(
                                p =>
                                    p.ProductID == wmsStoreBillDetail.ProductID &&
                                    p.ProductBatchNumber == wmsStoreBillDetail.BatchNo &&
                                    p.StructureID == wmsStoreBillDetail.StructureID);
                        if (null != cargoSpace)
                        {
                            cargoSpace.ProductAmount -= wmsStoreBillDetail.Amount;
                        }
                        db.SaveChanges();
                    }

                    if (null != wmsStoreBillDetail)
                    {
                        wmsStoreBillDetail.StatusID = ((int) StoreBillStatuses.Complete).ToString();
                        wmsStoreBillDetail.StatusName = GetStoreBillStatusName(StoreBillStatuses.Complete, false);
                    }
                    db.SaveChanges();
                }
            }
        }

        public void CheckAndFixStoreOutBillStatus()
        {
            string completeStatus = ((int) StoreBillStatuses.Complete).ToString();
            string processingStatus = ((int) StoreBillStatuses.Processing).ToString();
            var processingBills = GetAllProcessingStoreOutBills();
            foreach (var processingBill in processingBills)
            {
                var storeID = processingBill.StoreID;

                using (var db = new WMSContext())
                {
                    var wmsStoreBillDetails = db.WMSStoreBillDetails.Where(p => p.StoreID == storeID).ToList();
                    if(wmsStoreBillDetails.Any() && wmsStoreBillDetails.All(p => p.StatusID == completeStatus))
                    {
                        var storeBillDetails =
                            db.StoreBillDetails.Where(p => p.StoreID == storeID && p.StatusID == processingStatus)
                                .ToList();
                        foreach (var storeBillDetail in storeBillDetails)
                        {
                            storeBillDetail.StoreAmount = 0;
                            storeBillDetail.StatusID = completeStatus;
                            storeBillDetail.StatusName = GetStoreBillStatusName(StoreBillStatuses.Complete, false);
                        }

                        db.SaveChanges();
                        var storeBill = db.StoreBills.FirstOrDefault(p => p.StoreID == storeID);
                        storeBill.StoreStatusID = completeStatus;
                        storeBill.StoreStatusName = GetStoreBillStatusName(StoreBillStatuses.Complete, false);
                        db.SaveChanges();
                    }
                }
            }
        }

        public void CheckAndFixStoreInBillStatus()
        {
            string completeStatus = ((int) StoreBillStatuses.Complete).ToString();
            string processingStatus = ((int) StoreBillStatuses.Processing).ToString();
            var processingBills = GetAllProcessingStoreInBills();
            foreach (var processingBill in processingBills)
            {
                var storeID = processingBill.StoreID;

                using (var db = new WMSContext())
                {
                    var wmsStoreInDetails = db.WMSStoreInDetails.Where(p => p.StoreID == storeID);
                    if(wmsStoreInDetails.Any() && wmsStoreInDetails.All(p => p.StatusID == completeStatus))
                    {
                        var storeBillDetails =
                            db.StoreBillDetails.Where(p => p.StoreID == storeID && p.StatusID == processingStatus)
                                .ToList();
                        foreach (var storeBillDetail in storeBillDetails)
                        {
                            storeBillDetail.StoreAmount = storeBillDetail.Amount;
                            storeBillDetail.StatusID = completeStatus;
                            storeBillDetail.StatusName = GetStoreBillStatusName(StoreBillStatuses.Complete, false);
                        }

                        db.SaveChanges();
                        var storeBill = db.StoreBills.FirstOrDefault(p => p.StoreID == storeID);
                        storeBill.StoreStatusID = completeStatus;
                        storeBill.StoreStatusName = GetStoreBillStatusName(StoreBillStatuses.Complete, false);
                        db.SaveChanges();
                    }
                }
            }
        }

        public List<InventoryDetailViewModel> GetAllInventoryDetails()
        {
            using (var db = new WMSContext())
            {
                var inventoryData = from ss in db.StorageStructures
                                    where ss.IsMinStructure.HasValue && ss.IsMinStructure.Value
                                    join cssd in db.CargoSpaceStoreDetails on ss.StructureID equals cssd.StructureID into g
                                    from s in g.DefaultIfEmpty()
                                    join p in db.Products on s.ProductID equals p.ProductID into pg
                                    from pgi in pg.DefaultIfEmpty()
                                    orderby ss.StructureCode
                                    select new InventoryDetailViewModel
                                    {
                                        CargoSpaceStoreDetailID = s != null ? s.CargoSpaceStoreDetailID : 0,
                                        WarehouseID = ss.WarehouseID,
                                        StructureID = ss.StructureID,
                                        StructureCode = ss.StructureCode,
                                        StructureName = ss.StructureName,
                                        AreaType = ss.AreaType,
                                        ProductID = s.ProductID,
                                        ProductName = pgi.ProductName,
                                        StockCondition = pgi.StockCondition,
                                        ProductBatchNumber = s.ProductBatchNumber,
                                        ProductionDate = s.ProductionDate,
                                        ProductValidDate = s.ProductValidDate,
                                        ProductAmount = s.ProductAmount,
                                        ProducerName = pgi.ProducerName,
                                        Manufacturer = s.Manufacturer,
                                        ProductSpec = pgi.ProductSpec,
                                        PackageSpec = pgi.PackageSpec,
                                        PackagingSpecification = s.PackagingSpecification,
                                        PhysicType = pgi.PhysicType,
                                        DosageForm = s.DosageForm,
                                        PackagingProportion = pgi.PackagingProportion
                                    };
                return inventoryData.ToList();
            }
        }

        public bool GenerateInventoryStatisticTask(string taskCode, DateTime startDate, DateTime endDate, Guid userId)
        {
            using (var db = new WMSContext())
            {
                if (!db.InventoryStatistics.Any(p => p.StartDate == startDate && p.EndDate == endDate))
                {
                    var inventoryStatistic = new InventoryStatistic
                    {
                        InventoryStatisticCode = taskCode,
                        StartDate = startDate,
                        EndDate = endDate,
                        StatusID = 0,
                        StatusName = "等待盘点",
                        CreateDate = DateTime.Now,
                        CreateUserID = userId
                    };
                    db.InventoryStatistics.Add(inventoryStatistic);
                    db.SaveChanges();
                    var sql = @"INSERT dbo.WMS_InventoryStatisticDetail
                                (
                                    InventoryStatisticID,
                                    CargoSpaceStoreDetailID,
                                    WarehouseID,
                                    StructureID,
                                    StructureCode,
                                    StructureName,
                                    AreaType,
                                    ProductID,
                                    ProductBatchNumber,
                                    ProductionDate,
                                    ProductValidDate,
                                    ProductAmount,
                                    Manufacturer,
                                    DosageForm,
                                    PackagingSpecification,
                                    ProductName,
                                    ProductSpec,
                                    PackageSpec,
                                    PackagingProportion,
                                    PhysicType,
                                    StockCondition,
                                    StatusID,
                                    StatusName,
                                    CreateDate,
                                    VerifiedDate
                                )
                                SELECT
                                    @InventoryStatisticID,
                                    CargoSpaceStoreDetailID,
                                    WarehouseID,
                                    SS.StructureID,
                                    StructureCode,
                                    StructureName,
                                    AreaType,
                                    CSSD.ProductID,
                                    ProductBatchNumber,
                                    ProductionDate,
                                    ProductValidDate,
                                    ProductAmount,
                                    Manufacturer,
                                    DosageForm,
                                    PackagingSpecification,
                                    P.ProductName,
                                    P.ProductSpec,
                                    P.PackageSpec,
                                    P.PackagingProportion,
                                    P.PhysicType,
                                    P.StockCondition,
                                    0,
                                    '等待盘点',
                                    GETDATE(),
                                    NULL
                                FROM
                                    dbo.BFI_StorageStructure AS SS
                                LEFT JOIN dbo.WMS_CargoSpaceStoreDetail AS CSSD
                                    ON CSSD.StructureID = SS.StructureID
                                LEFT JOIN dbo.BFI_Product AS P
                                    ON P.ProductID = CSSD.ProductID
                                WHERE IsMinStructure=1
                                    AND CSSD.ProductID IS NOT NULL
                                ORDER BY
                                    StructureCode";
                    int result = db.Database.ExecuteSqlCommand(sql, new SqlParameter("InventoryStatisticID", inventoryStatistic.InventoryStatisticID));
                    return result > 0;
                }
                else
                {
                    throw new Exception("库存盘点任务已创建，请不要在同一时段重复创建盘库任务。");
                }
            }
            return true;
        }

        public List<InventoryStatistic> SearchInventoryStatisticTasks(string inventoryStatisCode, DateTime startDate, DateTime endDate)
        {
            using (var db = new WMSContext())
            {
                startDate = startDate.Date;
                endDate = endDate.Date.AddDays(1).AddSeconds(-1);
                var statistics = db.InventoryStatistics.AsQueryable();

                if (!string.IsNullOrWhiteSpace(inventoryStatisCode))
                {
                    statistics = statistics.Where(p => p.InventoryStatisticCode.Contains(inventoryStatisCode));
                }
                if (DateTime.MinValue != startDate)
                {
                    statistics = statistics.Where(p => p.StartDate >= startDate);
                }

                if (DateTime.MinValue != endDate)
                {
                    if (startDate.Date == endDate.Date)
                    {
                        endDate = startDate.Date.AddDays(1).AddSeconds(-1);
                    }
                    statistics = statistics.Where(p => p.EndDate <= endDate);
                }

                var result = statistics.ToList();
                return result;
            }
        }

        public List<InventoryStatisticDetail> GetInventoryStatisticDetails(int inventoryStatisticId)
        {
            using (var db = new WMSContext())
            {
                var details = (from s in db.InventoryStatisticDetails
                               where s.InventoryStatisticID == inventoryStatisticId
                               select s).ToList();
                return details;
            }
        }

        public List<InventoryStatistic> SearchInventoryStatisticHistories(string inventoryStatisCode, DateTime startDate, DateTime endDate)
        {
            using (var db = new WMSContext())
            {
                startDate = startDate.Date;
                endDate = endDate.Date.AddDays(1).AddSeconds(-1);
                var statistics = db.InventoryStatistics.AsQueryable();//.Where(p => p.StatusID >= 3);

                if (!string.IsNullOrWhiteSpace(inventoryStatisCode))
                {
                    statistics = statistics.Where(p => p.InventoryStatisticCode.Contains(inventoryStatisCode));
                }
                if (DateTime.MinValue != startDate)
                {
                    statistics = statistics.Where(p => p.StartDate >= startDate);
                }

                if (DateTime.MinValue != endDate)
                {
                    if (startDate.Date == endDate.Date)
                    {
                        endDate = startDate.Date.AddDays(1).AddSeconds(-1);
                    }
                    statistics = statistics.Where(p => p.EndDate <= endDate);
                }

                var result = statistics.ToList();
                return result;
            }
        }

        public List<string> GetLightChannels(string stockOutNo)
        {
            using (var db = new WMSContext())
            {
                var lightCodes = db.LabelTasks.Where(p => p.StockOutNo == stockOutNo).Select(p => p.LightCode).Distinct();
                return lightCodes.ToList();
            }
        }

        public List<StoreOutErrorLog> SearchStoreOutErrorLogs(int storeId)
        {
            using(var db = new WMSContext())
            {
                return db.StoreOutErrorLogs.Where(p => p.StoreID == storeId).ToList();
            }
        }

        public List<int> GetAllStoreOutErrorBills()
        {
            using(var db = new WMSContext())
            {
                return db.StoreOutErrorLogs.Select(p => p.StoreID).Cast<int>().Distinct().ToList();
            }
        }

        public void UpdateStoreBillRegulatoryStatus(int storeId)
        {
            using(var db = new WMSContext())
            {
                var storeBill = db.StoreBills.Find(storeId);
                if(null != storeBill)
                {
                    storeBill.Reservation10 = "已导出电子监管网文件";
                    db.SaveChanges();
                }
            }
        }

        public int getStoreBillID(string storeCode)
        {
            using (var db = new WMSContext())
            {
                var storeBill = db.StoreBills.FirstOrDefault(p => p.StoreCode == storeCode);

                if (storeBill != null)
                {
                    return storeBill.StoreID;
                }
            }
            return 0;
        }

        public List<StoreBill> GetStoreBill(string storeBillCode)
        {
            //不能在WMS显示不合格品入库单,不合格品入库由PDA完成
            using (var db = new WMSContext())
            {
                var waitingStatusID = ((int)StoreBillStatuses.Waiting).ToString();
                var processingStatusID = ((int)StoreBillStatuses.Processing).ToString();
                var bills = db.StoreBills.Where(p => p.StoreCode == storeBillCode).ToList();

                foreach (var storeBill in bills)
                {
                    if (string.IsNullOrWhiteSpace(storeBill.StoreStatusID))
                    {
                        storeBill.StoreStatusID = "0";
                    }
                    storeBill.StoreStatusName =
                        GetStoreBillStatusName((StoreBillStatuses)int.Parse(storeBill.StoreStatusID), storeBill.IsBillIn);
                }
                return bills;
            }
        }

        public List<StoreInBillDetailViewModel> GetStoreBillDetail(long storeId)
        {
            List<StoreInBillDetailViewModel> details = new List<StoreInBillDetailViewModel>();
            using (var db = new WMSContext())
            {
                var storeBill = db.StoreBills.FirstOrDefault(p => p.StoreID == storeId);
                //var storeInHistories = db.StoreInHistories.Where(p => p.StoreCode == storeBill.StoreCode);
                //var structures = db.StorageStructures.ToList();


                if (db.StoreBillDetails.Any(p => p.StoreID == storeId))
                {
                    details = (from s in db.StoreBillDetails
                               where s.StoreID == storeId
                               join p in db.Products on s.ProductID equals p.ProductID into g
                               from i in g.DefaultIfEmpty()
                               select new StoreInBillDetailViewModel
                               {
                                   DetailID = s.DetailID,
                                   ProductID = i.ProductID,
                                   ProductCode = i.ProductCode,
                                   ProductName = i.ProductName,
                                   ProducerName = i.ProducerName,
                                   BatchNo = s.BatchNo,
                                   ProduceDate = EntityFunctions.TruncateTime(s.ProduceDate),
                                   ValidateDate = EntityFunctions.TruncateTime(s.ValidateDate),
                                   Amount = s.BillAmount,
                                   StatusID = s.StatusID,
                                   StatusName = s.StatusName,
                                   DetailRemark = s.DetailRemark,
                                   ProductSpec = i.ProductSpec,
                                   PackageSpec = i.PackageSpec

                               }).ToList();
                }
                return details;
            }
        }

        public bool DelStoreBill(string storeCode)
        {
            using (var db = new WMSContext())
            {
                var storeBill = db.StoreBills.FirstOrDefault(p => p.StoreCode == storeCode);
                if (string.IsNullOrWhiteSpace(storeBill.StoreStatusID))
                {
                    var storebilldetails = db.StoreBillDetails.Where(p => p.StoreID == storeBill.StoreID);
                    foreach (var item in storebilldetails)
                    {
                        db.StoreBillDetails.Remove(item);
                    }
                    db.StoreBills.Remove(storeBill);
                    db.SaveChanges();
                    return true;
                }
                if (storeBill.StoreStatusID == "1")
                {
                    var storebilldetails = db.StoreBillDetails.Where(p => p.StoreID == storeBill.StoreID);
                    bool isstatus = true;
                    foreach (var item in storebilldetails)
                    {
                        if (item.StatusID == "3")
                        {
                            isstatus = false;
                            return isstatus;
                        }
                    }
                    if (isstatus)
                    {
                        foreach (var item in storebilldetails)
                        {
                            db.StoreBillDetails.Remove(item);
                        }
                        db.StoreBills.Remove(storeBill);
                        db.SaveChanges();
                        return true;
                    }
                }
                if (storeBill.StoreStatusID == "3")
                {
                    return false;
                }
            }
            return false;
        }

        public bool PassStoreBill(string storeCode)
        {
            using (var db = new WMSContext())
            {
                var storeBill = db.StoreBills.FirstOrDefault(p => p.StoreCode == storeCode);
                if (string.IsNullOrWhiteSpace(storeBill.StoreStatusID))
                {
                    var storebilldetails = db.StoreBillDetails.Where(p => p.StoreID == storeBill.StoreID);
                    foreach (var item in storebilldetails)
                    {
                        item.StatusID = "3";
                        item.StatusName = "完成" + ((bool)storeBill.IsBillIn ? "入库" : "出库");
                    }
                    storeBill.StoreStatusID = "3";
                    storeBill.StoreStatusName = "完成" + ((bool)storeBill.IsBillIn ? "入库" : "出库");
                    db.SaveChanges();
                    return true;
                }
                if (storeBill.StoreStatusID == "1")
                {
                    var storebilldetails = db.StoreBillDetails.Where(p => p.StoreID == storeBill.StoreID);
                    bool isstatus = true;
                    //foreach (var item in storebilldetails)
                    //{
                    //    if (item.StatusID == "3")
                    //    {
                    //        isstatus = false;
                    //        return isstatus;
                    //    }
                    //}
                    if (isstatus)
                    {
                        foreach (var item in storebilldetails)
                        {
                            item.StatusID = "3";
                            item.StatusName = "完成" + ((bool)storeBill.IsBillIn ? "入库" : "出库");
                        }
                        storeBill.StoreStatusID = "3";
                        storeBill.StoreStatusName = "完成" + ((bool)storeBill.IsBillIn ? "入库" : "出库");
                        db.SaveChanges();
                        return true;
                    }
                }
                if (storeBill.StoreStatusID == "3")
                {
                    return false;
                }
            }
            return false;
        }

        public bool DelStoreBillDetail(int detailID)
        {
            using (var db = new WMSContext())
            {
                var storeBillDetail = db.StoreBillDetails.FirstOrDefault(p => p.DetailID == detailID);
                if (storeBillDetail != null)
                {
                    db.StoreBillDetails.Remove(storeBillDetail);
                    db.SaveChanges();
                    return true;
                }
            }
            return false;
        }

        public void UpdateStoreBillStatus(string storeCode, StoreBillStatuses storeBillStatus)
        {
            using (var db = new WMSContext())
            {
                var storeBill = db.StoreBills.FirstOrDefault(p => p.StoreCode == storeCode);
                if (null != storeBill)
                {
                    if (storeBillStatus == StoreBillStatuses.Complete)
                    {
                        string completeStatus = ((int) StoreBillStatuses.Complete).ToString();
                        if (!db.StoreBillDetails.Where(p => p.StoreID == storeBill.StoreID && !p.StatusName.Contains("入库")).All(p => p.StatusID == completeStatus))
                        {
                            return;
                        }
                    }
                    storeBill.StoreStatusID = ((int) storeBillStatus).ToString();
                    storeBill.StoreStatusName = GetStoreBillStatusName(storeBillStatus, storeBill.IsBillIn);
                    db.SaveChanges();

                    var details = db.StoreBillDetails.Where(p => p.StoreID == storeBill.StoreID).ToList();
                    foreach (var storeBillDetail in details)
                    {
                        storeBillDetail.StatusID = ((int)storeBillStatus).ToString();
                        storeBillDetail.StatusName = GetStoreBillStatusName(storeBillStatus, storeBill.IsBillIn);
                    }

                    var wmsDetails = db.WMSStoreBillDetails.Where(p => p.StoreID == storeBill.StoreID).ToList();
                    foreach (var storeBillDetail in wmsDetails)
                    {
                        storeBillDetail.StatusID = ((int)storeBillStatus).ToString();
                        storeBillDetail.StatusName = GetStoreBillStatusName(storeBillStatus, storeBill.IsBillIn);
                    }
                    db.SaveChanges();
                }
            }
        }
        public void UpdateStoreBillStatus(int storeId, StoreBillStatuses storeBillStatus)
        {
            using (var db = new WMSContext())
            {
                var storeBill = db.StoreBills.FirstOrDefault(p => p.StoreID == storeId);
                if (null != storeBill)
                {
                    storeBill.StoreStatusID = ((int) storeBillStatus).ToString();
                    storeBill.StoreStatusName = GetStoreBillStatusName(storeBillStatus, storeBill.IsBillIn);
                    db.SaveChanges();
                    var details = db.StoreBillDetails.Where(p => p.StoreID == storeId).ToList();
                    foreach (var storeBillDetail in details)
                    {
                        storeBillDetail.StatusID = ((int)storeBillStatus).ToString();
                        storeBillDetail.StatusName = GetStoreBillStatusName(storeBillStatus, storeBill.IsBillIn);
                    }

                    var wmsDetails = db.WMSStoreBillDetails.Where(p => p.StoreID == storeId).ToList();
                    foreach (var storeBillDetail in wmsDetails)
                    {
                        storeBillDetail.StatusID = ((int)storeBillStatus).ToString();
                        storeBillDetail.StatusName = GetStoreBillStatusName(storeBillStatus, storeBill.IsBillIn);
                    }
                    db.SaveChanges();
                }
            }
        }
        public void UpdateStoreInBillStatus(int storeId, StoreBillStatuses storeBillStatus)
        {
            using (var db = new WMSContext())
            {
                var storeBill = db.StoreBills.FirstOrDefault(p => p.StoreID == storeId);
                if (null != storeBill)
                {
                    storeBill.StoreStatusID = ((int) storeBillStatus).ToString();
                    storeBill.StoreStatusName = GetStoreBillStatusName(storeBillStatus, storeBill.IsBillIn);
                    db.SaveChanges();
                    var details = db.StoreBillDetails.Where(p => p.StoreID == storeId).ToList();
                    foreach (var storeBillDetail in details)
                    {
                        if (storeBillStatus == StoreBillStatuses.Processing)
                        {
                            storeBillDetail.StoreAmount = 0;
                        }
                        storeBillDetail.StatusID = ((int)storeBillStatus).ToString();
                        storeBillDetail.StatusName = GetStoreBillStatusName(storeBillStatus, storeBill.IsBillIn);
                    }

                    var wmsDetails = db.WMSStoreInDetails.Where(p => p.StoreID == storeId).ToList();
                    foreach (var storeBillDetail in wmsDetails)
                    {
                        storeBillDetail.StatusID = ((int)storeBillStatus).ToString();
                        storeBillDetail.StatusName = GetStoreBillStatusName(storeBillStatus, storeBill.IsBillIn);
                    }
                    db.SaveChanges();
                }
            }
        }
        public void CheckRegulatoryCode(bool allowNoCodeStoreIn, string storeCode)
        {
            using (var db = new WMSContext())
            {
                if (!allowNoCodeStoreIn)
                {
                    var regulatoryCode = db.RegulatoryCodes.FirstOrDefault(
                            p => p.StatusID == 0 && (p.ReviewCode == null || p.ReviewCode == ""));
                    if (null == regulatoryCode)
                    {
                        throw new Exception("无可用流通监管码！请导入流通监管码后再进行入库操作！");
                    }
                    if (null != db.RegulatoryCodes.FirstOrDefault(p => p.ReviewCode == storeCode))
                    {
                        throw new Exception("此入库单已关联流通监管码！请检查入库单后再进行入库操作！");
                    }
                }
            }
        }
        public void RelateRegulatoryCode(bool allowNoCodeStoreIn, string storeCode)
        {
            using (var db = new WMSContext())
            {
                if (!allowNoCodeStoreIn)
                {
                    var regulatoryCode = db.RegulatoryCodes.FirstOrDefault(
                            p => p.StatusID == 0 && (p.ReviewCode == null || p.ReviewCode == ""));
                    if (null == regulatoryCode)
                    {
                        throw new Exception("无可用流通监管码！请导入流通监管码后再进行复核！");
                    }
                    if (null != db.RegulatoryCodes.FirstOrDefault(p => p.ReviewCode == storeCode))
                    {
                        throw new Exception("此入库单已关联流通监管码！请检查入库单后再进行入库操作！");
                    }
                    regulatoryCode.ReviewCode = storeCode;
                    regulatoryCode.StatusID = 1;
                    regulatoryCode.StatusName = "已关联";
                    regulatoryCode.RelationDate = DateTime.Now;
                }
                db.SaveChanges();
            }
        }
        public List<StoreBillDetailViewModel> GetStoreBillDetails(int storeId)
        {
            List<StoreBillDetailViewModel> details = new List<StoreBillDetailViewModel>();
            using (var db = new WMSContext())
            {
                var storeBill = db.StoreBills.FirstOrDefault(p => p.StoreID == storeId);
                if (storeBill.IsBillIn.HasValue && storeBill.IsBillIn.Value)
                {
                    details = (from s in db.WMSStoreInDetails
                               where s.StoreID == storeId
                               join p in db.Products on s.ProductID equals p.ProductID into g
                               join ss in db.StorageStructures on s.StructureID equals ss.StructureID into sg
                               from si in sg.DefaultIfEmpty()
                               from i in g.DefaultIfEmpty()
                               select new StoreBillDetailViewModel
                               {
                                   DetailID = s.StoreBillDetailID,
                                   ProductID = s.ProductID,
                                   ProductName = i.ProductName,
                                   ProducerName = i.ProducerName,
                                   BatchNo = s.BatchNo,
                                   ProduceDate = EntityFunctions.TruncateTime(s.ProduceDate),
                                   ValidateDate = EntityFunctions.TruncateTime(s.ValidateDate),
                                   Amount = s.Amount,
                                   StatusID = s.StatusID,
                                   StatusName = s.StatusName,
                                   DetailRemark = s.DetailRemark,
                                   StructureCode = s.StructureCode,
                                   StructureName = si.StructureName,
                                   PackagingProportionString = i.PackagingProportion,
                                   ControlType = si.StructureStyle,
                                   ProductSpec = i.ProductSpec,
                                   PackageSpec = i.PackageSpec

                               }).ToList();
                }
                else if (!db.WMSStoreBillDetails.Any(p => p.StoreID == storeId))
                {
                    details = (from s in db.StoreBillDetails
                        where s.StoreID == storeId
                        join p in db.Products on s.ProductID equals p.ProductID into g
                        from i in g.DefaultIfEmpty()
                        select new StoreBillDetailViewModel
                        {
                            DetailID = s.DetailID,
                            ProductID = s.ProductID,
                            ProductName = i.ProductName,
                            ProducerName = i.ProducerName,
                            BatchNo = s.BatchNo,
                            ProduceDate = EntityFunctions.TruncateTime(s.ProduceDate),
                            ValidateDate = EntityFunctions.TruncateTime(s.ValidateDate),
                            Amount = s.Amount,
                            StatusID = s.StatusID,
                            StatusName = s.StatusName,
                            DetailRemark = s.DetailRemark,
                            ProductSpec = i.ProductSpec,
                            PackageSpec = i.PackageSpec

                        }).ToList();
                }
                else
                {
                    details = (from s in db.WMSStoreBillDetails
                               where s.StoreID == storeId
                               join p in db.Products on s.ProductID equals p.ProductID into g
                               join ss in db.StorageStructures on s.StructureID equals ss.StructureID into sg
                               from si in sg.DefaultIfEmpty()
                               from i in g.DefaultIfEmpty()
                               select new StoreBillDetailViewModel
                               {
                                   DetailID = s.StoreBillDetailID,
                                   ProductID = s.ProductID,
                                   ProductName = i.ProductName,
                                   ProducerName = i.ProducerName,
                                   BatchNo = s.BatchNo,
                                   ProduceDate = EntityFunctions.TruncateTime(s.ProduceDate),
                                   ValidateDate = EntityFunctions.TruncateTime(s.ValidateDate),
                                   Amount = s.Amount,
                                   StatusID = s.StatusID,
                                   StatusName = s.StatusName,
                                   DetailRemark = s.DetailRemark,
                                   StructureCode = s.StructureCode,
                                   StructureName = si.StructureName,
                                   PackagingProportionString = i.PackagingProportion,
                                   ControlType = si.StructureStyle,
                                   ProductSpec = i.ProductSpec,
                                   PackageSpec = i.PackageSpec

                               }).ToList();
                }
                foreach (var model in details)
                {
                    if (model.ProduceDate.HasValue)
                    {
                        model.ProduceDateString = model.ProduceDate.Value.ToString("yyyy-MM-dd");
                    }
                    if (model.ValidateDate.HasValue)
                    {
                        model.ValidateDateString = model.ValidateDate.Value.ToString("yyyy-MM-dd");
                    }
                    if (model.ControlType.HasValue)
                    {
                        if (model.ControlType == 0)
                        {
                            model.ControlTypeString = "无控制";
                        }
                        else if (model.ControlType == 1)
                        {
                            model.ControlTypeString = "电子标签控制";
                        }
                        else if (model.ControlType == 2)
                        {
                            model.ControlTypeString = "PDA控制";
                        }
                    }
                    if (!string.IsNullOrWhiteSpace(model.PackagingProportionString) &&
                        model.PackagingProportionString != "0")
                    {
                        model.PackagingAmount = model.Amount/Convert.ToUInt32(model.PackagingProportionString);
                    }

                    if (string.IsNullOrWhiteSpace(model.StatusID))
                    {
                        model.StatusID = "0";
                    }
                    model.StatusName = GetStoreBillStatusName((StoreBillStatuses) int.Parse(model.StatusID),
                        storeBill.IsBillIn.HasValue ? storeBill.IsBillIn.Value : true);
                }
                return details;
            }
        }

        public List<StoreInBillDetailViewModel> GetStoreInDetails(int storeId)
        {
            List<StoreInBillDetailViewModel> details = new List<StoreInBillDetailViewModel>();
            using (var db = new WMSContext())
            {
                var storeBill = db.StoreBills.FirstOrDefault(p => p.StoreID == storeId);
                if (db.WMSStoreInDetails.Any(p => p.StoreID == storeId))
                {
                    details = (from s in db.WMSStoreInDetails
                        where s.StoreID == storeId
                        join p in db.Products on s.ProductID equals p.ProductID into g
                        join ss in db.StorageStructures on s.StructureID equals ss.StructureID into sg
                        from si in sg.DefaultIfEmpty()
                        from i in g.DefaultIfEmpty()
                        select new StoreInBillDetailViewModel
                        {
                            DetailID = s.StoreBillDetailID,
                            StoreID = s.StoreID,
                            ProductID = s.ProductID,
                            ProductName = i.ProductName,
                            ProducerName = i.ProducerName,
                            BatchNo = s.BatchNo,
                            ProduceDate = EntityFunctions.TruncateTime(s.ProduceDate),
                            ValidateDate = EntityFunctions.TruncateTime(s.ValidateDate),
                            Amount = s.Amount,
                            StatusID = s.StatusID,
                            StatusName = s.StatusName,
                            DetailRemark = s.DetailRemark,
                            StructureCode = s.StructureCode,
                            StructureName = si.StructureName,
                            PackagingProportionString = i.PackagingProportion,
                            ControlType = si.StructureStyle,
                            ProductSpec = i.ProductSpec,
                            PackageSpec = i.PackageSpec

                        }).ToList();
                }
                else
                {
                    details = (from s in db.StoreBillDetails
                        where s.StoreID == storeId
                        join p in db.Products on s.ProductID equals p.ProductID into g
                        from i in g.DefaultIfEmpty()
                        select new StoreInBillDetailViewModel
                        {
                            DetailID = s.DetailID,
                            ProductID = s.ProductID,
                            ProductName = i.ProductName,
                            ProducerName = i.ProducerName,
                            BatchNo = s.BatchNo,
                            ProduceDate = EntityFunctions.TruncateTime(s.ProduceDate),
                            ValidateDate = EntityFunctions.TruncateTime(s.ValidateDate),
                            Amount = s.Amount,
                            StatusID = s.StatusID,
                            StatusName = s.StatusName,
                            DetailRemark = s.DetailRemark,
                            ProductSpec = i.ProductSpec,
                            PackageSpec = i.PackageSpec

                        }).ToList();
                }
                foreach (var model in details)
                {
                    if (model.ProduceDate.HasValue)
                    {
                        model.ProduceDateString = model.ProduceDate.Value.ToString("yyyy-MM-dd");
                    }
                    if (model.ValidateDate.HasValue)
                    {
                        model.ValidateDateString = model.ValidateDate.Value.ToString("yyyy-MM-dd");
                    }
                    if (model.ControlType.HasValue)
                    {
                        if (model.ControlType == 0)
                        {
                            model.ControlTypeString = "无控制";
                        }
                        else if (model.ControlType == 1)
                        {
                            model.ControlTypeString = "电子标签控制";
                        }
                        else if (model.ControlType == 2)
                        {
                            model.ControlTypeString = "PDA控制";
                        }
                    }
                    if (!string.IsNullOrWhiteSpace(model.PackagingProportionString) &&
                        model.PackagingProportionString != "0")
                    {
                        model.PackagingAmount = model.Amount / Convert.ToUInt32(model.PackagingProportionString);
                    }

                    if (string.IsNullOrWhiteSpace(model.StatusID))
                    {
                        model.StatusID = "0";
                    }
                    model.StatusName = GetStoreBillStatusName((StoreBillStatuses)int.Parse(model.StatusID),
                        storeBill.IsBillIn.HasValue ? storeBill.IsBillIn.Value : true);
                }
                return details;
            }
        }

        public List<StoreInBillDetailViewModel> GetStoreBillInDetails(int storeId)
        {
            List<StoreInBillDetailViewModel> details = new List<StoreInBillDetailViewModel>();
            using (var db = new WMSContext())
            {
                var storeBill = db.StoreBills.FirstOrDefault(p => p.StoreID == storeId);
                var storeInHistories = db.StoreInHistories.Where(p => p.StoreCode == storeBill.StoreCode);
                var structures = db.StorageStructures.ToList();
                if (!db.WMSStoreInDetails.Any(p => p.StoreID == storeId))
                {
                    details = (from s in db.StoreBillDetails
                        where s.StoreID == storeId
                        join p in db.Products on s.ProductID equals p.ProductID into g
                        from i in g.DefaultIfEmpty()
                        select new StoreInBillDetailViewModel
                        {
                            DetailID = s.DetailID,
                            ProductID = s.ProductID,
                            ProductName = i.ProductName,
                            ProducerName = i.ProducerName,
                            BatchNo = s.BatchNo,
                            ProduceDate = EntityFunctions.TruncateTime(s.ProduceDate),
                            ValidateDate = EntityFunctions.TruncateTime(s.ValidateDate),
                            Amount = s.Amount,
                            StatusID = s.StatusID,
                            StatusName = s.StatusName,
                            DetailRemark = s.DetailRemark,
                            ProductSpec = i.ProductSpec,
                            PackageSpec = i.PackageSpec

                        }).ToList();
                }
                else
                {
                    details = (from s in db.WMSStoreInDetails
                               where s.StoreID == storeId
                               join p in db.Products on s.ProductID equals p.ProductID into g
                               join ss in db.StorageStructures on s.StructureID equals ss.StructureID into sg
                               from si in sg.DefaultIfEmpty()
                               from i in g.DefaultIfEmpty()
                               select new StoreInBillDetailViewModel
                               {
                                   DetailID = s.StoreBillDetailID,
                                   StoreID = s.StoreID,
                                   ProductID = s.ProductID,
                                   ProductName = i.ProductName,
                                   ProducerName = i.ProducerName,
                                   BatchNo = s.BatchNo,
                                   ProduceDate = EntityFunctions.TruncateTime(s.ProduceDate),
                                   ValidateDate = EntityFunctions.TruncateTime(s.ValidateDate),
                                   Amount = s.Amount,
                                   StatusID = s.StatusID,
                                   StatusName = s.StatusName,
                                   DetailRemark = s.DetailRemark,
                                   StructureCode = s.StructureCode,
                                   StructureName = si.StructureName,
                                   PackagingProportionString = i.PackagingProportion,
                                   ControlType = si.StructureStyle,
                                   ProductSpec = i.ProductSpec,
                                   PackageSpec = i.PackageSpec
                                   
                               }).ToList();
                }
                foreach (var model in details)
                {
                    if (model.ProduceDate.HasValue)
                    {
                        model.ProduceDateString = model.ProduceDate.Value.ToString("yyyy-MM-dd");
                    }
                    if (model.ValidateDate.HasValue)
                    {
                        model.ValidateDateString = model.ValidateDate.Value.ToString("yyyy-MM-dd");
                    }
                    if (model.ControlType.HasValue)
                    {
                        if (model.ControlType == 0)
                        {
                            model.ControlTypeString = "无控制";
                        }
                        else if (model.ControlType == 1)
                        {
                            model.ControlTypeString = "电子标签控制";
                        }
                        else if (model.ControlType == 2)
                        {
                            model.ControlTypeString = "PDA控制";
                        }
                    }
                    if (!string.IsNullOrWhiteSpace(model.PackagingProportionString) &&
                        model.PackagingProportionString != "0")
                    {
                        model.PackagingAmount = model.Amount/Convert.ToUInt32(model.PackagingProportionString);
                    }

                    if (string.IsNullOrWhiteSpace(model.StatusID))
                    {
                        model.StatusID = "0";
                    }
                    model.StatusName = GetStoreBillStatusName((StoreBillStatuses) int.Parse(model.StatusID),
                        storeBill.IsBillIn.HasValue ? storeBill.IsBillIn.Value : true);
                    if (string.IsNullOrWhiteSpace(model.StructureName))
                    {
                        var history = storeInHistories.FirstOrDefault(p => p.ProductID == model.ProductID && p.ProductBatchNumber == model.BatchNo && p.ProductAmount == model.Amount);
                        if (null != history && history.StructureID > 0)
                        {
                            var structure = structures.Find(p => p.StructureID == history.StructureID);
                            if (null != structure)
                            {
                                model.StructureCode = structure.StructureCode;
                                model.StructureName = structure.StructureName;
                            }
                        }
                    }
                }
                return details;
            }
        }

        public List<StoreInBillDetailViewModel> SplitStoreInBillDetails(int storeId, bool systemSignPosition, bool printCargoBarcode)
        {
            if (systemSignPosition)
            {
                var billDetails = SplitStoreInBillDetails(storeId);
                if (printCargoBarcode)
                {
                    using (var db = new WMSContext())
                    {
                        var products =
                            db.Products.Select(p => new {ProductID = p.ProductID, DosageForm = p.PhysicType}).ToList();
                        foreach (var billDetail in billDetails)
                        {
                            var spaceDetail =
                                db.CargoSpaceStoreDetails.FirstOrDefault(
                                    p =>
                                        p.StructureID == billDetail.StructureID
                                        && p.ProductID == billDetail.ProductID
                                        && p.ProductBatchNumber == billDetail.BatchNo);
                            if (null != spaceDetail)
                            {
                                spaceDetail.ProductAmount += billDetail.Amount;
                                db.SaveChanges();
                            }
                            else
                            {
                                string dosageForm = string.Empty;
                                var product = products.FirstOrDefault(p => p.ProductID == billDetail.ProductID);
                                if (null != product)
                                {
                                    dosageForm = product.DosageForm;
                                }
                                var cargoSpaceDetail = new CargoSpaceStoreDetail
                                {
                                    StructureID = billDetail.StructureID,
                                    ProductID = billDetail.ProductID,
                                    ProductBatchNumber = billDetail.BatchNo,
                                    ProductionDate = billDetail.ProduceDate,
                                    ProductValidDate = billDetail.ValidateDate,
                                    PackagingSpecification = billDetail.PackageSpec,
                                    ProductAmount = billDetail.Amount,
                                    Manufacturer = billDetail.ProducerName,
                                    DosageForm = dosageForm
                                };
                                db.CargoSpaceStoreDetails.Add(cargoSpaceDetail);
                                db.SaveChanges();
                            }
                        }
                    }
                }
                return billDetails;
            }

            using (var db = new WMSContext())
            {
                var billDetails = (from s in db.StoreBillDetails
                                   join p in db.Products on s.ProductID equals p.ProductID into g
                                   from i in g.DefaultIfEmpty()
                                   where s.StoreID == storeId
                                   select new StoreInBillDetailViewModel
                                   {
                                       DetailID = s.DetailID,
                                       StoreID = s.StoreID,
                                       ProductID = s.ProductID,
                                       ProductName = i.ProductName,
                                       BatchNo = s.BatchNo,
                                       ProducerName = i.ProducerName,
                                       ProduceDate = s.ProduceDate,
                                       ValidateDate = s.ValidateDate,
                                       EntireCargoSpaceMaximum =
                                           i.EntireCargoSpaceMaximum.HasValue ? i.EntireCargoSpaceMaximum.Value : 0,
                                       ScatteredCargoSpaceMaximum =
                                           i.ScatteredCargoSpaceMaximum.HasValue ? i.ScatteredCargoSpaceMaximum.Value : 0,
                                       PackagingProportionString = i.PackagingProportion,
                                       Amount = s.Amount.Value,
                                       StatusID = s.StatusID,
                                       StatusName = s.StatusName,
                                       DetailRemark = s.DetailRemark,
                                       StoreEnvironment = i.StockCondition
                                   }).ToList();
                List<StoreInBillDetailViewModel> oraginalBillDetails = new List<StoreInBillDetailViewModel>();
                oraginalBillDetails.AddRange(billDetails);


                var oldWMSDetails =
                    db.WMSStoreInDetails.Where(p => p.StoreID == storeId).ToList();

                foreach (var oldWMSDetail in oldWMSDetails)
                {
                    db.WMSStoreInDetails.Remove(oldWMSDetail);
                }
                db.SaveChanges();

                var details = db.StoreBillDetails.Where(p => p.StoreID == storeId).ToList();
                foreach (var detail in details)
                {
                    var wmsStoreInBillDetail = new WMSStoreInDetail
                    {
                        WMSDetailID = Guid.NewGuid(),
                        StoreBillDetailID = detail.DetailID,
                        StoreID = storeId,
                        ProductID = detail.ProductID,
                        BatchNo = detail.BatchNo,
                        Amount = detail.Amount,
                        StatusID = detail.StatusID,
                        StatusName = detail.StatusName,
                        StoreAmount = 0,
                        //StructureID = detail.StructureID,
                        //StructureCode = detail.StructureCode,
                        DetailRemark = detail.DetailRemark,
                        ProduceDate = detail.ProduceDate,
                        ValidateDate = detail.ValidateDate,
                        CreateDate = detail.CreateDate
                    };
                    db.WMSStoreInDetails.Add(wmsStoreInBillDetail);
                }
                db.SaveChanges();

                var wmsBillDetails = (from s in db.WMSStoreInDetails
                                   join p in db.Products on s.ProductID equals p.ProductID into g
                                   from i in g.DefaultIfEmpty()
                                   where s.StoreID == storeId
                                   select new StoreInBillDetailViewModel
                                   {
                                       DetailID = s.StoreBillDetailID,
                                       StoreID = s.StoreID,
                                       ProductID = s.ProductID,
                                       ProductName = i.ProductName,
                                       BatchNo = s.BatchNo,
                                       ProducerName = i.ProducerName,
                                       ProduceDate = s.ProduceDate,
                                       ValidateDate = s.ValidateDate,
                                       EntireCargoSpaceMaximum =
                                           i.EntireCargoSpaceMaximum.HasValue ? i.EntireCargoSpaceMaximum.Value : 0,
                                       ScatteredCargoSpaceMaximum =
                                           i.ScatteredCargoSpaceMaximum.HasValue ? i.ScatteredCargoSpaceMaximum.Value : 0,
                                       PackagingProportionString = i.PackagingProportion,
                                       Amount = s.Amount.Value,
                                       StatusID = s.StatusID,
                                       StatusName = s.StatusName,
                                       DetailRemark = s.DetailRemark,
                                       StoreEnvironment = i.StockCondition
                                   }).ToList();
                var needCheckResults = from p in wmsBillDetails
                                       group p by
                                           new
                                           {
                                               p.DetailID,
                                               p.StoreID,
                                               p.ProductID,
                                               p.ProductName,
                                               p.BatchNo,
                                               p.ProducerName,
                                               p.StatusID,
                                               p.StatusName
                                           }
                                           into g
                                           select new StoreInBillDetailViewModel
                                           {
                                               DetailID = g.Key.DetailID,
                                               StoreID = g.Key.StoreID,
                                               ProductID = g.Key.ProductID,
                                               ProductName = g.Key.ProductName,
                                               BatchNo = g.Key.BatchNo,
                                               ProducerName = g.Key.ProducerName,
                                               Amount = g.Sum(s => s.Amount),
                                               StatusID = g.Key.StatusID,
                                               StatusName = g.Key.StatusName,
                                           };

                var checkResults = from p in oraginalBillDetails
                                   group p by
                                       new
                                       {
                                           p.DetailID,
                                           p.StoreID,
                                           p.ProductID,
                                           p.ProductName,
                                           p.BatchNo,
                                           p.ProducerName
                                       }
                                       into g
                                       select new StoreInBillDetailViewModel
                                       {
                                           DetailID = g.Key.DetailID,
                                           StoreID = g.Key.StoreID,
                                           ProductID = g.Key.ProductID,
                                           ProductName = g.Key.ProductName,
                                           BatchNo = g.Key.BatchNo,
                                           ProducerName = g.Key.ProducerName,
                                           Amount = g.Sum(s => s.Amount)
                                       };
                foreach (var detail in checkResults)
                {
                    var result = needCheckResults.FirstOrDefault(p => p.DetailID == detail.DetailID && p.ProductID == detail.ProductID && p.BatchNo == detail.BatchNo && p.Amount == detail.Amount);
                    if (null == result)
                    {
                        var wmsDetails = db.WMSStoreInDetails.Where(p => p.StoreID == storeId).ToList();

                        foreach (var wmsdetail in wmsDetails)
                        {
                            db.WMSStoreInDetails.Remove(wmsdetail);
                        }
                        db.SaveChanges();
                        throw new Exception(string.Format("药品{0}（批号:{1}, 数量:{2}）入库分配信息与入库单明细不符", detail.ProductName, detail.BatchNo, detail.Amount));
                    }
                }
                return wmsBillDetails;
            }
        }

        public List<StoreInBillDetailViewModel> SplitStoreInBillDetails(int storeId)
        {
            //1. 入库明细各药品按整货/零货容量拆分（整零区分条件为包装比例和入库数量）
            //2. 找匹配药品和批号的货位
            //  2.1-区分整货/零货/存储条件
            //  2.2-货位现存放数量+入库数 < 整零货位容量

            //3. 不匹配的货位 - 找空货位（条件：整货/零货/存储条件）
            //4. 每个入库明细中的药品是否都分配好了货位
            //5. 所有条件满足，输出入库货位明细
            using (var db = new WMSContext())
            {
                var billDetails = (from s in db.StoreBillDetails
                    join p in db.Products on s.ProductID equals p.ProductID into g
                    from i in g.DefaultIfEmpty()
                    where s.StoreID == storeId
                    select new StoreInBillDetailViewModel
                    {
                        DetailID = s.DetailID,
                        StoreID = s.StoreID,
                        ProductID = s.ProductID,
                        ProductName = i.ProductName,
                        BatchNo = s.BatchNo,
                        ProducerName = i.ProducerName,
                        ProduceDate = s.ProduceDate,
                        ValidateDate = s.ValidateDate,
                        EntireCargoSpaceMaximum =
                            i.EntireCargoSpaceMaximum.HasValue ? i.EntireCargoSpaceMaximum.Value : 0,
                        ScatteredCargoSpaceMaximum =
                            i.ScatteredCargoSpaceMaximum.HasValue ? i.ScatteredCargoSpaceMaximum.Value : 0,
                        PackagingProportionString = i.PackagingProportion,
                        Amount = s.Amount.Value,
                        StatusID = s.StatusID,
                        StatusName = s.StatusName,
                        DetailRemark = s.DetailRemark,
                        StoreEnvironment = i.StockCondition
                    }).ToList();
                List<StoreInBillDetailViewModel> oraginalBillDetails = new List<StoreInBillDetailViewModel>();
                oraginalBillDetails.AddRange(billDetails);
                //billDetails.Dump("BillDetails");
                var entireBillDetails =
                    billDetails.Where(
                        p =>
                            (p.EntireCargoSpaceMaximum > 0 && p.Amount%p.EntireCargoSpaceMaximum == 0) ||
                            (p.ScatteredCargoSpaceMaximum > 0 && p.Amount%p.ScatteredCargoSpaceMaximum == 0))
                        .ToList();
                foreach (var billDetail in entireBillDetails)
                {
                    if (billDetail.EntireCargoSpaceMaximum > 0)
                    {
                        var entireCount = billDetail.Amount.Value / billDetail.EntireCargoSpaceMaximum;
                        var counts = Enumerable.Range(0, entireCount);
                        //整货位零头
                        if (billDetail.Amount.Value % billDetail.EntireCargoSpaceMaximum > 0)
                        {
                            billDetails.Insert(0, new StoreInBillDetailViewModel
                            {
                                DetailID = billDetail.DetailID,
                                StoreID = billDetail.StoreID,
                                ProductID = billDetail.ProductID,
                                ProductName = billDetail.ProductName,
                                ProducerName = billDetail.ProducerName,
                                BatchNo = billDetail.BatchNo,
                                ProduceDate = billDetail.ProduceDate,
                                ValidateDate = billDetail.ValidateDate,
                                EntireCargoSpaceMaximum = billDetail.EntireCargoSpaceMaximum,
                                ScatteredCargoSpaceMaximum = billDetail.ScatteredCargoSpaceMaximum,
                                Amount = billDetail.Amount.Value % billDetail.EntireCargoSpaceMaximum,
                                StatusID = billDetail.StatusID,
                                StatusName = billDetail.StatusName,
                                DetailRemark = billDetail.DetailRemark,
                                PackagingProportion = billDetail.PackagingProportion,
                                PackagingProportionString = billDetail.PackagingProportionString,
                                StoreEnvironment = billDetail.StoreEnvironment
                            });
                        }
                        //整货
                        foreach (var i in counts)
                        {
                            billDetails.Add(new StoreInBillDetailViewModel
                            {
                                DetailID = billDetail.DetailID,
                                StoreID = billDetail.StoreID,
                                ProductID = billDetail.ProductID,
                                ProductName = billDetail.ProductName,
                                ProducerName = billDetail.ProducerName,
                                BatchNo = billDetail.BatchNo,
                                ProduceDate = billDetail.ProduceDate,
                                ValidateDate = billDetail.ValidateDate,
                                EntireCargoSpaceMaximum = billDetail.EntireCargoSpaceMaximum,
                                ScatteredCargoSpaceMaximum = billDetail.ScatteredCargoSpaceMaximum,
                                Amount = billDetail.EntireCargoSpaceMaximum,
                                StatusID = billDetail.StatusID,
                                StatusName = billDetail.StatusName,
                                DetailRemark = billDetail.DetailRemark,
                                PackagingProportion = billDetail.PackagingProportion,
                                PackagingProportionString = billDetail.PackagingProportionString,
                                StoreEnvironment = billDetail.StoreEnvironment
                            });
                        }
                        billDetails.Remove(billDetail);
                    }
                    else if (billDetail.ScatteredCargoSpaceMaximum > 0)
                    {
                        var scatteredCount = billDetail.Amount.Value / billDetail.ScatteredCargoSpaceMaximum;
                        var counts = Enumerable.Range(0, scatteredCount);
                        //零货位零头
                        if (billDetail.Amount.Value % billDetail.ScatteredCargoSpaceMaximum > 0)
                        {
                            billDetails.Insert(0, new StoreInBillDetailViewModel
                            {
                                DetailID = billDetail.DetailID,
                                StoreID = billDetail.StoreID,
                                ProductID = billDetail.ProductID,
                                ProductName = billDetail.ProductName,
                                ProducerName = billDetail.ProducerName,
                                BatchNo = billDetail.BatchNo,
                                ProduceDate = billDetail.ProduceDate,
                                ValidateDate = billDetail.ValidateDate,
                                EntireCargoSpaceMaximum = billDetail.EntireCargoSpaceMaximum,
                                ScatteredCargoSpaceMaximum = billDetail.ScatteredCargoSpaceMaximum,
                                Amount = billDetail.Amount.Value % billDetail.ScatteredCargoSpaceMaximum,
                                StatusID = billDetail.StatusID,
                                StatusName = billDetail.StatusName,
                                DetailRemark = billDetail.DetailRemark,
                                PackagingProportion = billDetail.PackagingProportion,
                                PackagingProportionString = billDetail.PackagingProportionString,
                                StoreEnvironment = billDetail.StoreEnvironment
                            });
                        }
                        //零货
                        foreach (var i in counts)
                        {
                            billDetails.Add(new StoreInBillDetailViewModel
                            {
                                DetailID = billDetail.DetailID,
                                StoreID = billDetail.StoreID,
                                ProductID = billDetail.ProductID,
                                ProductName = billDetail.ProductName,
                                ProducerName = billDetail.ProducerName,
                                BatchNo = billDetail.BatchNo,
                                ProduceDate = billDetail.ProduceDate,
                                ValidateDate = billDetail.ValidateDate,
                                EntireCargoSpaceMaximum = billDetail.EntireCargoSpaceMaximum,
                                ScatteredCargoSpaceMaximum = billDetail.ScatteredCargoSpaceMaximum,
                                Amount = billDetail.ScatteredCargoSpaceMaximum,
                                StatusID = billDetail.StatusID,
                                StatusName = billDetail.StatusName,
                                DetailRemark = billDetail.DetailRemark,
                                PackagingProportion = billDetail.PackagingProportion,
                                PackagingProportionString = billDetail.PackagingProportionString,
                                StoreEnvironment = billDetail.StoreEnvironment
                            });
                        }

                        billDetails.Remove(billDetail);
                    }
                }
                //billDetails.Dump("BillDetails2");
                //1. 入库明细各药品按整货/零货容量拆分（整零区分条件为包装比例和入库数量）
                var noSplitBillDetails = billDetails.Where(p => (p.EntireCargoSpaceMaximum == 0 && p.ScatteredCargoSpaceMaximum == 0)).OrderByDescending(p => p.Amount).ThenBy(p => p.BatchNo).ToList();
                var splitBillDetails = billDetails.Where(p => (p.EntireCargoSpaceMaximum > 0) || (p.ScatteredCargoSpaceMaximum > 0)).OrderByDescending(p => p.Amount).ThenBy(p => p.BatchNo).ToList();

                #region 1.1 无整/零货容量

                var noSplitEntireBillDeatils = new List<StoreInBillDetailViewModel>();
                var noSplitScatteredBillDetails = new List<StoreInBillDetailViewModel>();
                foreach (var billDetail in noSplitBillDetails)
                {
                    if (billDetail.Amount == billDetail.EntireCargoSpaceMaximum)
                    {
                        noSplitEntireBillDeatils.Add(billDetail);
                    }
                    else if (billDetail.Amount == billDetail.ScatteredCargoSpaceMaximum)
                    {
                        noSplitScatteredBillDetails.Add(billDetail);
                    }
                    else
                    {
                        //如果有包装比例且比例不为0，入库数是否能整除包装比例
                        if (!string.IsNullOrWhiteSpace(billDetail.PackagingProportionString))
                        {
                            int packagingProportion = int.Parse(billDetail.PackagingProportionString);
                            if (packagingProportion > 0)
                            {
                                var counts = Enumerable.Range(0, billDetail.Amount.Value/packagingProportion);
                                //整货
                                foreach (var i in counts)
                                {
                                    noSplitEntireBillDeatils.Add(new StoreInBillDetailViewModel
                                    {
                                        DetailID = billDetail.DetailID,
                                        StoreID = billDetail.StoreID,
                                        ProductID = billDetail.ProductID,
                                        ProductName = billDetail.ProductName,
                                        ProducerName = billDetail.ProducerName,
                                        BatchNo = billDetail.BatchNo,
                                        ProduceDate = billDetail.ProduceDate,
                                        ValidateDate = billDetail.ValidateDate,
                                        EntireCargoSpaceMaximum = billDetail.EntireCargoSpaceMaximum,
                                        ScatteredCargoSpaceMaximum = billDetail.ScatteredCargoSpaceMaximum,
                                        Amount = packagingProportion,
                                        PackagingProportion = packagingProportion,
                                        StoreEnvironment = billDetail.StoreEnvironment,
                                        StatusID = billDetail.StatusID,
                                        StatusName = billDetail.StatusName,
                                    });
                                }
                                //零货
                                var mod = billDetail.Amount.Value%packagingProportion;
                                if (mod > 0)
                                {
                                    noSplitScatteredBillDetails.Add(new StoreInBillDetailViewModel
                                    {
                                        DetailID = billDetail.DetailID,
                                        StoreID = billDetail.StoreID,
                                        ProductID = billDetail.ProductID,
                                        ProductName = billDetail.ProductName,
                                        ProducerName = billDetail.ProducerName,
                                        BatchNo = billDetail.BatchNo,
                                        ProduceDate = billDetail.ProduceDate,
                                        ValidateDate = billDetail.ValidateDate,
                                        EntireCargoSpaceMaximum = billDetail.EntireCargoSpaceMaximum,
                                        ScatteredCargoSpaceMaximum = billDetail.ScatteredCargoSpaceMaximum,
                                        Amount = mod,
                                        PackagingProportion = packagingProportion,
                                        StoreEnvironment = billDetail.StoreEnvironment,
                                        StatusID = billDetail.StatusID,
                                        StatusName = billDetail.StatusName,
                                    });
                                }
                            }
                            else
                            {
                                //包装比例为0，当成零货
                                noSplitScatteredBillDetails.Add(new StoreInBillDetailViewModel
                                {
                                    DetailID = billDetail.DetailID,
                                    StoreID = billDetail.StoreID,
                                    ProductID = billDetail.ProductID,
                                    ProductName = billDetail.ProductName,
                                    ProducerName = billDetail.ProducerName,
                                    BatchNo = billDetail.BatchNo,
                                    ProduceDate = billDetail.ProduceDate,
                                    ValidateDate = billDetail.ValidateDate,
                                    EntireCargoSpaceMaximum = billDetail.EntireCargoSpaceMaximum,
                                    ScatteredCargoSpaceMaximum = billDetail.ScatteredCargoSpaceMaximum,
                                    Amount = billDetail.Amount,
                                    PackagingProportion = packagingProportion,
                                    StoreEnvironment = billDetail.StoreEnvironment,
                                    StatusID = billDetail.StatusID,
                                    StatusName = billDetail.StatusName,
                                });
                            }
                        }
                        else
                        {
                            //没有包装比例，当成零货
                            noSplitScatteredBillDetails.Add(new StoreInBillDetailViewModel
                            {
                                DetailID = billDetail.DetailID,
                                StoreID = billDetail.StoreID,
                                ProductID = billDetail.ProductID,
                                ProductName = billDetail.ProductName,
                                ProducerName = billDetail.ProducerName,
                                BatchNo = billDetail.BatchNo,
                                ProduceDate = billDetail.ProduceDate,
                                ValidateDate = billDetail.ValidateDate,
                                EntireCargoSpaceMaximum = billDetail.EntireCargoSpaceMaximum,
                                ScatteredCargoSpaceMaximum = billDetail.ScatteredCargoSpaceMaximum,
                                Amount = billDetail.Amount,
                                PackagingProportion = 0,
                                StoreEnvironment = billDetail.StoreEnvironment,
                                StatusID = billDetail.StatusID,
                                StatusName = billDetail.StatusName,
                            });
                        }
                    }
                }
                //noSplitEntireBillDeatils.Dump("无容量整货");
                //noSplitScatteredBillDetails.Dump("无容量零货");

                #endregion

                #region 1.2 有整/零货容量

                var splitEntireBillDeatils = new List<StoreInBillDetailViewModel>();
                var splitScatteredBillDetails = new List<StoreInBillDetailViewModel>();
                foreach (var billDetail in splitBillDetails)
                {
                    //如果有包装比例且比例不为0，入库数是否能整除包装比例
                    if (!string.IsNullOrWhiteSpace(billDetail.PackagingProportionString))
                    {
                        int packagingProportion = int.Parse(billDetail.PackagingProportionString);
                        if (packagingProportion > 0)
                        {
                            var counts = Enumerable.Range(0, billDetail.Amount.Value/packagingProportion);
                            //整货
                            foreach (var i in counts)
                            {
                                splitEntireBillDeatils.Add(new StoreInBillDetailViewModel
                                {
                                    DetailID = billDetail.DetailID,
                                    StoreID = billDetail.StoreID,
                                    ProductID = billDetail.ProductID,
                                    ProductName = billDetail.ProductName,
                                    ProducerName = billDetail.ProducerName,
                                    BatchNo = billDetail.BatchNo,
                                    ProduceDate = billDetail.ProduceDate,
                                    ValidateDate = billDetail.ValidateDate,
                                    EntireCargoSpaceMaximum = billDetail.EntireCargoSpaceMaximum,
                                    ScatteredCargoSpaceMaximum = billDetail.ScatteredCargoSpaceMaximum,
                                    Amount = packagingProportion,
                                    PackagingProportion = packagingProportion,
                                    StoreEnvironment = billDetail.StoreEnvironment,
                                    StatusID = billDetail.StatusID,
                                    StatusName = billDetail.StatusName,
                                });
                            }
                            //零货
                            var mod = billDetail.Amount.Value%packagingProportion;
                            if (mod > 0)
                            {
                                splitScatteredBillDetails.Add(new StoreInBillDetailViewModel
                                {
                                    DetailID = billDetail.DetailID,
                                    StoreID = billDetail.StoreID,
                                    ProductID = billDetail.ProductID,
                                    ProductName = billDetail.ProductName,
                                    ProducerName = billDetail.ProducerName,
                                    BatchNo = billDetail.BatchNo,
                                    ProduceDate = billDetail.ProduceDate,
                                    ValidateDate = billDetail.ValidateDate,
                                    EntireCargoSpaceMaximum = billDetail.EntireCargoSpaceMaximum,
                                    ScatteredCargoSpaceMaximum = billDetail.ScatteredCargoSpaceMaximum,
                                    Amount = mod,
                                    PackagingProportion = packagingProportion,
                                    StoreEnvironment = billDetail.StoreEnvironment,
                                    StatusID = billDetail.StatusID,
                                    StatusName = billDetail.StatusName,
                                });
                            }
                        }
                        else
                        {
                            //包装比例为0，当成零货
                            splitScatteredBillDetails.Add(new StoreInBillDetailViewModel
                            {
                                DetailID = billDetail.DetailID,
                                StoreID = billDetail.StoreID,
                                ProductID = billDetail.ProductID,
                                ProductName = billDetail.ProductName,
                                ProducerName = billDetail.ProducerName,
                                BatchNo = billDetail.BatchNo,
                                ProduceDate = billDetail.ProduceDate,
                                ValidateDate = billDetail.ValidateDate,
                                EntireCargoSpaceMaximum = billDetail.EntireCargoSpaceMaximum,
                                ScatteredCargoSpaceMaximum = billDetail.ScatteredCargoSpaceMaximum,
                                Amount = billDetail.Amount,
                                PackagingProportion = packagingProportion,
                                StoreEnvironment = billDetail.StoreEnvironment,
                                StatusID = billDetail.StatusID,
                                StatusName = billDetail.StatusName,
                            });
                        }
                    }
                    else
                    {
                        //没有包装比例，当成零货
                        splitScatteredBillDetails.Add(new StoreInBillDetailViewModel
                        {
                            DetailID = billDetail.DetailID,
                            StoreID = billDetail.StoreID,
                            ProductID = billDetail.ProductID,
                            ProductName = billDetail.ProductName,
                            ProducerName = billDetail.ProducerName,
                            BatchNo = billDetail.BatchNo,
                            ProduceDate = billDetail.ProduceDate,
                            ValidateDate = billDetail.ValidateDate,
                            EntireCargoSpaceMaximum = billDetail.EntireCargoSpaceMaximum,
                            ScatteredCargoSpaceMaximum = billDetail.ScatteredCargoSpaceMaximum,
                            Amount = billDetail.Amount,
                            PackagingProportion = 0,
                            StoreEnvironment = billDetail.StoreEnvironment,
                            StatusID = billDetail.StatusID,
                            StatusName = billDetail.StatusName,
                        });
                    }
                }
                //splitEntireBillDeatils.Dump("有容量整货");
                //splitScatteredBillDetails.Dump("有容量零货");

                #endregion

                #region 分配货位

                var entireStructures = (from s in db.StorageStructures
                                       where s.IsMinStructure == true && s.AreaType == "整货" && s.IsActive.HasValue && s.IsActive.Value
                                       join c in db.CargoSpaceStoreDetails on s.StructureID equals c.StructureID into g
                                       from gi in g.DefaultIfEmpty()
                                       join w in db.Warehouses on s.WarehouseID equals w.WarehouseID
                                       select new InStructureDetail
                                       {
                                           StructureID = s.StructureID,
                                           StructureCode = s.StructureCode,
                                           StructureName = s.StructureName,
                                           WarehouseType = w.WarehouseType,
                                           AreaType = s.AreaType,
                                           ProductID = gi.ProductID,
                                           ProductBatchNumber = gi.ProductBatchNumber != null ? gi.ProductBatchNumber : "",
                                           ProductAmount = gi.ProductAmount.HasValue ? gi.ProductAmount.Value : 0
                                       }).ToList(); 
                var scatteredStructures = (from s in db.StorageStructures
                                          where s.IsMinStructure == true && s.AreaType == "零货" && s.IsActive.HasValue && s.IsActive.Value
                                          join c in db.CargoSpaceStoreDetails on s.StructureID equals c.StructureID into g
                                          from gi in g.DefaultIfEmpty()
                                          join w in db.Warehouses on s.WarehouseID equals w.WarehouseID
                                          select new InStructureDetail
                                          {
                                              StructureID = s.StructureID,
                                              StructureCode = s.StructureCode,
                                              StructureName = s.StructureName,
                                              WarehouseType = w.WarehouseType,
                                              AreaType = s.AreaType,
                                              ProductID = gi.ProductID,
                                              ProductBatchNumber = gi.ProductBatchNumber != null ? gi.ProductBatchNumber : "",
                                              ProductAmount = gi.ProductAmount.HasValue ? gi.ProductAmount.Value : 0
                                          }).ToList();
                var structures = new List<InStructureDetail>();
                structures.AddRange(entireStructures);
                structures.AddRange(scatteredStructures);

                noSplitEntireBillDeatils = noSplitEntireBillDeatils.OrderByDescending(p => p.Amount).ThenBy(p => p.BatchNo).ToList();
                noSplitScatteredBillDetails = noSplitScatteredBillDetails.OrderByDescending(p => p.Amount).ThenBy(p => p.BatchNo).ToList();

                splitEntireBillDeatils = splitEntireBillDeatils.OrderByDescending(p => p.Amount).ThenBy(p => p.BatchNo).ToList();
                splitScatteredBillDetails = splitScatteredBillDetails.OrderByDescending(p => p.Amount).ThenBy(p => p.BatchNo).ToList();
                #region 2. 有容量零/整货找货位

                #region 2.1 整货

                if (splitEntireBillDeatils.Count > 0)
                {
                    foreach (var detail in splitEntireBillDeatils)
                    {
                        //找药品/批号匹配, 容量够的整货货位
                        var structure = structures.FirstOrDefault(p => p.ProductID == detail.ProductID
                                                                       && p.ProductBatchNumber == detail.BatchNo
                                                                       && p.WarehouseType == detail.StoreEnvironment
                                                                       &&
                                                                       (detail.EntireCargoSpaceMaximum == 0 ||
                                                                        detail.EntireCargoSpaceMaximum >=
                                                                        detail.Amount + p.ProductAmount)
                                                                       && p.AreaType == "整货");

                        //找整货空货位
                        if (null == structure)
                        {
                            structure = structures.FirstOrDefault(p => p.ProductID == null
                                                                       && p.WarehouseType == detail.StoreEnvironment
                                                                       && p.AreaType == "整货");
                        }
                        //找药品/批号匹配, 容量够的零货货位
                        if (null == structure)
                        {
                            structure = structures.FirstOrDefault(p => p.ProductID == detail.ProductID
                                                                       && p.ProductBatchNumber == detail.BatchNo
                                                                       && p.WarehouseType == detail.StoreEnvironment
                                                                       &&
                                                                       (detail.ScatteredCargoSpaceMaximum == 0 ||
                                                                        detail.ScatteredCargoSpaceMaximum >=
                                                                        detail.Amount + p.ProductAmount)
                                                                       && p.AreaType == "零货");
                        }
                        //找零货空货位
                        if (null == structure)
                        {
                            structure = structures.FirstOrDefault(p => p.ProductID == null
                                                                       && p.WarehouseType == detail.StoreEnvironment
                                                                       && p.AreaType == "零货");
                        }
                        //找不到货位
                        if (null == structure)
                        {
                            throw new Exception(string.Format("无货位可分配给药品： {0}（批号:{1},数量:{2}）", detail.ProductName,
                                detail.BatchNo, detail.Amount));
                        }
                        detail.StructureID = structure.StructureID;
                        detail.StructureCode = structure.StructureCode;
                        detail.StructureName = structure.StructureName;
                        detail.AreaType = structure.AreaType;
                        structure.ProductID = detail.ProductID;
                        structure.ProductBatchNumber = detail.BatchNo;
                        structure.ProductAmount += detail.Amount;
                    }
                    //splitEntireBillDeatils.Dump("有容量整货-有货位");
                }

                #endregion

                #region 2.2 零货

                if (splitScatteredBillDetails.Count > 0)
                {
                    foreach (var detail in splitScatteredBillDetails)
                    {
                        //找药品/批号匹配, 容量够的零货货位
                        var structure = structures.FirstOrDefault(p => p.ProductID == detail.ProductID
                                                                       && p.ProductBatchNumber == detail.BatchNo
                                                                       && p.WarehouseType == detail.StoreEnvironment
                                                                       &&
                                                                       (detail.ScatteredCargoSpaceMaximum == 0 ||
                                                                        detail.ScatteredCargoSpaceMaximum >=
                                                                        detail.Amount + p.ProductAmount)
                                                                       && p.AreaType == "零货");

                        //找零货空货位
                        if (null == structure)
                        {
                            structure = structures.FirstOrDefault(p => p.ProductID == null
                                                                       && p.WarehouseType == detail.StoreEnvironment
                                                                       && p.AreaType == "零货");
                        }
                        //找不到货位
                        if (null == structure)
                        {
                            throw new Exception(string.Format("无零货货位可分配给药品： {0}（批号:{1},数量:{2}）", detail.ProductName,
                                detail.BatchNo, detail.Amount));
                        }
                        detail.StructureID = structure.StructureID;
                        detail.StructureCode = structure.StructureCode;
                        detail.StructureName = structure.StructureName;
                        detail.AreaType = structure.AreaType;
                        structure.ProductID = detail.ProductID;
                        structure.ProductBatchNumber = detail.BatchNo;
                        structure.ProductAmount += detail.Amount;
                    }
                }
                //splitScatteredBillDetails.Dump("有容量零货-有货位");

                #endregion


                #endregion

                #region 3. 无容量

                #region 3.1 整货

                if (noSplitEntireBillDeatils.Count > 0)
                {
                    foreach (var detail in noSplitEntireBillDeatils)
                    {
                        //找药品/批号匹配, 容量够的整货货位
                        var structure = structures.FirstOrDefault(p => p.ProductID == detail.ProductID
                                                                       && p.ProductBatchNumber == detail.BatchNo
                                                                       && p.WarehouseType == detail.StoreEnvironment
                                                                       &&
                                                                       (detail.EntireCargoSpaceMaximum == 0 ||
                                                                        detail.EntireCargoSpaceMaximum >=
                                                                        detail.Amount + p.ProductAmount)
                                                                       && p.AreaType == "整货");
                        //找药品/批号匹配, 容量够的零货货位
                        if (null == structure)
                        {
                            structure = structures.FirstOrDefault(p => p.ProductID == detail.ProductID
                                                                       && p.ProductBatchNumber == detail.BatchNo
                                                                       && p.WarehouseType == detail.StoreEnvironment
                                                                       &&
                                                                       (detail.ScatteredCargoSpaceMaximum == 0 ||
                                                                        detail.ScatteredCargoSpaceMaximum >=
                                                                        detail.Amount + p.ProductAmount)
                                                                       && p.AreaType == "零货");
                        }

                        //找整货空货位
                        if (null == structure)
                        {
                            structure = structures.FirstOrDefault(p => p.ProductID == null
                                                                       && p.WarehouseType == detail.StoreEnvironment
                                                                       && p.AreaType == "整货");
                        }
                        //找零货空货位
                        if (null == structure)
                        {
                            structure = structures.FirstOrDefault(p => p.ProductID == null
                                                                       && p.WarehouseType == detail.StoreEnvironment
                                                                       && p.AreaType == "零货");
                        }
                        //找不到货位
                        if (null == structure)
                        {
                            throw new Exception(string.Format("无货位可分配给药品： {0}（批号:{1},数量:{2}）", detail.ProductName,
                                detail.BatchNo, detail.Amount));
                        }
                        detail.StructureID = structure.StructureID;
                        detail.StructureCode = structure.StructureCode;
                        detail.StructureName = structure.StructureName;
                        detail.AreaType = structure.AreaType;
                        structure.ProductID = detail.ProductID;
                        structure.ProductBatchNumber = detail.BatchNo;
                        structure.ProductAmount += detail.Amount;
                    }
                    //noSplitEntireBillDeatils.Dump("无容量整货-有货位");
                }

                #endregion

                #region 3.2 零货

                if (noSplitScatteredBillDetails.Count > 0)
                {
                    foreach (var detail in noSplitScatteredBillDetails)
                    {
                        //找药品/批号匹配, 容量够的零货货位
                        var structure = structures.FirstOrDefault(p => p.ProductID == detail.ProductID
                                                                       && p.ProductBatchNumber == detail.BatchNo
                                                                       && p.WarehouseType == detail.StoreEnvironment
                                                                       &&
                                                                       (detail.ScatteredCargoSpaceMaximum == 0 ||
                                                                        detail.ScatteredCargoSpaceMaximum >=
                                                                        detail.Amount + p.ProductAmount)
                                                                       && p.AreaType == "零货");

                        //找零货空货位
                        if (null == structure)
                        {
                            structure = structures.FirstOrDefault(p => p.ProductID == null
                                                                       && p.WarehouseType == detail.StoreEnvironment
                                                                       && p.AreaType == "零货");
                        }
                        //找不到货位
                        if (null == structure)
                        {
                            throw new Exception(string.Format("无零货货位可分配给药品： {0}（批号:{1},数量:{2}）", detail.ProductName,
                                detail.BatchNo, detail.Amount));
                        }
                        detail.StructureID = structure.StructureID;
                        detail.StructureCode = structure.StructureCode;
                        detail.StructureName = structure.StructureName;
                        detail.AreaType = structure.AreaType;
                        structure.ProductID = detail.ProductID;
                        structure.ProductBatchNumber = detail.BatchNo;
                        structure.ProductAmount += detail.Amount;
                    }
                }
                //noSplitScatteredBillDetails.Dump("无容量零货-有货位");

                #endregion

                #endregion

                #endregion

                //统计
                List<StoreInBillDetailViewModel> allNoSplitResults = new List<StoreInBillDetailViewModel>();
                List<StoreInBillDetailViewModel> allSplitResults = new List<StoreInBillDetailViewModel>();
                allNoSplitResults.AddRange(noSplitEntireBillDeatils);
                allSplitResults.AddRange(splitEntireBillDeatils);
                allNoSplitResults.AddRange(noSplitScatteredBillDetails);
                allSplitResults.AddRange(splitScatteredBillDetails);

                var noSplitResults = from p in allNoSplitResults
                    group p by
                        new
                        {
                            p.DetailID,
                            p.StoreID,
                            p.ProductID,
                            p.ProductName,
                            p.BatchNo,
                            p.ProduceDate,
                            p.ValidateDate,
                            p.ProducerName,
                            p.StructureID,
                            p.StructureCode,
                            p.StructureName,
                            p.AreaType,
                            p.StatusID,
                            p.StatusName
                        }
                    into g
                    select new StoreInBillDetailViewModel
                    {
                        DetailID = g.Key.DetailID,
                        StoreID = g.Key.StoreID,
                        ProductID = g.Key.ProductID,
                        ProductName = g.Key.ProductName,
                        BatchNo = g.Key.BatchNo,
                        ProduceDate = g.Key.ProduceDate,
                        ValidateDate = g.Key.ValidateDate,
                        ProducerName = g.Key.ProducerName,
                        StructureID = g.Key.StructureID,
                        StructureCode = g.Key.StructureCode,
                        StructureName = g.Key.StructureName,
                        AreaType = g.Key.AreaType,
                        Amount = g.Sum(s => s.Amount),
                        StatusID = g.Key.StatusID,
                        StatusName = g.Key.StatusName,
                    };
                //noSplitResults.Dump("无容量未拆分");

                var splitResults = from p in allSplitResults
                    group p by
                        new
                        {
                            p.DetailID,
                            p.StoreID,
                            p.ProductID,
                            p.ProductName,
                            p.BatchNo,
                            p.ProduceDate,
                            p.ValidateDate,
                            p.ProducerName,
                            p.StructureID,
                            p.StructureCode,
                            p.StructureName,
                            p.AreaType,
                            p.StatusID,
                            p.StatusName
                        }
                    into g
                    select new StoreInBillDetailViewModel
                    {
                        DetailID = g.Key.DetailID,
                        StoreID = g.Key.StoreID,
                        ProductID = g.Key.ProductID,
                        ProductName = g.Key.ProductName,
                        BatchNo = g.Key.BatchNo,
                        ProduceDate = g.Key.ProduceDate,
                        ValidateDate = g.Key.ValidateDate,
                        ProducerName = g.Key.ProducerName,
                        StructureID = g.Key.StructureID,
                        StructureCode = g.Key.StructureCode,
                        StructureName = g.Key.StructureName,
                        AreaType = g.Key.AreaType,
                        Amount = g.Sum(s => s.Amount),
                        StatusID = g.Key.StatusID,
                        StatusName = g.Key.StatusName,
                    };
                //splitResults.Dump("有容量已拆分");
                //noSplitResults.Union(splitResults).Dump("已拆分");
                var finalData = noSplitResults.Union(splitResults).ToList();

                var needCheckResults = from p in finalData
                                       group p by
                                           new
                                           {
                                               p.DetailID,
                                               p.StoreID,
                                               p.ProductID,
                                               p.ProductName,
                                               p.BatchNo,
                                               p.ProducerName,
                                               p.StatusID,
                                               p.StatusName
                                           }
                                           into g
                                           select new StoreInBillDetailViewModel
                                           {
                                               DetailID = g.Key.DetailID,
                                               StoreID = g.Key.StoreID,
                                               ProductID = g.Key.ProductID,
                                               ProductName = g.Key.ProductName,
                                               BatchNo = g.Key.BatchNo,
                                               ProducerName = g.Key.ProducerName,
                                               Amount = g.Sum(s => s.Amount),
                                               StatusID = g.Key.StatusID,
                                               StatusName = g.Key.StatusName,
                                           };

                var checkResults = from p in oraginalBillDetails
                                   group p by
                                       new
                                       {
                                           p.DetailID,
                                           p.StoreID,
                                           p.ProductID,
                                           p.ProductName,
                                           p.BatchNo,
                                           p.ProducerName
                                       }
                                       into g
                                       select new StoreInBillDetailViewModel
                                       {
                                           DetailID = g.Key.DetailID,
                                           StoreID = g.Key.StoreID,
                                           ProductID = g.Key.ProductID,
                                           ProductName = g.Key.ProductName,
                                           BatchNo = g.Key.BatchNo,
                                           ProducerName = g.Key.ProducerName,
                                           Amount = g.Sum(s => s.Amount)
                                       };
                foreach (var detail in checkResults)
                {
                    var result = needCheckResults.FirstOrDefault(p => p.DetailID == detail.DetailID && p.ProductID == detail.ProductID && p.BatchNo == detail.BatchNo && p.Amount == detail.Amount);
                    if (null == result)
                    {
                        throw new Exception(string.Format("药品{0}（批号:{1}, 数量:{2}）入库分配信息与入库单明细不符", detail.ProductName, detail.BatchNo, detail.Amount));
                    }
                }
                var detailIDs = finalData.Select(p => p.DetailID).ToList();
                var oldWMSDetails =
                    db.WMSStoreInDetails.Where(p => detailIDs.Contains(p.StoreBillDetailID)).ToList();

                foreach (var oldWMSDetail in oldWMSDetails)
                {
                    db.WMSStoreInDetails.Remove(oldWMSDetail);
                }
                db.SaveChanges();
                foreach (var detail in finalData)
                {
                    var wmsStoreInBillDetail = new WMSStoreInDetail
                    {
                        WMSDetailID = Guid.NewGuid(),
                        StoreBillDetailID = detail.DetailID,
                        StoreID = storeId,
                        ProductID = detail.ProductID,
                        BatchNo = detail.BatchNo,
                        Amount = detail.Amount.Value,
                        StatusID = detail.StatusID,
                        StatusName = detail.StatusName,
                        StructureID = detail.StructureID,
                        StructureCode = detail.StructureCode,
                        DetailRemark = detail.DetailRemark,
                        ProduceDate = detail.ProduceDate,
                        ValidateDate = detail.ValidateDate,
                        CreateDate = DateTime.Today
                    };
                    db.WMSStoreInDetails.Add(wmsStoreInBillDetail);
                }

                db.SaveChanges();
                return finalData;
            }

        }

        public List<OutDetail> SplitStoreOutBillDetails(int storeId)
        {
            using (var db = new WMSContext())
            {
                var storeBill = db.StoreBills.FirstOrDefault(p => p.StoreID == storeId);
                var allSturctures =
                    db.StorageStructures.Select(p => new
                    {
                        p.StructureID,
                        p.StructureCode,
                        p.StructureName,
                        p.StructureStyle
                    }).ToList();
                var billInfo = from s in db.StoreBillDetails
                               where s.StoreID == storeId
                               join p in db.Products on s.ProductID equals p.ProductID into g
                               from i in g.DefaultIfEmpty()
                               select new StoreBillDetailViewModel
                               {
                                   DetailID = s.DetailID,
                                   ProductID = s.ProductID,
                                   ProductName = i.ProductName,
                                   BatchNo = s.BatchNo,
                                   ProduceDate = s.ProduceDate,
                                   ValidateDate = s.ValidateDate,
                                   PackagingProportionString = i.PackagingProportion,
                                   Amount = s.Amount.Value,
                                   StatusID = s.StatusID,
                                   StatusName = s.StatusName,
                                   DetailRemark = s.DetailRemark,
                               };
                var details = (from q in billInfo
                               join c in db.CargoSpaceStoreDetails on
                                   new ProductStructureCompare { ProductID = q.ProductID, BatchNo = q.BatchNo } equals
                                   new ProductStructureCompare { ProductID = c.ProductID.Value, BatchNo = c.ProductBatchNumber } into
                                   gp
                               from pc in gp.DefaultIfEmpty()
                               join ss in db.StorageStructures on pc.StructureID equals ss.StructureID into sg
                               from sgi in sg.DefaultIfEmpty()
                               where (sgi.AreaType == "整货" || sgi.AreaType == "零货" || sgi.AreaType == null || sgi.AreaType == "")
                               select new OutDetail
                               {
                                   DetailID = q.DetailID,
                                   ProductID = q.ProductID,
                                   BatchNo = q.BatchNo,
                                   ProductName = q.ProductName,
                                   Amount = q.Amount,
                                   ProduceDate = q.ProduceDate,
                                   ValidateDate = q.ValidateDate,
                                   StatusID = q.StatusID,
                                   StatusName = q.StatusName,
                                   DetailRemark = q.DetailRemark,
                                   PackagingProportionString = q.PackagingProportionString,
                                   AreaType = sgi.AreaType,
                                   StoreAmount = pc != null ? pc.ProductAmount.Value : -1,
                                   StoreOutAmount =
                                       pc != null
                                           ? (q.Amount.Value <= pc.ProductAmount.Value ? q.Amount.Value : pc.ProductAmount.Value - q.Amount.Value)
                                           : 0,
                                   StructureID = pc != null ? pc.StructureID : -1,
                               }).ToList();

                foreach (var item in billInfo)
                {
                    if (!details.Exists(p => p.DetailID == item.DetailID && p.ProductID == item.ProductID && p.BatchNo == item.BatchNo))
                    {
                        string errorMessage = string.Format("以下药品无库存：\n\n{0} （{1}）\n", item.ProductName, item.BatchNo);
                        throw new Exception(errorMessage);
                    }
                }
                var canOut = details.All(p => p.StructureID > 0);
                //出库明细中药品是否都有库存
                if (!canOut)
                {
                    string errorMessage = "以下药品无库存：\n\n";
                    var alertProducts = details.Where(p => p.StructureID <= 0).Select(p => new { p.ProductName, p.BatchNo });
                    foreach (var alertProduct in alertProducts)
                    {
                        errorMessage += string.Format("{0} （{1}）\n", alertProduct.ProductName, alertProduct.BatchNo);
                    }
                    throw new Exception(errorMessage);
                }
                //出库明细中药品是否够出库量
                var summaryProducts = from s in (details.Select(p => new { p.ProductID, p.ProductName, p.BatchNo, p.Amount, p.StoreAmount }))
                                      group s by new { s.ProductID, s.BatchNo } into g
                                      select new
                                      {
                                          g.Key.ProductID,
                                          g.FirstOrDefault().ProductName,
                                          g.Key.BatchNo,
                                          Amount = g.Sum(q => q.Amount),
                                          StoreAmount = g.Sum(q => q.StoreAmount)
                                      };
                var notEnoughProducts = summaryProducts.Where(p => p.Amount > p.StoreAmount);
                if (notEnoughProducts.Any())
                {
                    string errorMessage = "以下药品库存不足：\n";
                    foreach (var alertProduct in notEnoughProducts)
                    {
                        errorMessage += string.Format("{0} （{1}）\n", alertProduct.ProductName, alertProduct.BatchNo);
                    }
                    throw new Exception(errorMessage);
                }

                List<OutDetail> result = new List<OutDetail>();

                var products = details.Where(p => p.StructureID > 0).ToList();

                foreach (var item in products)
                {
                    if (item.AreaType == "整货")
                    {
                        item.SortOrder = 0;
                    }
                    else
                    {
                        item.SortOrder = 1;
                    }
                    //整
                    var packagingProportion = Convert.ToInt32(item.PackagingProportionString);
                    var packageAmount = item.Amount.Value / packagingProportion;
                    var packageProducts = Enumerable.Range(0, packageAmount);
                    foreach (var element in packageProducts)
                    {
                        result.Add(new OutDetail
                        {
                            DetailID = item.DetailID,
                            ProductID = item.ProductID,
                            ProductName = item.ProductName,
                            BatchNo = item.BatchNo,
                            Amount = packagingProportion,
                            PackagingProportion = packagingProportion,
                            StoreAmount = item.StoreAmount,
                            StoreOutAmount = item.StoreOutAmount,
                            AreaType = item.AreaType,
                            StatusID = item.StatusID,
                            StatusName = item.StatusName,
                            ProduceDate = item.ProduceDate,
                            ValidateDate = item.ValidateDate,
                            StructureID = item.StructureID,
                            DetailRemark = item.DetailRemark,
                            SortOrder = item.SortOrder,
                            Description = item.SortOrder == 0 ? "Z" : "L",
                        });
                    }

                    //零货
                    var mod = item.Amount % Convert.ToInt32(item.PackagingProportionString);
                    if (mod != 0)
                    {
                        result.Add(new OutDetail
                        {
                            DetailID = item.DetailID,
                            ProductID = item.ProductID,
                            ProductName = item.ProductName,
                            BatchNo = item.BatchNo,
                            Amount = mod,
                            PackagingProportion = packagingProportion,
                            StoreAmount = item.StoreAmount,
                            StoreOutAmount = item.StoreOutAmount,
                            AreaType = item.AreaType,
                            StatusID = item.StatusID,
                            StatusName = item.StatusName,
                            ProduceDate = item.ProduceDate,
                            ValidateDate = item.ValidateDate,
                            StructureID = item.StructureID,
                            DetailRemark = item.DetailRemark,
                            SortOrder = item.SortOrder,
                            Description = item.SortOrder == 0 ? "Z" : "L",
                        });
                    }

                }
                var tempResult = result.GroupBy(p => new { ProductID = p.ProductID, BatchNo = p.BatchNo }).Where(p => p.All(s => s.Description == "Z")).SelectMany(p => p).ToList();
                if (tempResult.Count > 0)
                {
                    var alertProducts = tempResult.Where(p => p.Amount != p.PackagingProportion && p.Description == "Z");
                    if (alertProducts.Any())
                    {
                        string errorMessage = "以下药品零货库存不足：\n";
                        var outErrorProducts = alertProducts.Select(p => new { p.ProductName, p.BatchNo, p.AreaType, p.Amount });
                        foreach (var alertProduct in outErrorProducts)
                        {
                            errorMessage += string.Format("{0} （{1}） - {2}({3})\n", alertProduct.ProductName,
                                alertProduct.BatchNo, alertProduct.AreaType, alertProduct.Amount);
                        }

                        throw new Exception(errorMessage);
                    }
                }
                //移除出货数与包装比例不匹配的整货
                result.RemoveAll(p => p.Amount != p.PackagingProportion && p.Description == "Z");

                var shouldTake = result
                    .OrderBy(p => p.DetailID)
                    .ThenBy(p => p.SortOrder)
                    .ThenBy(p => p.StoreAmount)
                    .ToList();

                var structures = from c in products
                                 select new OutStructureDetail
                                 {
                                     ProductID = c.ProductID,
                                     BatchNo = c.BatchNo,
                                     AreaType = c.AreaType,
                                     StoreAmount = c.StoreAmount,
                                     StructureID = c.StructureID,
                                     PackagingProportion = int.Parse(c.PackagingProportionString)
                                 };
                List<OutStructureDetail> outStructureDetails = new List<OutStructureDetail>();
                foreach (var structure in structures)
                {
                    var counts = Enumerable.Range(0, structure.StoreAmount / structure.PackagingProportion);

                    foreach (var i in counts)
                    {
                        outStructureDetails.Add(
                            new OutStructureDetail
                            {
                                ProductID = structure.ProductID,
                                BatchNo = structure.BatchNo,
                                StoreAmount = structure.PackagingProportion,
                                StructureID = structure.StructureID,
                                AreaType = structure.AreaType,
                                SortOrder = structure.AreaType == "整货" ? 0 : 1
                            }
                            );
                    }
                    var mod = structure.StoreAmount % structure.PackagingProportion;
                    if (mod > 0)
                    {
                        outStructureDetails.Add(
                            new OutStructureDetail
                            {
                                ProductID = structure.ProductID,
                                BatchNo = structure.BatchNo,
                                StoreAmount = mod,
                                StructureID = structure.StructureID,
                                AreaType = structure.AreaType,
                                SortOrder = structure.AreaType == "整货" ? 0 : 1
                            }
                            );
                    }
                }

                var outStructures =
                    outStructureDetails.OrderBy(p => p.ProductID)
                        .ThenBy(p => p.SortOrder)
                        .ThenBy(p => p.StoreAmount)
                        .ThenBy(p => p.StructureID)
                        .ToList();

                List<OutDetail> finalResult = new List<OutDetail>();
                var outBillInfo = billInfo.ToList();
                foreach (var od in shouldTake)
                {
                    var detail =
                        outStructures.FirstOrDefault(
                            p =>
                                p.StructureID == od.StructureID && p.AreaType == od.AreaType &&
                                p.ProductID == od.ProductID && p.BatchNo == od.BatchNo);

                    if (null != detail)// && od.Amount <= detail.StoreAmount)
                    {
                        if (od.AreaType == "整货" && od.Amount < detail.StoreAmount)
                        {
                            outStructures.Remove(detail);
                            continue;
                        }
                        var bi =
                            outBillInfo.FirstOrDefault(
                                p =>
                                    p.DetailID == od.DetailID && p.ProductID == detail.ProductID &&
                                    p.BatchNo == detail.BatchNo);

                        if (null != bi)
                        {
                            var totalAmount = bi.Amount;
                            var addedAmount =
                                finalResult.Where(p => p.ProductID == detail.ProductID && p.BatchNo == detail.BatchNo)
                                    .Sum(p => p.Amount) + od.Amount;

                            /* 怀柔，出库单明细可以开同药品同批号
                            if (addedAmount <= totalAmount)
                            {
                                finalResult.Add(od);
                            }
                            else
                            {
                                continue;
                            }
                             */
                            finalResult.Add(od);
                        }

                    }
                    outStructures.Remove(detail);
                }

                var finalOut = from s in finalResult
                               group s by new { s.DetailID, s.ProductID, s.BatchNo, s.StructureID }
                                   into g
                                   let d = g.FirstOrDefault()
                                   select new OutDetail
                                   {
                                       DetailID = d.DetailID,
                                       ProductID = d.ProductID,
                                       ProductName = d.ProductName,
                                       StructureID = d.StructureID,
                                       BatchNo = d.BatchNo,
                                       PackagingProportion = d.PackagingProportion,
                                       ProduceDate = d.ProduceDate,
                                       ValidateDate = d.ValidateDate,
                                       PackagingProportionString = d.PackagingProportionString,
                                       ProduceDateString = d.ProduceDateString,
                                       ValidateDateString = d.ValidateDateString,
                                       StatusID = d.StatusID,
                                       StatusName = d.StatusName,
                                       StoreID = d.StoreID,
                                       DetailRemark = d.DetailRemark,
                                       AreaType = d.AreaType,
                                       StructureName = allSturctures.FirstOrDefault(s => s.StructureID==d.StructureID) != null ? allSturctures.FirstOrDefault(s => s.StructureID==d.StructureID).StructureName: string.Empty,
                                       StoreAmount = d.StoreAmount,
                                       StoreOutAmount = g.Sum(p => p.Amount.Value),
                                       Amount = g.Sum(p => p.Amount)
                                   };

                var notEnoughProducts2 = finalOut.Where(p => p.StoreOutAmount > p.StoreAmount);
                if (notEnoughProducts2.Any())
                {
                    string errorMessage = "以下药品库存不足：\n";
                    var alertProducts = notEnoughProducts2.Select(p => new { p.ProductName, p.BatchNo, p.AreaType, p.StructureName, p.StoreAmount, p.StoreOutAmount});
                    foreach (var alertProduct in alertProducts)
                    {
                        errorMessage += string.Format("{0}（批号：{1}，数量：{2}） - 出库货位：{3}（库存：{4}）\n", alertProduct.ProductName, alertProduct.BatchNo, alertProduct.StoreOutAmount, alertProduct.StructureName, alertProduct.StoreAmount);
                    }

                    throw new Exception(errorMessage);
                }

                var detailIDs = finalOut.Select(p => p.DetailID).ToList();
                var oldDemolitions =
                    db.InventoryDemolitions.Where(p => detailIDs.Contains(p.StoreBillDetailID)).ToList();
                var oldWMSDetails =
                    db.WMSStoreBillDetails.Where(p => detailIDs.Contains(p.StoreBillDetailID)).ToList();
                foreach (var oldDemolition in oldDemolitions)
                {
                    db.InventoryDemolitions.Remove(oldDemolition);
                }
                foreach (var oldWMSDetail in oldWMSDetails)
                {
                    db.WMSStoreBillDetails.Remove(oldWMSDetail);
                }
                db.SaveChanges();

                var iv = from s in finalOut
                         from i in allSturctures
                         where s.StructureID == i.StructureID
                         select new
                         {
                             OutDetail = s,
                             StructureID = i.StructureID,
                             StructureCode = i.StructureCode,
                             StructureName = i.StructureName,
                             StructureStyle = i.StructureStyle
                         };
                foreach (var outDetail in iv)
                {
                    var inventoryDemolition = new InventoryDemolition
                    {
                        StoreBillDetailID = outDetail.OutDetail.DetailID
                    };
                    if (outDetail.OutDetail.AreaType == "整货")
                    {
                        inventoryDemolition.EntireCargoStructureID = outDetail.StructureID;
                        inventoryDemolition.EntireCargoStructureName = outDetail.StructureName;
                        inventoryDemolition.EntireCargoStructureCode = outDetail.StructureCode;
                        inventoryDemolition.EntireCargoAmount = outDetail.OutDetail.Amount;
                    }
                    else if (outDetail.OutDetail.AreaType == "零货")
                    {
                        inventoryDemolition.ScatteredCargoStructureID = outDetail.StructureID;
                        inventoryDemolition.ScatteredCargoStructureName = outDetail.StructureName;
                        inventoryDemolition.ScatteredCargoStructureCode = outDetail.StructureCode;
                        inventoryDemolition.ScatteredCargoAmount = outDetail.OutDetail.Amount;
                    }
                    db.InventoryDemolitions.Add(inventoryDemolition);

                    var wmsStoreBillDetail = new WMSStoreBillDetail
                    {
                        WMSDetailID = Guid.NewGuid(),
                        StoreBillDetailID = outDetail.OutDetail.DetailID,
                        StoreID = storeId,
                        ProductID = outDetail.OutDetail.ProductID,
                        BatchNo = outDetail.OutDetail.BatchNo,
                        Amount = outDetail.OutDetail.Amount.Value,
                        StatusID = storeBill.StoreStatusID,
                        StatusName = storeBill.StoreStatusName,
                        StructureID = outDetail.OutDetail.StructureID,
                        StructureCode = outDetail.StructureCode,
                        DetailRemark = outDetail.OutDetail.DetailRemark,
                        ProduceDate = outDetail.OutDetail.ProduceDate,
                        ValidateDate = outDetail.OutDetail.ValidateDate,
                        CreateDate = DateTime.Today
                    };
                    db.WMSStoreBillDetails.Add(wmsStoreBillDetail);

                    if (outDetail.StructureStyle.HasValue)
                    {
                        //电子标签
                        if (outDetail.StructureStyle.Value == 1)
                        {
                            //找标签
                            var elabels = from l in db.LabelStructures
                                          where l.StructureID == outDetail.StructureID
                                          join el in db.ElectronicLabels on l.LabelID equals el.LabelID into g
                                          from s in g.DefaultIfEmpty()
                                          join pel in db.ElectronicLabels on s.ParentLabelID equals pel.LabelID into gl
                                          from ps in gl.DefaultIfEmpty()
                                          select new
                                          {
                                              StructrueID = l.StructureID,
                                              LabelID = l.LabelID,
                                              LabelCode = s.LabelCode,
                                              LabelAddress = s.LabelAddress,
                                              LabelPort = s.LabelPortName,
                                              LabelType = s.LabelType,
                                              LightCode = ps.LabelCode,
                                              LightAddress = ps.LabelAddress,
                                              LightComPort = ps.LabelPortName

                                          };
                            if (elabels.Any())
                            {
                                var elabel = elabels.First();
                                db.LabelTasks.Add(new LabelTask
                                {
                                    BillDetailID = outDetail.OutDetail.DetailID,
                                    WMSDetailID = wmsStoreBillDetail.WMSDetailID,
                                    StructureID = outDetail.OutDetail.StructureID,
                                    BatchNo = outDetail.OutDetail.BatchNo,
                                    LabelID = elabel.LabelID,
                                    LabelCode = elabel.LabelCode,
                                    LabelAddress = elabel.LabelAddress,
                                    LabelType = 1,
                                    LabelComPort = int.Parse(elabel.LabelPort.Replace("COM", "")),
                                    LightCode = elabel.LightCode,
                                    LightAddress = elabel.LightAddress,
                                    LightComPort = int.Parse(elabel.LightComPort.Replace("COM", "")),
                                    LabelStatus = 0,
                                    StockOutNo = storeBill.StoreCode,
                                    MedicineCode = outDetail.OutDetail.ProductID.ToString(),
                                    StructureCode = Convert.ToInt16(outDetail.StructureCode.Substring(outDetail.StructureCode.Length - 2, 2)),
                                    StructureLocation = outDetail.StructureName,
                                    Amount = outDetail.OutDetail.Amount,
                                    TaskStatus = 0,
                                });
                            }
                        }
                        //PDA
                        else if (outDetail.StructureStyle.Value == 2)
                        {
                            db.PDATasks.Add(new PDATask
                            {
                                StoreID = storeId,
                                BillDetailID = outDetail.OutDetail.DetailID,
                                WMSDetailID = wmsStoreBillDetail.WMSDetailID,
                                StructureID = outDetail.OutDetail.StructureID,
                                StructureCode = outDetail.StructureCode,
                                BatchNo = outDetail.OutDetail.BatchNo,
                                ProductID = outDetail.OutDetail.ProductID,
                                ProductName = outDetail.OutDetail.ProductName,
                                ProduceDate = outDetail.OutDetail.ProduceDate,
                                ValidateDate = outDetail.OutDetail.ValidateDate,
                                //StoreAmount = outDetail.OutDetail.StoreAmount
                                Amount = outDetail.OutDetail.Amount,
                                TaskStatusID = 0,
                                TaskStatus = "正在出库"
                            });
                        }
                    }
                }

                if (!finalOut.Any())
                {
                    string errorMessage = "药品零货库存不足：\n";
                    foreach (var alertProduct in notEnoughProducts)
                    {
                        errorMessage += string.Format("{0} （{1}）\n", alertProduct.ProductName, alertProduct.BatchNo);
                    }
                    throw new Exception(errorMessage);
                }
                var incorrectAmountDetails =
                    db.StoreBillDetails.Where(p => p.StoreID == storeId && p.Amount != p.StoreAmount).ToList();
                foreach (var detail in incorrectAmountDetails)
                {
                    detail.StoreAmount = detail.Amount;
                }

                db.SaveChanges();
                return finalOut.ToList();
            }
        }

        public List<OutDetail> SplitStoreOutBillDetailsForPDA(int storeId)
        {
            using(var db = new WMSContext())
            {
                //用于保存出库库存异常日志
                List<StoreOutErrorLog> storeOutErrorLogs = new List<StoreOutErrorLog>();

                //按单据移除出库信息异常日志
                db.Database.ExecuteSqlCommand(string.Format("DELETE dbo.WMS_StoreOutErrorLog WHERE StoreID={0}", storeId));


                #region 取单据明细信息：单号，药品，批号，数量

                var billInfo = (from s in db.StoreBillDetails
                                from b in db.StoreBills
                                where s.StoreID == b.StoreID && s.StoreID == storeId
                                join p in db.Products on s.ProductID equals p.ProductID into g
                                from i in g.DefaultIfEmpty()
                                select new StoreBillDetailViewModel
                                {
                                    StoreID = b.StoreID,
                                    StoreCode = b.StoreCode,
                                    DetailID = s.DetailID,
                                    ProductID = s.ProductID,
                                    ProductName = i.ProductName,
                                    BatchNo = s.BatchNo,
                                    ProduceDate = s.ProduceDate,
                                    ValidateDate = s.ValidateDate,
                                    PackageSpec = i.PackageSpec,
                                    PackagingProportionString = i.PackagingProportion,
                                    Amount = s.Amount.Value,
                                    StatusID = s.StatusID,
                                    StatusName = s.StatusName,
                                    DetailRemark = s.DetailRemark,
                                }).ToList();
                #endregion

                #region 检测药品品种及库存是否满足出库要求：是否缺货或库存总数不足

                //1 - 检测药品品种及库存是否满足出库要求：是否缺货或库存总数不足
                //为防止单据明细有有同药品及批号的记录，必须先做汇总
                var summaryDetails = (from d in billInfo
                                      group d by new
                                      {
                                          d.ProductID,
                                          d.BatchNo
                                      } into g
                                      select new
                                      {
                                          ProductID = g.Key.ProductID,
                                          BatchNo = g.Key.BatchNo,
                                          Amount = g.Sum(p => p.Amount.Value)
                                      }).ToList();
                //2 - 汇总实际库存
                var summaryStore = (from c in db.CargoSpaceStoreDetails
                                    from s in db.StorageStructures
                                    where s.StructureID == c.StructureID
                                        && s.IsActive.HasValue
                                        && s.IsActive.Value
                                    group c by new
                                    {
                                        c.ProductID,
                                        c.ProductBatchNumber
                                    } into g
                                    select new
                                    {
                                        ProductID = g.Key.ProductID,
                                        BatchNo = g.Key.ProductBatchNumber,
                                        Amount = g.Sum(p => p.ProductAmount.Value)
                                    }).ToList();

                //缺货记录
                List<ProductComparer> billProducts = summaryDetails.Select(p => new ProductComparer
                {
                    ProductID = p.ProductID,
                    BatchNo = p.BatchNo
                }).ToList();
                List<ProductComparer> storeProducts = summaryStore.Select(p => new ProductComparer
                {
                    ProductID = p.ProductID.Value,
                    BatchNo = p.BatchNo
                }).ToList();
                List<ProductComparer> noStoreProducts = billProducts.Except(storeProducts, new ProductEquality()).ToList();
                //缺货汇总
                var noProducts = from s in noStoreProducts
                                 from c in summaryDetails
                                 where s.ProductID == c.ProductID
                                 && s.BatchNo == c.BatchNo
                                 select new
                                 {
                                     s.ProductID,
                                     s.BatchNo,
                                     OutAmount = c.Amount,
                                     StoreAmount = 0,
                                     StructureID = -1,
                                     StructureCode = "",
                                     StructureName = ""
                                 };
                //总库存数不满足的记录
                //1-只检测有货的记录
                var notEnoughStores = (from s in summaryStore
                                       from d in summaryDetails
                                       where s.ProductID == d.ProductID
                                       && s.BatchNo == d.BatchNo
                                       && d.Amount > s.Amount
                                       select new
                                       {
                                           ProductID = d.ProductID,
                                           BatchNo = d.BatchNo,
                                           OutAmount = d.Amount,
                                           StoreAmount = s.Amount,
                                       }).ToList();

                //库存不足货位 - 药品、批号未对应
                var notEnoughStoreProductIDs = notEnoughStores.Select(p => p.ProductID).ToList();
                var notEnoughStoreProductBatchNos = notEnoughStores.Select(p => p.BatchNo).ToList();
                var notEnoughCargoPlaces = (from c in db.CargoSpaceStoreDetails
                                            from s in db.StorageStructures
                                            from w in db.Warehouses
                                            where s.StructureID == c.StructureID
                                                && w.WarehouseID == s.WarehouseID
                                                && notEnoughStoreProductIDs.Contains(c.ProductID.Value)
                                                && notEnoughStoreProductBatchNos.Contains(c.ProductBatchNumber)
                                                && s.IsActive.HasValue
                                                && s.IsActive.Value
                                            select new
                                            {
                                                c.ProductID,
                                                c.ProductBatchNumber,
                                                c.ProductAmount,
                                                w.WarehouseID,
                                                w.WarehouseName,
                                                s.StructureID,
                                                s.StructureCode,
                                                s.StructureName
                                            }).ToList();

                //库存不足货位 - 对应药品、批号
                var notEnoughStructures = from s in notEnoughStores
                                          from c in notEnoughCargoPlaces
                                          where s.ProductID == c.ProductID
                                          && s.BatchNo == c.ProductBatchNumber
                                          select new
                                          {
                                              s.ProductID,
                                              s.BatchNo,
                                              s.OutAmount,
                                              StoreAmount = c.ProductAmount,
                                              c.WarehouseID,
                                              c.WarehouseName,
                                              c.StructureID,
                                              c.StructureCode,
                                              c.StructureName
                                          };

                if(noProducts.Any() || notEnoughStructures.Any())
                {
                    foreach(var p in noProducts)
                    {
                        var detail = billInfo.FirstOrDefault(d => d.ProductID == p.ProductID
                        && d.BatchNo == p.BatchNo);

                        storeOutErrorLogs.Add(new StoreOutErrorLog
                        {
                            StoreID = detail.StoreID,
                            StoreCode = detail.StoreCode,
                            DetailID = detail.DetailID,
                            StructureID = p.StructureID,
                            StructureCode = p.StructureCode,
                            StructureName = p.StructureName,
                            ProductID = p.ProductID,
                            ProductName = detail.ProductName,
                            PackageSpec = detail.PackageSpec,
                            ProduceDate = detail.ProduceDate,
                            ValidateDate = detail.ValidateDate,
                            BatchNumber = detail.BatchNo,
                            Amount = p.OutAmount,
                            StoreAmount = p.StoreAmount,
                            Reason = string.Format("药品 {0}（批号：{1}，数量：{2}） 无库存",
                                                    detail.ProductName,
                                                    p.BatchNo,
                                                    p.OutAmount,
                                                    p.StructureName,
                                                    p.StoreAmount)
                        });
                    }
                    foreach(var p in notEnoughStructures)
                    {
                        var detail = billInfo.FirstOrDefault(d => d.ProductID == p.ProductID
                        && d.BatchNo == p.BatchNo);

                        storeOutErrorLogs.Add(new StoreOutErrorLog
                        {
                            StoreID = detail.StoreID,
                            StoreCode = detail.StoreCode,
                            DetailID = detail.DetailID,
                            WarehouseID = p.WarehouseID,
                            WarehouseName = p.WarehouseName,
                            StructureID = p.StructureID,
                            StructureCode = p.StructureCode,
                            StructureName = p.StructureName,
                            ProductID = p.ProductID,
                            ProductName = detail.ProductName,
                            PackageSpec = detail.PackageSpec,
                            ProduceDate = detail.ProduceDate,
                            ValidateDate = detail.ValidateDate,
                            BatchNumber = detail.BatchNo,
                            Amount = p.OutAmount,
                            StoreAmount = p.StoreAmount,
                            Reason = string.Format("药品 {0}（批号：{1}，数量：{2}） 库存不足。出库货位：{3}（库存：{4}）",
                                                    detail.ProductName,
                                                    p.BatchNo,
                                                    p.OutAmount,
                                                    p.StructureName,
                                                    p.StoreAmount)
                        });
                    }
                    foreach(var storeOutErrorLog in storeOutErrorLogs)
                    {
                        db.StoreOutErrorLogs.Add(storeOutErrorLog);
                    }
                    db.SaveChanges();

                    //TODO: 移除以下语句注释
                    if(storeOutErrorLogs.Any())
                    {
                        return null;
                        //string errorMessage = "以下药品库存不足：\n";
                        //foreach(var storeOutErrorLog in storeOutErrorLogs)
                        //{
                        //    errorMessage += string.Format("{0}\n", storeOutErrorLog.Reason);
                        //}
                        //throw new Exception(errorMessage);
                    }
                }

                #endregion

                //满足出库要求，根据出库规则找货位
                //出库规则：
                // 1). 货位清空原则：从少到多，从零到整。最少货位库存相加能出优先
                // 2). 整货优先原则：凑整件，优先从整货位出

                #region 获取所有与出库明细相关的货位

                var allStoreOutSturctures = (
                                    from sd in db.StoreBillDetails
                                    from cs in db.CargoSpaceStoreDetails
                                    from ss in db.StorageStructures
                                    from w in db.Warehouses
                                    from p in db.Products
                                    where sd.StoreID == storeId
                                        && sd.ProductID == cs.ProductID.Value
                                        && sd.ProductID == p.ProductID
                                        && sd.BatchNo == cs.ProductBatchNumber
                                        && cs.StructureID == ss.StructureID
                                        && w.WarehouseID == ss.WarehouseID
                                        && ss.IsActive.HasValue
                                        && ss.IsActive.Value
                                    select new
                                    {
                                        sd.StoreID,
                                        sd.DetailID,
                                        cs.ProductID,
                                        p.ProductName,
                                        //sd.BatchNo,
                                        cs.ProductBatchNumber,
                                        sd.Amount,
                                        cs.ProductAmount,
                                        p.ProducerName,
                                        sd.ProduceDate,
                                        sd.ValidateDate,
                                        sd.StatusID,
                                        sd.StatusName,
                                        sd.DetailRemark,
                                        p.PackagingProportion,
                                        p.ProductSpec,
                                        p.PackageSpec,
                                        cs.StructureID,
                                        ss.StructureCode,
                                        ss.StructureName,
                                        ss.StructureStyle,
                                        ss.AreaType,
                                        w.WarehouseID,
                                        w.WarehouseName,
                                        StoreEnvironment = p.StockCondition
                                    })
                                    .OrderBy(p => p.ProductID)
                                    .ThenBy(p => p.ProductBatchNumber)
                                    .ThenBy(p => p.ProductAmount)
                                    .ToList();
                //if(!allStoreOutSturctures.Any())
                //{
                //    throw new Exception(string.Format("没有足够的零货货位可供拆零处理：\n拆零整货货位: {0}({1})\n药品：{2}(批号：{3})",
                //                                                  entireLocation.StructureName,
                //                                                  entireLocation.StructureCode,
                //                                                  entireLocation.ProductName,
                //                                                  entireLocation.BatchNo));
                //}
                //货位清空原则
                Dictionary<ProductStructureCompare, int> leftAmounts = new Dictionary<ProductStructureCompare, int>();
                summaryDetails.ForEach(p => leftAmounts.Add(new ProductStructureCompare
                {
                    ProductID = p.ProductID,
                    BatchNo = p.BatchNo
                }, p.Amount));
                Dictionary<int, int> outtedStoreAmounts = new Dictionary<int, int>();
                List<OutDetail> outDetails = new List<OutDetail>();

                foreach(var item in allStoreOutSturctures)
                {
                    var key = new ProductStructureCompare
                    {
                        ProductID = item.ProductID.Value,
                        BatchNo = item.ProductBatchNumber
                    };

                    //1 - 先挑出单一货位满足出库要求的记录
                    if(leftAmounts.ContainsKey(key))
                    {
                        if(leftAmounts[key] > 0)
                        {
                            int outAmount = 0;

                            // 剩余要出的数
                            var leftAmount = leftAmounts[key];
                            //货位现有数量 == 剩余要出库数量，货位出空
                            if(item.ProductAmount.Value <= leftAmount)
                            {
                                outAmount = item.ProductAmount.Value;
                                leftAmounts[key] -= outAmount;
                            }
                            else if(item.ProductAmount.Value > leftAmount)
                            {
                                //货位现有数量 > 剩余要出库数量，货位出库数量为剩余要出库数量
                                outAmount = leftAmount;
                                leftAmounts[key] -= outAmount;
                            }

                            if(!outtedStoreAmounts.ContainsKey(item.StructureID))
                            {
                                outtedStoreAmounts.Add(item.StructureID, outAmount);
                            }
                            else
                            {
                                outtedStoreAmounts[item.StructureID] += outAmount;
                            }
                            outDetails.Add(new OutDetail
                            {
                                StoreID = item.StoreID,
                                StoreCode = billInfo.First().StoreCode,
                                DetailID = item.DetailID,
                                ProductID = item.ProductID.Value,
                                ProductName = item.ProductName,
                                BatchNo = item.ProductBatchNumber,
                                Amount = item.Amount,
                                StoreOutAmount = outAmount,
                                StoreAmount = item.ProductAmount.Value,
                                ProducerName = item.ProducerName,
                                ProduceDate = item.ProduceDate,
                                ValidateDate = item.ValidateDate,
                                ProduceDateString = item.ProduceDate.HasValue ? item.ProduceDate.Value.ToString("yyyy-MM-dd") : "",
                                ValidateDateString = item.ValidateDate.HasValue ? item.ValidateDate.Value.ToString("yyyy-MM-dd") : "",
                                StatusID = item.StatusID,
                                StatusName = item.StatusName,
                                DetailRemark = item.DetailRemark,
                                PackagingProportion = Convert.ToInt32(item.PackagingProportion),
                                PackagingProportionString = item.PackagingProportion,
                                PackageSpec = item.PackageSpec,
                                ProductSpec = item.ProductSpec,
                                StructureID = item.StructureID,
                                StructureCode = item.StructureCode,
                                StructureName = item.StructureName,
                                AreaType = item.AreaType,
                                WarehouseID = item.WarehouseID,
                                WarehouseName = item.WarehouseName,
                                StoreEnvironment = item.StoreEnvironment
                            });
                        }
                    }
                }

                //如果出库位为整货，且此货位出库数为零货，需要加拆分记录，并同时更新整货、零货数量
                var entireLocations = outDetails.Where(p => p.AreaType == "整货" && p.StoreOutAmount % p.PackagingProportion != 0).ToList();
                if(entireLocations.Any())
                {
                    foreach(var entireLocation in entireLocations)
                    {
                        //不能整除包装比例，说明需要拆1件成零货

                        //出货数
                        int outAmount = entireLocation.StoreOutAmount;
                        //移库数
                        int moveStoreAmount = entireLocation.PackagingProportion;

                        //在要出库的零货位找同药品、批号的记录
                        var moveToLocation = outDetails.FirstOrDefault(p => p.ProductID == entireLocation.ProductID
                                                                        && p.BatchNo == entireLocation.BatchNo
                                                                        && p.AreaType == "零货");
                        int moveToLocationID = 0;
                        if(null == moveToLocation)
                        {
                            //找空的零货位
                            var structures = (from s in db.StorageStructures
                                              where s.IsMinStructure == true && s.AreaType == "零货" && s.IsActive.HasValue && s.IsActive.Value
                                              join c in db.CargoSpaceStoreDetails on s.StructureID equals c.StructureID into g
                                              from gi in g.DefaultIfEmpty()
                                              join w in db.Warehouses on s.WarehouseID equals w.WarehouseID
                                              where gi.ProductID == null && w.WarehouseType == entireLocation.StoreEnvironment
                                              select new
                                              {
                                                  s.StructureID,
                                                  s.StructureCode,
                                                  s.StructureName,
                                                  s.AreaType,
                                                  w.WarehouseID,
                                                  w.WarehouseName
                                              }).ToList();
                            if (structures.Count <= 0)
                            {
                                throw new Exception(string.Format("没有足够的零货货位可供拆零处理：\n拆零整货货位: {0}({1})\n药品：{2}(批号：{3})",
                                                                  entireLocation.StructureName,
                                                                  entireLocation.StructureCode,
                                                                  entireLocation.ProductName,
                                                                  entireLocation.BatchNo));
                            }
                            else
                            {
                                var structure = structures.First();
                                moveToLocation = new OutDetail
                                                 {
                                                     StoreID = entireLocation.StoreID,
                                                     StoreCode = entireLocation.StoreCode,
                                                     DetailID = entireLocation.DetailID,
                                                     ProductID = entireLocation.ProductID,
                                                     ProductName = entireLocation.ProductName,
                                                     BatchNo = entireLocation.BatchNo,
                                                     Amount = outAmount%moveStoreAmount,
                                                     StoreOutAmount = outAmount%moveStoreAmount,
                                                     StoreAmount = moveStoreAmount,
                                                     ProducerName = entireLocation.ProducerName,
                                                     ProduceDate = entireLocation.ProduceDate,
                                                     ValidateDate = entireLocation.ValidateDate,
                                                     ProduceDateString = entireLocation.ProduceDateString,
                                                     ValidateDateString = entireLocation.ValidateDateString,
                                                     StatusID = entireLocation.StatusID,
                                                     StatusName = entireLocation.StatusName,
                                                     DetailRemark = entireLocation.DetailRemark,
                                                     PackagingProportion = entireLocation.PackagingProportion,
                                                     PackagingProportionString =
                                                         entireLocation.PackagingProportionString,
                                                     PackageSpec = entireLocation.PackageSpec,
                                                     ProductSpec = entireLocation.ProductSpec,
                                                     StructureID = structure.StructureID,
                                                     StructureCode = structure.StructureCode,
                                                     StructureName = structure.StructureName,
                                                     AreaType = structure.AreaType,
                                                     WarehouseID = structure.WarehouseID,
                                                     WarehouseName = structure.WarehouseName,
                                                     StoreEnvironment = entireLocation.StoreEnvironment
                                                 };
                                outDetails.Add(moveToLocation);

                                //保存新增的零货位库存信息
                                db.CargoSpaceStoreDetails.Add(new CargoSpaceStoreDetail
                                                              {
                                                                  StructureID = moveToLocation.StructureID,
                                                                  ProductID = moveToLocation.ProductID,
                                                                  ProductBatchNumber = moveToLocation.BatchNo,
                                                                  ProductionDate = moveToLocation.ProduceDate,
                                                                  ProductValidDate = moveToLocation.ValidateDate,
                                                                  ProductAmount = moveStoreAmount,
                                                                  Manufacturer = moveToLocation.ProducerName,
                                                                  DosageForm = moveToLocation.ProductSpec,
                                                                  PackagingSpecification =
                                                                      moveToLocation.PackagingProportionString,
                                                              });
                                var location = db.CargoSpaceStoreDetails.FirstOrDefault(p => 
                                                                            p.StructureID == entireLocation.StructureID 
                                                                            && p.ProductID == entireLocation.ProductID 
                                                                            && p.ProductBatchNumber == entireLocation.BatchNo);
                                if (location != null)
                                {
                                    location.ProductAmount -= moveStoreAmount;
                                }

                                //整货出库货位修改，零货已变为从拆零后零货位出，移除出零货数的整货出库位
                                outDetails.Remove(entireLocation);

                                #region 保存货位拆分记录

                                var oldDemolitions =
                                    db.InventoryDemolitions.Where(p => p.StoreBillDetailID == entireLocation.DetailID)
                                      .ToList();
                                var oldWMSDetails =
                                    db.WMSStoreBillDetails.Where(p => p.StoreBillDetailID == entireLocation.DetailID)
                                      .ToList();
                                foreach (var oldDemolition in oldDemolitions)
                                {
                                    db.InventoryDemolitions.Remove(oldDemolition);
                                }
                                foreach (var oldWMSDetail in oldWMSDetails)
                                {
                                    db.WMSStoreBillDetails.Remove(oldWMSDetail);
                                }

                                var inventoryDemolition = new InventoryDemolition
                                                          {
                                                              StoreBillDetailID = entireLocation.DetailID
                                                          };
                                inventoryDemolition.EntireCargoStructureID = entireLocation.StructureID;
                                inventoryDemolition.EntireCargoStructureName = entireLocation.StructureName;
                                inventoryDemolition.EntireCargoStructureCode = entireLocation.StructureCode;
                                inventoryDemolition.EntireCargoAmount = moveStoreAmount;

                                inventoryDemolition.ScatteredCargoStructureID = moveToLocation.StructureID;
                                inventoryDemolition.ScatteredCargoStructureName = moveToLocation.StructureName;
                                inventoryDemolition.ScatteredCargoStructureCode = moveToLocation.StructureCode;
                                inventoryDemolition.ScatteredCargoAmount = 0;

                                db.InventoryDemolitions.Add(inventoryDemolition);

                                #endregion

                                db.SaveChanges();
                            }
                        }
                        else
                        {
                            //整货位库存减一个包装比例数
                            entireLocation.StoreAmount -= moveStoreAmount;
                            entireLocation.Amount -= outAmount % moveStoreAmount;
                            //整货位出库数减掉零货出库数，保证此货位出整数
                            entireLocation.StoreOutAmount -= outAmount % moveStoreAmount;

                            //更新源货位库存数量
                            var sourceLocation = db.CargoSpaceStoreDetails.FirstOrDefault(p => p.StructureID == entireLocation.StructureID);
                            if(null != sourceLocation)
                            {
                                sourceLocation.ProductAmount -= moveStoreAmount;
                            }


                            //目的零货位加一个包装比例数
                            moveToLocation.StoreAmount += moveStoreAmount;
                            //整货位出的零数改为从零货位出
                            moveToLocation.Amount += outAmount % moveStoreAmount;
                            moveToLocation.StoreOutAmount += outAmount % moveStoreAmount;
                            //更新目的货位库存数量
                            var targetLocation = db.CargoSpaceStoreDetails.FirstOrDefault(p => p.StructureID == moveToLocation.StructureID);
                            if(null != targetLocation)
                            {
                                targetLocation.ProductAmount += moveStoreAmount;
                            }

                            //整货出库货位修改，零货已变为从拆零后零货位出，移除出零货数的整货出库位
                            if (entireLocation.StoreAmount == 0)
                            {
                                outDetails.Remove(entireLocation);
                            }

                            #region 保存货位拆分记录

                            var oldDemolitions = db.InventoryDemolitions.Where(p => p.StoreBillDetailID == entireLocation.DetailID).ToList();
                            var oldWMSDetails = db.WMSStoreBillDetails.Where(p => p.StoreBillDetailID == entireLocation.DetailID).ToList();
                            foreach(var oldDemolition in oldDemolitions)
                            {
                                db.InventoryDemolitions.Remove(oldDemolition);
                            }
                            foreach(var oldWMSDetail in oldWMSDetails)
                            {
                                db.WMSStoreBillDetails.Remove(oldWMSDetail);
                            }

                            var inventoryDemolition = new InventoryDemolition
                            {
                                StoreBillDetailID = entireLocation.DetailID
                            };
                            inventoryDemolition.EntireCargoStructureID = entireLocation.StructureID;
                            inventoryDemolition.EntireCargoStructureName = entireLocation.StructureName;
                            inventoryDemolition.EntireCargoStructureCode = entireLocation.StructureCode;
                            inventoryDemolition.EntireCargoAmount = moveStoreAmount;

                            inventoryDemolition.ScatteredCargoStructureID = moveToLocation.StructureID;
                            inventoryDemolition.ScatteredCargoStructureName = moveToLocation.StructureName;
                            inventoryDemolition.ScatteredCargoStructureCode = moveToLocation.StructureCode;
                            inventoryDemolition.ScatteredCargoAmount = 0;

                            db.InventoryDemolitions.Add(inventoryDemolition);

                            #endregion

                            db.SaveChanges();
                        }
                    }
                }

                #endregion

                foreach(var outDetail in outDetails)
                {
                    var wmsStoreBillDetail = new WMSStoreBillDetail
                    {
                        WMSDetailID = Guid.NewGuid(),
                        StoreBillDetailID = outDetail.DetailID,
                        StoreID = storeId,
                        ProductID = outDetail.ProductID,
                        BatchNo = outDetail.BatchNo,
                        Amount = outDetail.StoreOutAmount,
                        StatusID = "0",
                        StatusName = "正在出库",
                        StructureID = outDetail.StructureID,
                        StructureCode = outDetail.StructureCode,
                        DetailRemark = outDetail.DetailRemark,
                        ProduceDate = outDetail.ProduceDate,
                        ValidateDate = outDetail.ValidateDate,
                        CreateDate = DateTime.Today
                    };
                    db.WMSStoreBillDetails.Add(wmsStoreBillDetail);

                    db.PDATasks.Add(new PDATask
                    {
                        StoreID = storeId,
                        BillDetailID = outDetail.DetailID,
                        WMSDetailID = wmsStoreBillDetail.WMSDetailID,
                        StructureID = outDetail.StructureID,
                        StructureCode = outDetail.StructureCode,
                        BatchNo = outDetail.BatchNo,
                        ProductID = outDetail.ProductID,
                        ProductName = outDetail.ProductName,
                        ProduceDate = outDetail.ProduceDate,
                        ValidateDate = outDetail.ValidateDate,
                        BillAmount = outDetail.Amount,
                        StoreAmount = outDetail.StoreAmount,
                        ProductSpec = outDetail.ProductSpec,
                        Amount = outDetail.StoreOutAmount,
                        TaskStatusID = 0,
                        TaskStatus = "正在出库"
                    });
                    var cargoSpace = db.CargoSpaceStoreDetails.FirstOrDefault(p => p.ProductID == outDetail.ProductID
                        && p.ProductBatchNumber == outDetail.BatchNo
                        && p.StructureID == outDetail.StructureID);
                    if(null != cargoSpace)
                    {
                        cargoSpace.ProductAmount = cargoSpace.ProductAmount - outDetail.StoreOutAmount;

                    }
                    var billDetail = db.StoreBillDetails.FirstOrDefault(p => p.DetailID == outDetail.DetailID);
                    if(null != billDetail)
                    {
                        billDetail.StoreAmount = billDetail.StoreAmount - outDetail.StoreOutAmount;
                    }

                    db.SaveChanges();
                }

                db.Database.ExecuteSqlCommand("DELETE dbo.WMS_CargoSpaceStoreDetail WHERE ProductAmount=0");

                return outDetails.ToList();
            }
        }

        private string GetStoreBillStatusName(StoreBillStatuses storeBillStatus, bool? isBillIn)
        {
            string operating = (!isBillIn.HasValue ? "入库" : (isBillIn.Value ? "入库" : "出库"));

            switch (storeBillStatus)
            {
                case StoreBillStatuses.Waiting:
                    return "等待" + operating;
                case StoreBillStatuses.Processing:
                    return "正在" + operating;
                case StoreBillStatuses.Stop:
                    return "停止" + operating;
                case StoreBillStatuses.Complete:
                    return "完成" + operating;
                case StoreBillStatuses.Error:
                    return operating + "异常";
            }
            return string.Empty;
        }
    }
}
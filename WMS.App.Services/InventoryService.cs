using System;
using System.Collections.Generic;
using System.Linq;
using WMS.Model;

namespace WMS.App.Services
{
    public class InventoryService : IInventoryService
    {
        public List<InventoryViewModel> SearchInventory(string structureCode, string productName, string batchNumber, string areaType)
        {
            using (var db = new WMSContext())
            {
                var products = from ssd in db.CargoSpaceStoreDetails
                    join s in db.StorageStructures on ssd.StructureID equals s.StructureID
                    join p in db.Products on ssd.ProductID equals p.ProductID
                    select new InventoryViewModel
                    {
                        AreaType = s.AreaType,
                        CargoSpaceStoreDetailID = ssd.CargoSpaceStoreDetailID,
                        ProductID = p.ProductID,
                        StructureCode = s.StructureCode,
                        StructureName = s.StructureName,
                        StructureLocation = s.StructureLocation,
                        ProductCode = p.ProductCode,
                        ProductName = p.ProductName,
                        ProductBarCode = p.ProductBarCode,
                        ProducerName = p.ProducerName,
                        ProductSpell = p.ProductSpell,
                        ProductSpec = p.ProductSpec,
                        PackageSpec = p.PackageSpec,
                        PackagingProportion = p.PackagingProportion,
                        ProductBatchNumber = ssd.ProductBatchNumber,
                        ProductAmount = ssd.ProductAmount,
                        ProductionDate = ssd.ProductionDate,
                        ProductValidDate = ssd.ProductValidDate,
                        StockCondition = p.StockCondition,
                        PhysicType = p.PhysicType,
                        AuthorizedNo = p.AuthorizedNo
                    };
                if (!string.IsNullOrWhiteSpace(areaType))
                {
                    if (areaType == "合格品")
                    {
                        products = products.Where(p => p.AreaType.Contains("整货") || p.AreaType.Contains("零货"));
                    }
                    else
                    {
                        products = products.Where(p => p.AreaType.Contains(areaType));
                    }
                }
                if (!string.IsNullOrWhiteSpace(productName))
                {
                    products = products.Where(p => p.ProductName.Contains(productName) || p.ProductSpell.Contains(productName));
                }
                if (!string.IsNullOrWhiteSpace(structureCode))
                {
                    products = products.Where(p => p.StructureCode.Contains(structureCode) || p.StructureName.Contains(structureCode));
                }
                if (!string.IsNullOrWhiteSpace(batchNumber))
                {
                    products = products.Where(p => p.ProductBatchNumber.Contains(batchNumber));
                }
                return products.ToList();
            }
        }

        public List<InventoryViewModel> SearchStoreDetail(string productname)
        {
            using (var db = new WMSContext())
            {
                var products = from ssd in db.CargoSpaceStoreDetails
                               join p in db.Products on ssd.ProductID equals p.ProductID
                               select new InventoryViewModel
                               {
                                   CargoSpaceStoreDetailID = ssd.CargoSpaceStoreDetailID,
                                   ProductID = p.ProductID,
                                   ProductCode = p.ProductCode,
                                   ProductSpell = p.ProductSpell,
                                   ProductName = p.ProductName,
                                   ProducerName = p.ProducerName,
                                   PackageSpec = p.ProductSpec,
                                   ProductBatchNumber = ssd.ProductBatchNumber,
                                   ProductAmount = ssd.ProductAmount,
                                   ProductionDate = ssd.ProductionDate,
                                   ProductValidDate = ssd.ProductValidDate,
                                   PhysicType = p.PhysicType
                               };

                if (!string.IsNullOrWhiteSpace(productname))
                {
                    products = products.Where(p => p.ProductName.Contains(productname) || p.ProductSpell.Contains(productname));
                }
                return products.ToList();
            }
        }

        public bool GenerateBusinessInventory(string changeUsername, string action = "WMS库存盘点自动同步")
        {
            try
            {
                using (var db = new WMSContext())
                {
                    var data = from s in db.CargoSpaceStoreDetails
                        join ss in db.StorageStructures on s.StructureID equals ss.StructureID
                        where !ss.AreaType.Contains("不合格") && !ss.AreaType.Contains("退货")
                        select new
                        {
                            s.CargoSpaceStoreDetailID,
                            s.ProductID,
                            s.ProductBatchNumber,
                            s.ProductionDate,
                            s.ProductValidDate,
                            s.ProductAmount,
                            ss.AreaType
                        };
                    var inventories = (from s in data
                        group s by new {s.ProductID, s.ProductBatchNumber}
                        into g
                        select new
                        {
                            ProductID = g.Key.ProductID.Value,
                            BatchNo = g.Key.ProductBatchNumber,
                            ProduceDate = g.FirstOrDefault().ProductionDate,
                            ValidateDate = g.FirstOrDefault().ProductValidDate,
                            Amount = g.Sum(p => p.ProductAmount)
                        }).ToList();
                    var storeDetails = db.StoreDetails.ToList();
                    foreach (var inventory in inventories)
                    {
                        var businessStore =
                            storeDetails.FirstOrDefault(
                                p => p.ProductID == inventory.ProductID && p.BatchNo == inventory.BatchNo);
                        if (null == businessStore)
                        {
                            var storeDetail = new StoreDetail
                            {
                                ProductID = inventory.ProductID,
                                BatchNo = inventory.BatchNo,
                                Amount = inventory.Amount,
                                CreateDate = DateTime.Now
                            };
                            if(inventory.ProduceDate.HasValue && inventory.ProduceDate.Value >= new DateTime(1900,1,1))
                            {
                                storeDetail.ProduceDate = inventory.ProduceDate;
                            }
                            if(inventory.ValidateDate.HasValue && inventory.ValidateDate.Value >= new DateTime(1900, 1, 1))
                            {
                                storeDetail.ValidateDate = inventory.ValidateDate;
                            }
                            db.StoreDetails.Add(storeDetail);
                            db.SaveChanges();

                            #region 记录业务库存新建历史

                            string sqlString = @"
INSERT INTO dbo.BUS_StoreDetailChangeHistory
(
    StoreDetailID,
    ProductID,
    BatchNo,
    ProduceDate,
    ValidateDate,
    Amount,
    CreateStoreID,
    CreateStoreCode,
    LastStoreID,
    LastStoreCode,
    LastCuringDate,
    CreateUserID,
    CreateDate,
    LastModifyUserID,
    LastModifyDate,
    DetailRemark,
    DepartmentID,
    NewProductID,
    NewBatchNo,
    NewProduceDate,
    NewValidateDate,
    NewAmount,
    NewLastCuringDate,
    NewDetailRemark,
    NewDepartmentID,
    VersionNumber,
    ActionName,
    ChangeUserName,
    ChangeDate
)
SELECT
    StoreDetailID,
    ProductID,
    BatchNo,
    ProduceDate,
    ValidateDate,
    Amount,
    CreateStoreID,
    CreateStoreCode,
    LastStoreID,
    LastStoreCode,
    LastCuringDate,
    CreateUserID,
    CreateDate,
    LastModifyUserID,
    LastModifyDate,
    DetailRemark,
    DepartmentID,
    ProductID,
    BatchNo,
    ProduceDate,
    ValidateDate,
    Amount,
    LastCuringDate,
    DetailRemark,
    DepartmentID,
    (SELECT ISNULL((SELECT TOP 1 ISNULL(VersionNumber, 0) FROM dbo.BUS_StoreDetailChangeHistory WHERE StoreDetailID={0} ORDER BY ChangeDate DESC),0)+1),
    '新建 - {2}',
    '{1}',
    GETDATE()
FROM dbo.BUS_StoreDetail
WHERE StoreDetailID={0}
";
                            string sql = string.Format(sqlString, storeDetail.StoreDetailID, changeUsername, action);
                            db.Database.ExecuteSqlCommand(sql);

                            #endregion
                        }
                        else
                        {
                            int oldAmount = businessStore.Amount.Value;

                            businessStore.Amount = inventory.Amount;
                            businessStore.LastModifyDate = DateTime.Now;
                            db.SaveChanges();

                            #region 记录业务库存修改历史

                            string sqlString = @"
INSERT INTO dbo.BUS_StoreDetailChangeHistory
(
    StoreDetailID,
    ProductID,
    BatchNo,
    ProduceDate,
    ValidateDate,
    Amount,
    CreateStoreID,
    CreateStoreCode,
    LastStoreID,
    LastStoreCode,
    LastCuringDate,
    CreateUserID,
    CreateDate,
    LastModifyUserID,
    LastModifyDate,
    DetailRemark,
    DepartmentID,
    NewProductID,
    NewBatchNo,
    NewProduceDate,
    NewValidateDate,
    NewAmount,
    NewLastCuringDate,
    NewDetailRemark,
    NewDepartmentID,
    VersionNumber,
    ActionName,
    ChangeUserName,
    ChangeDate
)
SELECT
    StoreDetailID,
    ProductID,
    BatchNo,
    ProduceDate,
    ValidateDate,
    '{2}',
    CreateStoreID,
    CreateStoreCode,
    LastStoreID,
    LastStoreCode,
    LastCuringDate,
    CreateUserID,
    CreateDate,
    LastModifyUserID,
    LastModifyDate,
    DetailRemark,
    DepartmentID,
    ProductID,
    BatchNo,
    ProduceDate,
    ValidateDate,
    '{3}',
    GETDATE(),
    DetailRemark,
    DepartmentID,
    (SELECT ISNULL((SELECT TOP 1 ISNULL(VersionNumber, 0) FROM dbo.BUS_StoreDetailChangeHistory WHERE StoreDetailID={0} ORDER BY ChangeDate DESC),0)+1),
    '修改 - {4}',
    '{1}',
    GETDATE()
FROM dbo.BUS_StoreDetail
WHERE StoreDetailID={0}
";
                            string sql = string.Format(sqlString, businessStore.StoreDetailID, changeUsername, oldAmount,
                                inventory.Amount, action);
                            db.Database.ExecuteSqlCommand(sql);

                            #endregion
                        }
                    }

                    foreach (var storeDetail in storeDetails)
                    {
                        var inventory =
                            inventories.FirstOrDefault(
                                p => p.ProductID == storeDetail.ProductID && p.BatchNo == storeDetail.BatchNo);
                        if (null == inventory)
                        {
                            //db.StoreDetails.Remove(storeDetail);
                            int oldAmount = storeDetail.Amount.Value;
                            storeDetail.Amount = 0;
                            db.SaveChanges();

                            #region 记录业务库存清空历史

                            string sqlString = @"
INSERT INTO dbo.BUS_StoreDetailChangeHistory
(
    StoreDetailID,
    ProductID,
    BatchNo,
    ProduceDate,
    ValidateDate,
    Amount,
    CreateStoreID,
    CreateStoreCode,
    LastStoreID,
    LastStoreCode,
    LastCuringDate,
    CreateUserID,
    CreateDate,
    LastModifyUserID,
    LastModifyDate,
    DetailRemark,
    DepartmentID,
    NewProductID,
    NewBatchNo,
    NewProduceDate,
    NewValidateDate,
    NewAmount,
    NewLastCuringDate,
    NewDetailRemark,
    NewDepartmentID,
    VersionNumber,
    ActionName,
    ChangeUserName,
    ChangeDate
)
SELECT
    StoreDetailID,
    ProductID,
    BatchNo,
    ProduceDate,
    ValidateDate,
    '{2}',
    CreateStoreID,
    CreateStoreCode,
    LastStoreID,
    LastStoreCode,
    LastCuringDate,
    CreateUserID,
    CreateDate,
    LastModifyUserID,
    LastModifyDate,
    DetailRemark,
    DepartmentID,
    ProductID,
    BatchNo,
    ProduceDate,
    ValidateDate,
    0,
    GETDATE(),
    DetailRemark,
    DepartmentID,
    (SELECT ISNULL((SELECT TOP 1 ISNULL(VersionNumber, 0) FROM dbo.BUS_StoreDetailChangeHistory WHERE StoreDetailID={0} ORDER BY ChangeDate DESC),0)+1),
    '修改 - {3}',
    '{1}',
    GETDATE()
FROM dbo.BUS_StoreDetail
WHERE StoreDetailID={0}
";
                            string sql = string.Format(sqlString, storeDetail.StoreDetailID, changeUsername, oldAmount, action);
                            db.Database.ExecuteSqlCommand(sql);

                            #endregion
                        }
                    }
                    //db.SaveChanges();

                    return GenerateUnqualifiedBusinessInventory(changeUsername, action);
                }
            }
            catch (Exception)
            {
                return false;
            }
        }

        public void UpdateCargoStoreAmountAndBusinessAmount(int inventoryStatisticId, bool updateBusinessInventory, string changeUsername)
        {
            List<AmountChange> amountChanges = new List<AmountChange>();
            using (var db = new WMSContext())
            {
                List<InventoryStatisticDetail> details =
                    db.InventoryStatisticDetails.Where(p => p.InventoryStatisticID == inventoryStatisticId).ToList();

                var cargoSpaceStoreDetails = (from isd in db.InventoryStatisticDetails
                    join csd in db.CargoSpaceStoreDetails on isd.StructureID equals csd.StructureID
                    where isd.InventoryStatisticID == inventoryStatisticId
                    select csd).ToList();
                foreach (var cargoSpaceStoreDetail in cargoSpaceStoreDetails)
                {
                    var detail =
                        details.FirstOrDefault(
                            p => p.CargoSpaceStoreDetailID == cargoSpaceStoreDetail.CargoSpaceStoreDetailID);
                    if (null != detail)
                    {
                        amountChanges.Add(new AmountChange{
                            CargoSpaceStoreDetailID = detail.CargoSpaceStoreDetailID.Value,
                            OldAmount = cargoSpaceStoreDetail.ProductAmount.Value,
                            NewAmount = detail.VerifiedProductAmount.Value
                        });
                        cargoSpaceStoreDetail.ProductAmount = detail.VerifiedProductAmount;
                    }
                }
                #region 记录WMS库存修改历史

                foreach (var amountChange in amountChanges)
                {
                    string sqlString = @"
INSERT INTO dbo.WMS_CargoSpaceStoreDetailChangeHistory
(
    CargoSpaceStoreDetailID,
    StoreCode,
    StructureID,
    ProductID,
    ProductBatchNumber,
    ProductionDate,
    ProductValidDate,
    ProductAmount,
    Manufacturer,
    DosageForm,
    PackagingSpecification,
    NewStoreCode,
    NewStructureID,
    NewProductID,
    NewProductBatchNumber,
    NewProductionDate,
    NewProductValidDate,
    NewProductAmount,
    NewManufacturer,
    NewDosageForm,
    NewPackagingSpecification,
    VersionNumber,
    ActionName,
    ChangeUserName,
    ChangeDate
)
SELECT
    CargoSpaceStoreDetailID,
    StoreCode,
    StructureID,
    ProductID,
    ProductBatchNumber,
    ProductionDate,
    ProductValidDate,
    '{2}',
    Manufacturer,
    DosageForm,
    PackagingSpecification,
    StoreCode,
    StructureID,
    ProductID,
    ProductBatchNumber,
    ProductionDate,
    ProductValidDate,
    '{3}',
    Manufacturer,
    DosageForm,
    PackagingSpecification,
    (SELECT ISNULL((SELECT TOP 1 ISNULL(VersionNumber, 0) FROM dbo.WMS_CargoSpaceStoreDetailChangeHistory WHERE CargoSpaceStoreDetailID={0} ORDER BY ChangeDate DESC),0)+1),
    '修改 - WMS库存盘点',
    '{1}',
    GETDATE()
FROM dbo.WMS_CargoSpaceStoreDetail
WHERE CargoSpaceStoreDetailID={0}
";
                    string sql = string.Format(sqlString,
                        amountChange.CargoSpaceStoreDetailID,
                        changeUsername,
                        amountChange.OldAmount,
                        amountChange.NewAmount);
                    db.Database.ExecuteSqlCommand(sql);
                }

                #endregion

                if (updateBusinessInventory)
                {
                    GenerateBusinessInventory(changeUsername);
                }

                var statistics = db.InventoryStatistics.Find(inventoryStatisticId);
                if (null != statistics)
                {
                    statistics.StatusID = 4;
                    statistics.StatusName = "已处理";
                    db.SaveChanges();
                }
            }
        }

        public void CompleteTaskManually(int inventoryStatisticId)
        {
            using (var db = new WMSContext())
            {
                string tempSql = @"UPDATE WMS_InventoryStatisticDetail SET VerifiedProductAmount=ISNULL(ProductAmount,0),StatusID=3,StatusName='完成盘点',VerifiedDate=GETDATE() WHERE InventoryStatisticID={0} AND StatusID < 3
UPDATE dbo.WMS_InventoryStatistic SET StatusID=3,StatusName='完成盘点' WHERE InventoryStatisticID={0}
";
                string sql = string.Format(tempSql,inventoryStatisticId);
                db.Database.ExecuteSqlCommand(sql);
            }
        }

        public bool GenerateUnqualifiedBusinessInventory(string changeUsername, string action)
        {
            try
            {
                using (var db = new WMSContext())
                {
                    var data = from s in db.CargoSpaceStoreDetails
                        join ss in db.StorageStructures on s.StructureID equals ss.StructureID
                        where ss.AreaType.Contains("不合格")
                        select new
                        {
                            s.CargoSpaceStoreDetailID,
                            s.ProductID,
                            s.ProductBatchNumber,
                            s.ProductionDate,
                            s.ProductValidDate,
                            s.ProductAmount,
                            ss.AreaType
                        };
                    var inventories = (from s in data
                        group s by new {s.ProductID, s.ProductBatchNumber}
                        into g
                        select new
                        {
                            ProductID = g.Key.ProductID.Value,
                            BatchNo = g.Key.ProductBatchNumber,
                            ProduceDate = g.FirstOrDefault().ProductionDate,
                            ValidateDate = g.FirstOrDefault().ProductValidDate,
                            Amount = g.Sum(p => p.ProductAmount)
                        }).ToList();
                    var storeDetails = db.UnqualifiedStoreDetails.ToList();
                    foreach (var inventory in inventories)
                    {
                        var businessStore =
                            storeDetails.FirstOrDefault(
                                p => p.ProductID == inventory.ProductID && p.BatchNo == inventory.BatchNo);
                        if (null == businessStore)
                        {
                            var unqualifiedStoreDetail = new UnqualifiedStoreDetail
                            {
                                ProductID = inventory.ProductID,
                                BatchNo = inventory.BatchNo,
                                Amount = inventory.Amount,
                                ProduceDate = inventory.ProduceDate,
                                ValidateDate = inventory.ValidateDate,
                                CreateDate = DateTime.Now
                            };
                            db.UnqualifiedStoreDetails.Add(unqualifiedStoreDetail);
                            db.SaveChanges();

                            #region 记录业务库存新建历史

                            string sqlString = @"
INSERT INTO dbo.BUS_UnqualifiedStoreDetailChangeHistory
(
    StoreDetailID,
    ProductID,
    BatchNo,
    ProduceDate,
    ValidateDate,
    Amount,
    CreateStoreID,
    CreateStoreCode,
    LastStoreID,
    LastStoreCode,
    LastCuringDate,
    CreateUserID,
    CreateDate,
    LastModifyUserID,
    LastModifyDate,
    DetailRemark,
    NewProductID,
    NewBatchNo,
    NewProduceDate,
    NewValidateDate,
    NewAmount,
    NewLastCuringDate,
    NewDetailRemark,
    VersionNumber,
    ActionName,
    ChangeUserName,
    ChangeDate
)
SELECT
    StoreDetailID,
    ProductID,
    BatchNo,
    ProduceDate,
    ValidateDate,
    Amount,
    CreateStoreID,
    CreateStoreCode,
    LastStoreID,
    LastStoreCode,
    LastCuringDate,
    CreateUserID,
    CreateDate,
    LastModifyUserID,
    LastModifyDate,
    DetailRemark,
    ProductID,
    BatchNo,
    ProduceDate,
    ValidateDate,
    Amount,
    LastCuringDate,
    DetailRemark,
    (SELECT ISNULL((SELECT TOP 1 ISNULL(VersionNumber, 0) FROM dbo.BUS_UnqualifiedStoreDetailChangeHistory WHERE StoreDetailID={0} ORDER BY ChangeDate DESC),0)+1),
    '新建 - {2}',
    '{1}',
    GETDATE()
FROM dbo.BUS_UnqualifiedStoreDetail
WHERE StoreDetailID={0}
";
                            string sql = string.Format(sqlString, unqualifiedStoreDetail.StoreDetailID, changeUsername, action);
                            db.Database.ExecuteSqlCommand(sql);

                            #endregion
                        }
                        else
                        {
                            int oldAmount = businessStore.Amount.Value;
                            businessStore.Amount = inventory.Amount;
                            businessStore.LastModifyDate = DateTime.Now;
                            db.SaveChanges();

                            #region 记录业务库存修改历史

                            string sqlString = @"
INSERT INTO dbo.BUS_UnqualifiedStoreDetailChangeHistory
(
    StoreDetailID,
    ProductID,
    BatchNo,
    ProduceDate,
    ValidateDate,
    Amount,
    CreateStoreID,
    CreateStoreCode,
    LastStoreID,
    LastStoreCode,
    LastCuringDate,
    CreateUserID,
    CreateDate,
    LastModifyUserID,
    LastModifyDate,
    DetailRemark,
    NewProductID,
    NewBatchNo,
    NewProduceDate,
    NewValidateDate,
    NewAmount,
    NewLastCuringDate,
    NewDetailRemark,
    VersionNumber,
    ActionName,
    ChangeUserName,
    ChangeDate
)
SELECT
    StoreDetailID,
    ProductID,
    BatchNo,
    ProduceDate,
    ValidateDate,
    '{2}',
    CreateStoreID,
    CreateStoreCode,
    LastStoreID,
    LastStoreCode,
    LastCuringDate,
    CreateUserID,
    CreateDate,
    LastModifyUserID,
    LastModifyDate,
    DetailRemark,
    ProductID,
    BatchNo,
    ProduceDate,
    ValidateDate,
    '{3}',
    LastCuringDate,
    DetailRemark,
    (SELECT ISNULL((SELECT TOP 1 ISNULL(VersionNumber, 0) FROM dbo.BUS_UnqualifiedStoreDetailChangeHistory WHERE StoreDetailID={0} ORDER BY ChangeDate DESC),0)+1),
    '修改 - {4}',
    '{1}',
    GETDATE()
FROM dbo.BUS_UnqualifiedStoreDetail
WHERE StoreDetailID={0}
";
                            string sql = string.Format(sqlString, businessStore.StoreDetailID, 
                                changeUsername,
                                oldAmount,
                                inventory.Amount,
                                action);
                            db.Database.ExecuteSqlCommand(sql);

                            #endregion
                        }
                    }

                    foreach (var storeDetail in storeDetails)
                    {
                        var inventory =
                            inventories.FirstOrDefault(
                                p => p.ProductID == storeDetail.ProductID && p.BatchNo == storeDetail.BatchNo);
                        if (null == inventory)
                        {
                            //db.StoreDetails.Remove(storeDetail);
                            int oldAmount = storeDetail.Amount.Value;
                            storeDetail.Amount = 0;
                            db.SaveChanges();
                            #region 记录业务库存清空历史

                            string sqlString = @"
INSERT INTO dbo.BUS_UnqualifiedStoreDetailChangeHistory
(
    StoreDetailID,
    ProductID,
    BatchNo,
    ProduceDate,
    ValidateDate,
    Amount,
    CreateStoreID,
    CreateStoreCode,
    LastStoreID,
    LastStoreCode,
    LastCuringDate,
    CreateUserID,
    CreateDate,
    LastModifyUserID,
    LastModifyDate,
    DetailRemark,
    NewProductID,
    NewBatchNo,
    NewProduceDate,
    NewValidateDate,
    NewAmount,
    NewLastCuringDate,
    NewDetailRemark,
    VersionNumber,
    ActionName,
    ChangeUserName,
    ChangeDate
)
SELECT
    StoreDetailID,
    ProductID,
    BatchNo,
    ProduceDate,
    ValidateDate,
    '{2}',
    CreateStoreID,
    CreateStoreCode,
    LastStoreID,
    LastStoreCode,
    LastCuringDate,
    CreateUserID,
    CreateDate,
    LastModifyUserID,
    LastModifyDate,
    DetailRemark,
    ProductID,
    BatchNo,
    ProduceDate,
    ValidateDate,
    0,
    LastCuringDate,
    DetailRemark,
    (SELECT ISNULL((SELECT TOP 1 ISNULL(VersionNumber, 0) FROM dbo.BUS_UnqualifiedStoreDetailChangeHistory WHERE StoreDetailID={0} ORDER BY ChangeDate DESC),0)+1),
    '修改 - {3}',
    '{1}',
    GETDATE()
FROM dbo.BUS_UnqualifiedStoreDetail
WHERE StoreDetailID={0}
";
                            string sql = string.Format(sqlString, storeDetail.StoreDetailID,
                                changeUsername,
                                oldAmount,
                                action);
                            db.Database.ExecuteSqlCommand(sql);

                            #endregion
                        }
                    }
                    if (!inventories.Any())
                    {
                        return true;
                    }
                }
            }
            catch (Exception ex)
            {
                return false;
            }

            return false;

        }
    }

    public class AmountChange
    {
        public int CargoSpaceStoreDetailID { get; set; }
        public int OldAmount { get; set; }
        public int NewAmount { get; set; }
    }
}
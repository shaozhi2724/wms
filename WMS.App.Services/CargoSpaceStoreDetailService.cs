using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using WMS.Model;

namespace WMS.App.Services
{
    public class CargoSpaceStoreDetailService : ICargoSpaceStoreDetailService
    {
        public List<CargoSpaceStoreDetail> GetAllCargoSpaceStoreDetails()
        {
            using (var db = new WMSContext())
            {
                return db.CargoSpaceStoreDetails.ToList();
            }
        }

        public List<CargoSpaceStoreDetail> SearchCargoSpaceStoreDetails()
        {
            using (var db = new WMSContext())
            {
                return db.CargoSpaceStoreDetails.ToList();
            }
        }

        public CargoSpaceStoreDetail SaveCargoSpaceStoreDetail(CargoSpaceStoreDetail entity)
        {
            using (var db = new WMSContext())
            {
                var trackedEntity = db.CargoSpaceStoreDetails.Find(entity.ProductID);
                if (trackedEntity != null)
                {
                    db.Entry(trackedEntity).CurrentValues.SetValues(entity);
                }
                else
                {
                    db.CargoSpaceStoreDetails.Add(entity);
                }
                db.SaveChanges();
                return entity;
            }
        }

        public bool DeleteCargoSpaceStoreDetail(int entityId)
        {
            using (var db = new WMSContext())
            {
                var trackedEntity = db.CargoSpaceStoreDetails.Find(entityId);
                if (trackedEntity != null)
                {
                    db.Entry(trackedEntity).State = EntityState.Deleted;
                    var rowEffected = db.SaveChanges();
                    return rowEffected > 0;
                }
                return false;
            }
        }

        public bool UpdateBatchNo(int detailId, string oldBatchNo, string newBatchNo)
        {
            using (var db = new WMSContext())
            {
                var trackedEntity = db.CargoSpaceStoreDetails.Find(detailId);
                if (trackedEntity != null)
                {
                    trackedEntity.ProductBatchNumber = newBatchNo;
                    var rowEffected = db.SaveChanges();
                    return rowEffected > 0;
                }
                return false;
            }
        }

        public bool UpdateBatchNo(int detailId, string oldBatchNo, string newBatchNo, DateTime productionDate, DateTime validDate)
        {
            using (var db = new WMSContext())
            {
                var trackedEntity = db.CargoSpaceStoreDetails.Find(detailId);
                if (trackedEntity != null)
                {
                    trackedEntity.ProductBatchNumber = newBatchNo;
                    trackedEntity.ProductionDate = productionDate;
                    trackedEntity.ProductValidDate = validDate;
                    var rowEffected = db.SaveChanges();
                    return rowEffected > 0;
                }
                return false;
            }
        }

        public int GetStructureID(string structureCode)
        {
            using (var db = new WMSContext())
            {
                var structure = db.StorageStructures.FirstOrDefault(p => p.StructureCode == structureCode);
                if (null == structure)
                {
                    return 0;
                }
                var wmsStore = db.CargoSpaceStoreDetails.FirstOrDefault(p => p.StructureID == structure.StructureID);
                if (null != wmsStore)
                {
                    return 1;
                }
                return structure.StructureID;
            }
        }
        public bool SaveStoreDetail(int structureID, int productID, string productBatchNumber, DateTime productionDate, DateTime productValidDate, int productAmount, string manufacturer, string dosageForm, string packagingSpecification)
        {
            using (var db = new WMSContext())
            {
                CargoSpaceStoreDetail storedetail = new CargoSpaceStoreDetail();
                //StructureID,ProductID,ProductBatchNumber,ProductionDate,ProductValidDate,
                //ProductAmount,Manufacturer,DosageForm,PackagingSpecification
                storedetail.StructureID = structureID;
                storedetail.ProductID = productID;
                storedetail.ProductBatchNumber = productBatchNumber;
                storedetail.ProductionDate = productionDate;
                storedetail.ProductValidDate = productValidDate;
                storedetail.ProductAmount = productAmount;
                storedetail.Manufacturer = manufacturer;
                storedetail.DosageForm = dosageForm;
                storedetail.PackagingSpecification = packagingSpecification;
                db.CargoSpaceStoreDetails.Add(storedetail);
                var bo = db.SaveChanges();
                return bo > 0;
            }
        }

        public bool UpdateBatchNoAndAmount(int detailId, string oldBatchNo, string newBatchNo, int oldAmount, int newAmount,
            DateTime productionDate, DateTime validDate, string changeUsername)
        {
            using (var db = new WMSContext())
            {
                var trackedEntity = db.CargoSpaceStoreDetails.Find(detailId);

                if (trackedEntity != null)
                {
                    #region 记录库存修改历史

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
    ProductAmount,
    Manufacturer,
    DosageForm,
    PackagingSpecification,
    StoreCode,
    StructureID,
    ProductID,
    '{2}',
    '{3}',
    '{4}',
    '{5}',
    Manufacturer,
    DosageForm,
    PackagingSpecification,
    (SELECT ISNULL((SELECT TOP 1 ISNULL(VersionNumber, 0) FROM dbo.WMS_CargoSpaceStoreDetailChangeHistory WHERE CargoSpaceStoreDetailID={0} ORDER BY ChangeDate DESC),0)+1),
    '修改 - WMS库存管理',
    '{1}',
    GETDATE()
FROM dbo.WMS_CargoSpaceStoreDetail
WHERE CargoSpaceStoreDetailID={0}
";
                    string sql = string.Format(sqlString,
                        detailId,
                        changeUsername,
                        newBatchNo,
                        productionDate.ToString("yyyy-MM-dd"),
                        validDate.ToString("yyyy-MM-dd"),
                        newAmount);
                    db.Database.ExecuteSqlCommand(sql);

                    #endregion

                    trackedEntity.ProductAmount = newAmount;
                    trackedEntity.ProductBatchNumber = newBatchNo;
                    trackedEntity.ProductionDate = productionDate;
                    trackedEntity.ProductValidDate = validDate;
                    var rowEffected = db.SaveChanges();

                    return rowEffected > 0;
                }
                return false;
            }
        }

        public void CleanStore()
        {
            using (var db = new WMSContext())
            {
                var storeDetails = db.CargoSpaceStoreDetails.Where(p => p.ProductAmount <= 0);
                foreach (var cargoSpaceStoreDetail in storeDetails)
                {
                    db.CargoSpaceStoreDetails.Remove(cargoSpaceStoreDetail);
                }
                db.SaveChanges();
            }
        }
    }
}
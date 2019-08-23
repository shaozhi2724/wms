using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace WMS.App.Services
{
    [Serializable]
    public class StoreBillDetailViewModel
    {
        public int DetailID { get; set; }
        public int StoreID { get; set; }
        public string StoreCode { get; set; }
        public int ProductID { get; set; }
        public string ProductCode { get; set; }
        public string ProductName { get; set; }
        public string ProducerName { get; set; }
        public string BatchNo { get; set; }
        public Nullable<System.DateTime> ProduceDate { get; set; }
        public Nullable<System.DateTime> ValidateDate { get; set; }
        public string StatusID { get; set; }
        public string StatusName { get; set; }
        public int? Amount { get; set; }
        public string DetailRemark { get; set; }
        public string ProduceDateString { get; set; }
        public string ValidateDateString { get; set; }

        public string PackagingProportionString { get; set; }
        public int PackagingProportion { get; set; }

        public string StructureCode { get; set; }
        public int? ControlType { get; set; }
        public string ControlTypeString { get; set; }
        public string StoreEnvironment { get; set; }
        public string StructureName { get; set; }
        public long? PackagingAmount { get; set; }

        public string ProductSpec { get; set; }
        public string PackageSpec { get; set; }
        public string ProductSpell { get; set; }
    }
    public class StoreInBillDetailViewModel
    {
        public int DetailID { get; set; }
        public int StoreID { get; set; }
        public int ProductID { get; set; }
        public string ProductCode { get; set; }
        public string ProductName { get; set; }
        public string ProducerName { get; set; }
        public string BatchNo { get; set; }
        public Nullable<System.DateTime> ProduceDate { get; set; }
        public Nullable<System.DateTime> ValidateDate { get; set; }
        public string StatusID { get; set; }
        public string StatusName { get; set; }
        public int? Amount { get; set; }
        public string DetailRemark { get; set; }
        public string ProduceDateString { get; set; }
        public string ValidateDateString { get; set; }

        public string PackagingProportionString { get; set; }
        public int PackagingProportion { get; set; }

        public string StructureCode { get; set; }
        public int? ControlType { get; set; }
        public string ControlTypeString { get; set; }
        public string StoreEnvironment { get; set; }
        public string StructureName { get; set; }
        public long? PackagingAmount { get; set; }

        public string ProductSpec { get; set; }
        public string PackageSpec { get; set; }
        public int EntireCargoSpaceMaximum { get; set; }
        public int ScatteredCargoSpaceMaximum { get; set; }
        public string AreaType { get; set; }
        public int StructureID { get; set; }
        public string DosageForm { get; set; }
    }

    public class OutDetail : StoreBillDetailViewModel
    {
        public int WarehouseID { get; set; }
        public string WarehouseName { get; set; }
        public int StoreAmount { get; set; }
        public int StoreOutAmount { get; set; }
        public string AreaType { get; set; }
        public int StructureID { get; set; }
        public int SortOrder { get; set; }
        public string Description { get; set; }
    }

    public class OutStructureDetail
    {
        public int ProductID { get; set; }
        public string BatchNo { get; set; }
        public int StructureID { get; set; }
        public string AreaType { get; set; }
        public int StoreAmount { get; set; }
        public int PackagingProportion { get; set; }
        public int SortOrder { get; set; }
    }
    public class InDetail : StoreBillDetailViewModel
    {
        public int StoreAmount { get; set; }
        public int StoreInAmount { get; set; }
        public string AreaType { get; set; }
        public int StructureID { get; set; }
        public int SortOrder { get; set; }
        public string Description { get; set; }
    }

    public class InStructureDetail
    {
        public int? ProductID { get; set; }
        public string ProductName { get; set; }
        public string ProductBatchNumber { get; set; }
        public int StructureID { get; set; }
        public string StructureCode { get; set; }
        public string StructureName { get; set; }
        public string WarehouseType { get; set; }
        public string AreaType { get; set; }
        public int? ProductAmount { get; set; }
        public int PackagingProportion { get; set; }
        public int SortOrder { get; set; }
    }
    public class ProductStructureCompare : IEquatable<ProductStructureCompare>
    {
        public int ProductID
        {
            get;
            set;
        }
        public string BatchNo
        {
            get;
            set;
        }

        public override int GetHashCode()
        {
            return (this.ProductID.ToString() + this.BatchNo).GetHashCode();
        }
        public bool Equals(ProductStructureCompare obj)
        {
            return obj != null && obj.ProductID == this.ProductID && obj.BatchNo == this.BatchNo;
        }
    }

    public class ProductComparer
    {
        public int ProductID
        {
            get;
            set;
        }
        public string BatchNo
        {
            get;
            set;
        }
    }
    public class ProductEquality : IEqualityComparer<ProductComparer>
    {
        public bool Equals(ProductComparer x, ProductComparer y)
        {
            return x.ProductID == y.ProductID && x.BatchNo == y.BatchNo;
        }

        public int GetHashCode(ProductComparer obj)
        {
            if(obj == null)
            {
                return 0;
            }
            else
            {
                return obj.ToString().GetHashCode();
            }
        }
    }
}

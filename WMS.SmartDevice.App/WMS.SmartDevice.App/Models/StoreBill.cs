using System;

namespace WMS.SmartDevice.App.Models
{
    public partial class StoreBill
    {
        public int StoreID { get; set; }
        public string StoreCode { get; set; }
        public Nullable<System.DateTime> StoreDate { get; set; }
        public Nullable<bool> IsBillIn { get; set; }
        public Nullable<int> StoreTypeID { get; set; }
        public string StoreTypeName { get; set; }
        public string StoreTypeSpell { get; set; }
        public Nullable<int> DealerID { get; set; }
        public string DealerName { get; set; }
        public string DealerSpell { get; set; }
        public string StoreKeeper { get; set; }
        public string StoreKeeperSpell { get; set; }
        public Nullable<int> PurchaseBillID { get; set; }
        public string PurchaseBillCode { get; set; }
        public Nullable<int> ReceiveID { get; set; }
        public string ReceiveCode { get; set; }
        public Nullable<int> AcceptID { get; set; }
        public string AcceptCode { get; set; }
        public Nullable<int> SaleBillID { get; set; }
        public string SaleBillCode { get; set; }
        public Nullable<int> ReviewID { get; set; }
        public string ReviewCode { get; set; }
        public Nullable<System.Guid> CreateUserID { get; set; }
        public Nullable<System.DateTime> CreateDate { get; set; }
        public Nullable<System.Guid> LastModifyUserID { get; set; }
        public Nullable<System.DateTime> LastModifyDate { get; set; }
        public string StoreRemark { get; set; }
        public string StoreStatusID { get; set; }
        public string StoreStatusName { get; set; }
        public string Reservation3 { get; set; }
        public string Reservation4 { get; set; }
        public string Reservation5 { get; set; }
        public string Reservation6 { get; set; }
        public string Reservation7 { get; set; }
        public string Reservation8 { get; set; }
        public string Reservation9 { get; set; }
        public string Reservation10 { get; set; }
    }
}
﻿using System;

namespace WMS.SmartDevice.App.Models
{
    public class StoreInDetailViewModel
    {
        public int DetailID { get; set; }

        public int StoreID { get; set; }

        public string StoreCode { get; set; }

        public int ProductID { get; set; }

        public string ProductName { get; set; }

        public string ProductSpec { get; set; }

        public string PackageSpec { get; set; }

        public string BatchNo { get; set; }

        public int? Amount { get; set; }
        public string PhysicType { get; set; }
        public string ProducerName { get; set; }
        public string PackagingProportion { get; set; }
        public DateTime? ProduceDate { get; set; }
        public DateTime? ValidateDate { get; set; }
        public string StockCondition { get; set; }
        public string AreaType { get; set; }

        public string StructureCode { get; set; }
        public string StructureName { get; set; }

        public string StatusName { get; set; }
    }
}
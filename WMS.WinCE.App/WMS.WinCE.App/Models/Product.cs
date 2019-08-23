using System;

namespace WMS.WinCE.App.Models
{
    public class Product
    {
        public int ProductID { get; set; }
        public string ProductCode { get; set; }
        public string ProductName { get; set; }
        public string ProductSpell { get; set; }
        public string CommonName { get; set; }
        public string TradeName { get; set; }
        public string EnglishName { get; set; }
        public string ChinesePinyin { get; set; }
        public string ProductBarCode { get; set; }
        public string ProductSpec { get; set; }
        public string ProductUnit { get; set; }
        public string PackageSpec { get; set; }
        public Nullable<int> PhysicTypeID { get; set; }
        public string PhysicType { get; set; }
        public Nullable<int> ProductStyleID { get; set; }
        public string ProductStyle { get; set; }
        public string AuthorizedNo { get; set; }
        public string ProducerName { get; set; }
        public string ProducerSpell { get; set; }
        public string ProductionAddress { get; set; }
        public string ProductionPostalCode { get; set; }
        public string ProductionPhone { get; set; }
        public string ProductionFaxNo { get; set; }
        public string ContactPerson { get; set; }
        public string ContactPersonSpell { get; set; }
        public string ContactPhone { get; set; }
        public Nullable<bool> IsSupervise { get; set; }
        public string SuperviseSignBar { get; set; }
        public Nullable<int> StockMinAmount { get; set; }
        public Nullable<int> BatchPreWarningDays { get; set; }
        public string AcceptAgingTime { get; set; }
        public string TreatmentFor { get; set; }
        public string UsageDosage { get; set; }
        public string AdverseReaction { get; set; }
        public string Contraindication { get; set; }
        public string MatterAttention { get; set; }
        public string StockCondition { get; set; }
        public Nullable<bool> IsUseToPregnant { get; set; }
        public Nullable<bool> IsUseToChildren { get; set; }
        public Nullable<bool> IsUseToOldPeople { get; set; }
        public string Ingredient { get; set; }
        public string Character { get; set; }
        public string DrugInteraction { get; set; }
        public string Overdose { get; set; }
        public string ClinicalTrial { get; set; }
        public string Pharmacology { get; set; }
        public string Pharmacokinetics { get; set; }
        public string PerformanceStandard { get; set; }
        public string RegisterNo { get; set; }
        public string InstructionContent { get; set; }
        public Nullable<System.DateTime> InstructionDate { get; set; }
        public string PackagingProportion { get; set; }
        public Nullable<int> EntireCargoSpaceMaximum { get; set; }
        public Nullable<int> ScatteredCargoSpaceMaximum { get; set; }
        public Nullable<int> ScatteredCargoSpaceMinimum { get; set; }
        public Nullable<System.DateTime> CreateDate { get; set; }
        public Nullable<System.DateTime> LastModifyDate { get; set; }
        public Nullable<int> BusinessStatus { get; set; }
        public string BatchNo { get; set; }
        public Nullable<DateTime> ProduceDate { get; set; }
        public Nullable<DateTime> ValidateDate { get; set; }
    }
}
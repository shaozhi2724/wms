
//------------------------------------------------------------------------------
// <auto-generated>
//    此代码是根据模板生成的。
//
//    手动更改此文件可能会导致应用程序中发生异常行为。
//    如果重新生成代码，则将覆盖对此文件的手动更改。
// </auto-generated>
//------------------------------------------------------------------------------


namespace WMS.Model
{

using System;
    using System.Collections.Generic;
    
public partial class StorageStructure
{

    public int StructureID { get; set; }

    public int WarehouseID { get; set; }

    public string StructureCode { get; set; }

    public string StructureName { get; set; }

    public string StructureSpell { get; set; }

    public string StructureType { get; set; }

    public string StructureLocation { get; set; }

    public string StructureLeader { get; set; }

    public string LeaderSpell { get; set; }

    public string LeaderPhone { get; set; }

    public string StructureSpace { get; set; }

    public string StructureVolume { get; set; }

    public Nullable<bool> IsMinStructure { get; set; }

    public string StructureBarCode { get; set; }

    public string ParentStructureCode { get; set; }

    public Nullable<System.Guid> CreateUserID { get; set; }

    public Nullable<System.DateTime> CreateDate { get; set; }

    public Nullable<System.Guid> LastModifyUserID { get; set; }

    public Nullable<System.DateTime> LastModifyDate { get; set; }

    public string StructureRemark { get; set; }

    public string Reservation1 { get; set; }

    public string Reservation2 { get; set; }

    public string Reservation3 { get; set; }

    public string Reservation4 { get; set; }

    public string Reservation5 { get; set; }

    public string Reservation6 { get; set; }

    public string Reservation7 { get; set; }

    public string Reservation8 { get; set; }

    public string Reservation9 { get; set; }

    public string Reservation10 { get; set; }

    public Nullable<int> StructureStyle { get; set; }

    public string AreaType { get; set; }

    public Nullable<bool> IsActive { get; set; }

}

}

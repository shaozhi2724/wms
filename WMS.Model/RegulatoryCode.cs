
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
    
public partial class RegulatoryCode
{

    public string Code { get; set; }

    public string CorpCode { get; set; }

    public string ReviewCode { get; set; }

    public int StatusID { get; set; }

    public string StatusName { get; set; }

    public Nullable<System.Guid> CreateUserID { get; set; }

    public System.DateTime CreateDate { get; set; }

    public Nullable<System.DateTime> RelationDate { get; set; }

    public Nullable<System.DateTime> ExportDate { get; set; }

}

}

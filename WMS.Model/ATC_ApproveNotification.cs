
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
    
public partial class ATC_ApproveNotification
{

    public int ApproveNotificationID { get; set; }

    public string ApproveCode { get; set; }

    public System.Guid OwnerUserID { get; set; }

    public string Message { get; set; }

    public System.Guid CreateUserID { get; set; }

    public string CreateUserName { get; set; }

    public Nullable<System.DateTime> CreateDate { get; set; }

    public bool IsRead { get; set; }

    public Nullable<System.DateTime> ReadTime { get; set; }

    public string FormClass { get; set; }

    public int TargetID { get; set; }

    public string TargetCode { get; set; }

}

}

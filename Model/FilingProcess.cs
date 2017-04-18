using System;
using System.Collections.Generic;
namespace My.Model
{   
    /// <summary>
    /// 实体-FilingProcess 
    /// </summary>
    public partial class FilingProcess    
    {    
        public Int64 SysNo { get; set; }
          public Int64? FilingSysNo { get; set; }
          public Int32? ProtectionTime { get; set; }
          public Int32? ProtectionType { get; set; }
          public Int32 FilingProcessStatus { get; set; }
          public Boolean IsDelete { get; set; }
          public DateTime? Time { get; set; }
          public String TimeRemarks { get; set; }
          public String CreateUserName { get; set; }
          public DateTime CreateDate { get; set; }
          public String ModifyUserName { get; set; }
          public DateTime? ModifyDate { get; set; }
          public Int32 Attribute11 { get; set; }
          public Int32 Attribute12 { get; set; }
          public Int32 Attribute13 { get; set; }
          public DateTime Attribute16 { get; set; }
          public String Attribute1 { get; set; }
          public String Attribute2 { get; set; }
          public String Attribute3 { get; set; }
          public String Attribute4 { get; set; }
          public String Attribute5 { get; set; }
          public String Attribute6 { get; set; }
          public String Attribute7 { get; set; }
          public String Attribute8 { get; set; }
          public String Attribute9 { get; set; }
          public String Attribute10 { get; set; }
          public DateTime Attribute17 { get; set; }
          public DateTime Attribute18 { get; set; }
          public DateTime Attribute19 { get; set; }
          public DateTime Attribute20 { get; set; }
          public Decimal? Attribute21 { get; set; }
          public Decimal? Attribute22 { get; set; }
          public Decimal? Attribute23 { get; set; }
          public Decimal? Attribute24 { get; set; }
          public Decimal? Attribute25 { get; set; }
          public Int64 Attribute14 { get; set; }
          public Int64 Attribute15 { get; set; }
          public Double Attribute26 { get; set; }
          public Double Attribute27 { get; set; }
          public String CreateUserSysNo { get; set; }
          public String ModifyUserSysNo { get; set; }
          public String InEmployeesSysNo { get; set; }
          public Int64 RelationSysNo { get; set; }
          public Int64 OrderParentNo { get; set; }
    } 
}

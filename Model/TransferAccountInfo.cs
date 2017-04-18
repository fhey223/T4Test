using System;
using System.Collections.Generic;
namespace My.Model
{   
    /// <summary>
    /// 实体-TransferAccountInfo 
    /// </summary>
    public partial class TransferAccountInfo    
    {    
        public Int64 SysNo { get; set; }
          public Int64 RelationNo { get; set; }
          public Int32? Type { get; set; }
          public String CreditNo { get; set; }
          public String DealType { get; set; }
          public String ValidateCode { get; set; }
          public String Individual1 { get; set; }
          public String IndividualName2 { get; set; }
          public String Individual2 { get; set; }
          public String Remark1 { get; set; }
          public String Remark2 { get; set; }
          public DateTime CreateDate { get; set; }
          public String CreateUserSysNo { get; set; }
          public String CreateUserName { get; set; }
          public Boolean IsDelete { get; set; }
    } 
}

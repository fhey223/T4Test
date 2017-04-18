using System;
using System.Collections.Generic;
namespace My.Model
{   
    /// <summary>
    /// 实体-Receivables 
    /// </summary>
    public partial class Receivables    
    {    
        public Int64 SysNo { get; set; }
          public String ReceivablesNo { get; set; }
          public Int64 BuildingNo { get; set; }
          public Int32 ReceivablesType { get; set; }
          public Decimal ReceivablesMoney { get; set; }
          public String ReceivablesInfo { get; set; }
          public Int32 ApprovalStatus { get; set; }
          public String ReceivablesFile { get; set; }
          public DateTime CreateDate { get; set; }
          public DateTime? ModifyDate { get; set; }
          public Boolean IsDelete { get; set; }
          public String CreateUserSysNo { get; set; }
          public String ModifyUserSysNo { get; set; }
    } 
}

using System;
using System.Collections.Generic;
namespace My.Model
{   
    /// <summary>
    /// 实体-Contract 
    /// </summary>
    public partial class Contract    
    {    
        public Int64 SysNo { get; set; }
          public String ContractNo { get; set; }
          public String UnitName { get; set; }
          public Int32 ContracType { get; set; }
          public String AccName { get; set; }
          public String AccBank { get; set; }
          public String AccBankNo { get; set; }
          public Int32 ApprovalStatus { get; set; }
          public DateTime? StarTime { get; set; }
          public DateTime? EndTime { get; set; }
          public Decimal? DevFeeRate { get; set; }
          public Decimal? ParFeeRate { get; set; }
          public DateTime CreateDate { get; set; }
          public DateTime? ModifyDate { get; set; }
          public Boolean IsDelete { get; set; }
          public String CreateUserSysNo { get; set; }
          public String ModifyUserSysNo { get; set; }
    } 
}

using System;
using System.Collections.Generic;
namespace My.Model
{   
    /// <summary>
    /// 实体-RefundApplyLog 
    /// </summary>
    public partial class RefundApplyLog    
    {    
        public Int64 SysNo { get; set; }
          public Int64 RefundNo { get; set; }
          public String ApplyReason { get; set; }
          public DateTime CreateDate { get; set; }
          public String CreateUserSysNo { get; set; }
          public String CreateUserName { get; set; }
          public DateTime? ModifyDate { get; set; }
          public String ModifyUserSysNo { get; set; }
          public String ModifyUserName { get; set; }
          public Boolean IsDelete { get; set; }
    } 
}

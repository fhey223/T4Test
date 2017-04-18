using System;
using System.Collections.Generic;
namespace My.Model
{   
    /// <summary>
    /// 实体-Refund 
    /// </summary>
    public partial class Refund    
    {    
        public Int64 RefundNo { get; set; }
          public Int64 RefundParentNo { get; set; }
          public Int64 OrderNo { get; set; }
          public Decimal Money { get; set; }
          public Int32 RefundStatus { get; set; }
          public DateTime? RefundTime { get; set; }
          public Int32 ReviewStatus { get; set; }
          public String BatchNo { get; set; }
          public DateTime CreateDate { get; set; }
          public String CreateUserSysNo { get; set; }
          public String CreateUserName { get; set; }
          public DateTime? ModifyDate { get; set; }
          public String ModifyUserSysNo { get; set; }
          public String ModifyUserName { get; set; }
          public Boolean IsDelete { get; set; }
          public DateTime? BatchDate { get; set; }
          public Int32 ReviewLevel { get; set; }
          public Boolean IsReapply { get; set; }
    } 
}

using System;
using System.Collections.Generic;
namespace My.Model
{   
    /// <summary>
    /// 实体-FinanceRuleLog 
    /// </summary>
    public partial class FinanceRuleLog    
    {    
        public Int64 LogId { get; set; }
          public Int64 FinanceRuleSysNo { get; set; }
          public String LogInfo { get; set; }
          public DateTime CreateDate { get; set; }
          public String CreateUserSysNo { get; set; }
          public String CreateUserName { get; set; }
          public DateTime? ModifyDate { get; set; }
          public String ModifyUserSysNo { get; set; }
          public String ModifyUserName { get; set; }
          public Boolean IsDelete { get; set; }
    } 
}

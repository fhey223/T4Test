using System;
using System.Collections.Generic;
namespace My.Model
{   
    /// <summary>
    /// 实体-ReasonCustomer 
    /// </summary>
    public partial class ReasonCustomer    
    {    
        public Int64 SysNo { get; set; }
          public String GiveUpReason { get; set; }
          public String FrontManSysNo { get; set; }
          public String CreateUserName { get; set; }
          public DateTime CreateDate { get; set; }
          public String ModifyUserName { get; set; }
          public DateTime? ModifyDate { get; set; }
          public String CreateUserSysNo { get; set; }
          public String ModifyUserSysNo { get; set; }
    } 
}

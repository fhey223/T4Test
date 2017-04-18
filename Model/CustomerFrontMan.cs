using System;
using System.Collections.Generic;
namespace My.Model
{   
    /// <summary>
    /// 实体-CustomerFrontMan 
    /// </summary>
    public partial class CustomerFrontMan    
    {    
        public Int64 SysNo { get; set; }
          public Int64 CustomerSysNo { get; set; }
          public String CreateUserName { get; set; }
          public DateTime CreateDate { get; set; }
          public String ModifyUserName { get; set; }
          public DateTime? ModifyDate { get; set; }
          public String CreateUserSysNo { get; set; }
          public String ModifyUserSysNo { get; set; }
          public String HistoryFrontManSysNo { get; set; }
    } 
}

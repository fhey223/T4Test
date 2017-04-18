using System;
using System.Collections.Generic;
namespace My.Model
{   
    /// <summary>
    /// 实体-BillLog 
    /// </summary>
    public partial class BillLog    
    {    
        public Int64 LogId { get; set; }
          public Int64 BillNo { get; set; }
          public String LogInfo { get; set; }
          public DateTime CreateDate { get; set; }
          public String CreateUserSysNo { get; set; }
          public String CreateUserName { get; set; }
          public DateTime? ModifyDate { get; set; }
          public String ModifyUserSysNo { get; set; }
          public String ModifyUserName { get; set; }
    } 
}

using System;
using System.Collections.Generic;
namespace My.Model
{   
    /// <summary>
    /// 实体-Duty 
    /// </summary>
    public partial class Duty    
    {    
        public Int64 SysNo { get; set; }
          public String DutyNo { get; set; }
          public String DutyName { get; set; }
          public Int64 CreateUserSysNo { get; set; }
          public DateTime CreateDate { get; set; }
          public Int64? ModifyUserSysNo { get; set; }
          public DateTime? ModifyDate { get; set; }
    } 
}

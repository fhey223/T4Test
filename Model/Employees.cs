using System;
using System.Collections.Generic;
namespace My.Model
{   
    /// <summary>
    /// 实体-Employees 
    /// </summary>
    public partial class Employees    
    {    
        public Int64 SysNo { get; set; }
          public String EmpNo { get; set; }
          public String EmpName { get; set; }
          public String Mobile { get; set; }
          public String EmailAddr { get; set; }
          public String Department { get; set; }
          public String Duty { get; set; }
          public Boolean IsResidentStatus { get; set; }
          public Int64 SuperiorNo { get; set; }
          public String CreateUserSysNo { get; set; }
          public DateTime CreateDate { get; set; }
          public String ModifyUserSysNo { get; set; }
          public DateTime? ModifyDate { get; set; }
          public Boolean IsDelete { get; set; }
          public Boolean IsSwitch { get; set; }
          public String DomainName { get; set; }
          public DateTime? LastLoginTime { get; set; }
          public DateTime? LockTime { get; set; }
          public Int32 ErrorCount { get; set; }
          public Boolean SystemLock { get; set; }
          public Boolean IsResignation { get; set; }
          public DateTime? ReleaseLockTime { get; set; }
          public Int64? ReleaseLockOperator { get; set; }
    } 
}

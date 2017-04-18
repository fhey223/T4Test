using System;
using System.Collections.Generic;
namespace My.Model
{   
    /// <summary>
    /// 实体-UserSecurity 
    /// </summary>
    public partial class UserSecurity    
    {    
        public Int64 SysNo { get; set; }
          public String StaffNo { get; set; }
          public Int32 ErrorCount { get; set; }
          public Boolean IsAuthorization { get; set; }
          public Boolean SystemLock { get; set; }
          public DateTime? LockTime { get; set; }
          public DateTime? ReleaseLockTime { get; set; }
          public String ReleaseLockOperator { get; set; }
          public DateTime? LastLoginTime { get; set; }
          public String LoginIP { get; set; }
          public DateTime CreateTime { get; set; }
          public String Remark { get; set; }
          public String Authorizer { get; set; }
    } 
}

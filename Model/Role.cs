using System;
using System.Collections.Generic;
namespace My.Model
{   
    /// <summary>
    /// 实体-Role 
    /// </summary>
    public partial class Role    
    {    
        public Int64 SysNo { get; set; }
          public String RoleName { get; set; }
          public Boolean IsResidentStatus { get; set; }
          public String Address { get; set; }
          public Int64? CreateUserSysNo { get; set; }
          public DateTime CreateDate { get; set; }
          public Int64? ModifyUserSysNo { get; set; }
          public DateTime? ModifyDate { get; set; }
          public Boolean IsDelete { get; set; }
          public String RoleNo { get; set; }
    } 
}

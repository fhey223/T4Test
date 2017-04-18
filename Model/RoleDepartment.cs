using System;
using System.Collections.Generic;
namespace My.Model
{   
    /// <summary>
    /// 实体-RoleDepartment 
    /// </summary>
    public partial class RoleDepartment    
    {    
        public String MD5 { get; set; }
          public Int64 RoleSysNo { get; set; }
          public String DepartmentNo { get; set; }
          public String CreateUserSysNo { get; set; }
          public DateTime? CreateDate { get; set; }
          public String ModifyUserSysNo { get; set; }
          public DateTime? ModifyDate { get; set; }
          public Int64 ParentSysNo { get; set; }
    } 
}

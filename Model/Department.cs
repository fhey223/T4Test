using System;
using System.Collections.Generic;
namespace My.Model
{   
    /// <summary>
    /// 实体-Department 
    /// </summary>
    public partial class Department    
    {    
        public Int64 SysNo { get; set; }
          public String DepartmentName { get; set; }
          public Int64? CreateUserSysNo { get; set; }
          public DateTime? CreateDate { get; set; }
          public Int64? ModifyUserSysNo { get; set; }
          public DateTime? ModifyDate { get; set; }
          public String DepartmentNo { get; set; }
          public Boolean IsDelete { get; set; }
          public Int64 ParentSysNo { get; set; }
    } 
}

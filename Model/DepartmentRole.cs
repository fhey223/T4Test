using System;
using System.Collections.Generic;
namespace My.Model
{   
    /// <summary>
    /// 实体-DepartmentRole 
    /// </summary>
    public partial class DepartmentRole    
    {    
        public String DepartmentNo { get; set; }
          public String RoleNo { get; set; }
          public DateTime CreateDate { get; set; }
          public DateTime? ModifyDate { get; set; }
          public String ParentRoleNo { get; set; }
          public Boolean IsReadyToDelete { get; set; }
          public Int32 SysNo { get; set; }
    } 
}

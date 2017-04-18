using System;
using System.Collections.Generic;
namespace My.Model
{   
    /// <summary>
    /// 实体-RoleStaff 
    /// </summary>
    public partial class RoleStaff    
    {    
        public Int32 SysNo { get; set; }
          public String RoleNo { get; set; }
          public String StaffNo { get; set; }
          public DateTime CreateDate { get; set; }
          public DateTime? ModifyDate { get; set; }
          public Boolean IsReadyToDelete { get; set; }
    } 
}

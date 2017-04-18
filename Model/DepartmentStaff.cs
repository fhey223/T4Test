using System;
using System.Collections.Generic;
namespace My.Model
{   
    /// <summary>
    /// 实体-DepartmentStaff 
    /// </summary>
    public partial class DepartmentStaff    
    {    
        public Int32 SysNo { get; set; }
          public String DepartmentNo { get; set; }
          public String StaffNo { get; set; }
          public DateTime CreateDate { get; set; }
          public DateTime? ModifyDate { get; set; }
          public Boolean IsReadyToDelete { get; set; }
    } 
}

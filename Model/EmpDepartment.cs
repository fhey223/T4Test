using System;
using System.Collections.Generic;
namespace My.Model
{   
    /// <summary>
    /// 实体-EmpDepartment 
    /// </summary>
    public partial class EmpDepartment    
    {    
        public String MD5 { get; set; }
          public Int64 EmpSysNo { get; set; }
          public String DepartmentNo { get; set; }
          public Int64? CreateUserSysNo { get; set; }
          public DateTime? CreateDate { get; set; }
          public Int64? ModifyUserSysNo { get; set; }
          public DateTime? ModifyDate { get; set; }
          public Boolean IsDelete { get; set; }
    } 
}

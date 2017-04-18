using System;
using System.Collections.Generic;
namespace My.Model
{   
    /// <summary>
    /// 实体-EmpRoleCase 
    /// </summary>
    public partial class EmpRoleCase    
    {    
        public String MD5 { get; set; }
          public Int64 EmpSysNo { get; set; }
          public Int64 RoleSysNo { get; set; }
          public Boolean IsResponsible { get; set; }
          public Int64? CreateUserSysNo { get; set; }
          public DateTime? CreateDate { get; set; }
          public Int64? ModifyUserSysNo { get; set; }
          public DateTime? ModifyDate { get; set; }
          public Boolean IsDelete { get; set; }
    } 
}

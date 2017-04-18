using System;
using System.Collections.Generic;
namespace My.Model
{   
    /// <summary>
    /// 实体-RoleStatus 
    /// </summary>
    public partial class RoleStatus    
    {    
        public Int64 SysNo { get; set; }
          public String RoleNo { get; set; }
          public Int32 RoleStatus { get; set; }
          public String CreateUserNo { get; set; }
          public DateTime CreateDate { get; set; }
          public String ModifyUserNo { get; set; }
          public DateTime? ModifyDate { get; set; }
          public Boolean IsDelete { get; set; }
    } 
}

using System;
using System.Collections.Generic;
namespace My.Model
{   
    /// <summary>
    /// 实体-RejectLog 
    /// </summary>
    public partial class RejectLog    
    {    
        public Int64 SysNo { get; set; }
          public Int32 Type { get; set; }
          public Int64 RelationNo { get; set; }
          public String Reason { get; set; }
          public DateTime CreateDate { get; set; }
          public String CreateUserSysNo { get; set; }
          public String CreateUserName { get; set; }
          public DateTime? ModifyDate { get; set; }
          public String ModifyUserSysNo { get; set; }
          public String ModifyUserName { get; set; }
          public Boolean IsDelete { get; set; }
    } 
}

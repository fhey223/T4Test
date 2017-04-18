using System;
using System.Collections.Generic;
namespace My.Model
{   
    /// <summary>
    /// 实体-NationalAddress 
    /// </summary>
    public partial class NationalAddress    
    {    
        public Int64 SysNo { get; set; }
          public String Key { get; set; }
          public String Value { get; set; }
          public Int64? ParentSysNo { get; set; }
          public DateTime CreateDate { get; set; }
          public String CreateUserName { get; set; }
          public DateTime? ModifyDate { get; set; }
          public String ModifyUserName { get; set; }
          public String CreateUserSysNo { get; set; }
          public String ModifyUserSysNo { get; set; }
    } 
}

using System;
using System.Collections.Generic;
namespace My.Model
{   
    /// <summary>
    /// 实体-Settings 
    /// </summary>
    public partial class Settings    
    {    
        public Int64 SysNo { get; set; }
          public String Key { get; set; }
          public String Value { get; set; }
          public Int64? ParentSysNo { get; set; }
          public DateTime CreateDate { get; set; }
          public String CreateUserSysNo { get; set; }
          public String CreateUserName { get; set; }
          public DateTime? ModifyDate { get; set; }
          public String ModifyUserSysNo { get; set; }
          public String ModifyUserName { get; set; }
          public Int32? Sort { get; set; }
    } 
}

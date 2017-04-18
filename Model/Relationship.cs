using System;
using System.Collections.Generic;
namespace My.Model
{   
    /// <summary>
    /// 实体-Relationship 
    /// </summary>
    public partial class Relationship    
    {    
        public Int64 SysNo { get; set; }
          public Int64 Key { get; set; }
          public String Value { get; set; }
          public Int32 Type { get; set; }
          public Int64? ParentKey { get; set; }
          public DateTime? CreateDate { get; set; }
          public DateTime? ModifyDate { get; set; }
          public Boolean IsDelete { get; set; }
          public String CreateUserSysNo { get; set; }
          public String ModifyUserSysNo { get; set; }
    } 
}

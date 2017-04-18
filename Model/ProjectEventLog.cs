using System;
using System.Collections.Generic;
namespace My.Model
{   
    /// <summary>
    /// 实体-ProjectEventLog 
    /// </summary>
    public partial class ProjectEventLog    
    {    
        public Int64 SysNo { get; set; }
          public Int64 EventSysNo { get; set; }
          public Int32 EventType { get; set; }
          public String EventContent1 { get; set; }
          public String EventContent2 { get; set; }
          public Boolean IsDelete { get; set; }
          public String CreateUserSysNo { get; set; }
          public String CreateUserName { get; set; }
          public DateTime? CreateTime { get; set; }
    } 
}

using System;
using System.Collections.Generic;
namespace My.Model
{   
    /// <summary>
    /// 实体-OperatingRules 
    /// </summary>
    public partial class OperatingRules    
    {    
        public Int64 SysNo { get; set; }
          public String RulesNo { get; set; }
          public Int64? InBuildingNo { get; set; }
          public DateTime ExecutionTime { get; set; }
          public String ProtectionTypeTime { get; set; }
          public String CreateUserName { get; set; }
          public DateTime CreateDate { get; set; }
          public String ModifyUserName { get; set; }
          public DateTime? ModifyDate { get; set; }
          public String CreateUserSysNo { get; set; }
          public String ModifyUserSysNo { get; set; }
    } 
}

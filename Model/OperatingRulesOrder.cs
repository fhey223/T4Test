using System;
using System.Collections.Generic;
namespace My.Model
{   
    /// <summary>
    /// 实体-OperatingRulesOrder 
    /// </summary>
    public partial class OperatingRulesOrder    
    {    
        public Int64 SysNo { get; set; }
          public Int64 InBuildingNo { get; set; }
          public Int32 FilingType { get; set; }
          public Int32 ProtectionType { get; set; }
          public Int32 RulesOrder { get; set; }
          public Boolean IsRepeat { get; set; }
          public String CreateUserName { get; set; }
          public DateTime CreateDate { get; set; }
          public String ModifyUserName { get; set; }
          public DateTime? ModifyDate { get; set; }
          public String CreateUserSysNo { get; set; }
          public String ModifyUserSysNo { get; set; }
    } 
}

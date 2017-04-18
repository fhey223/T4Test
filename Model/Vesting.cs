using System;
using System.Collections.Generic;
namespace My.Model
{   
    /// <summary>
    /// 实体-Vesting 
    /// </summary>
    public partial class Vesting    
    {    
        public Int64 SysNo { get; set; }
          public Int64 CustomerSysNo { get; set; }
          public Int32? VestingType { get; set; }
          public Int32? VestingSource { get; set; }
          public String SourceRemarks { get; set; }
          public String CreateUserName { get; set; }
          public DateTime CreateDate { get; set; }
          public String ModifyUserName { get; set; }
          public DateTime? ModifyDate { get; set; }
          public String CreateUserSysNo { get; set; }
          public String ModifyUserSysNo { get; set; }
          public String InEmployeesSysNo { get; set; }
    } 
}

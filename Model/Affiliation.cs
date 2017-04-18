using System;
using System.Collections.Generic;
namespace My.Model
{   
    /// <summary>
    /// 实体-Affiliation 
    /// </summary>
    public partial class Affiliation    
    {    
        public Int64 SysNo { get; set; }
          public Int64 CustomerA { get; set; }
          public Int64 CustomerB { get; set; }
          public String Relationship { get; set; }
          public Int32 InformationSources { get; set; }
          public Int32 Status { get; set; }
          public String CreateUserName { get; set; }
          public DateTime CreateDate { get; set; }
          public String ModifyUserName { get; set; }
          public DateTime? ModifyDate { get; set; }
          public String CreateUserSysNo { get; set; }
          public String ModifyUserSysNo { get; set; }
    } 
}

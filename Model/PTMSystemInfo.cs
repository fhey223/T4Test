using System;
using System.Collections.Generic;
namespace My.Model
{   
    /// <summary>
    /// 实体-PTMSystemInfo 
    /// </summary>
    public partial class PTMSystemInfo    
    {    
        public Int64 SysNo { get; set; }
          public String RoomSysNo { get; set; }
          public String BuildSysNo { get; set; }
          public String FilingProcessSysNo { get; set; }
          public String MessageInfo { get; set; }
          public String CreateUserSysNo { get; set; }
          public String CreateUserName { get; set; }
          public DateTime CreateDate { get; set; }
          public String ModifyUserSysNo { get; set; }
          public DateTime? ModifyDate { get; set; }
          public Boolean IsDelete { get; set; }
    } 
}

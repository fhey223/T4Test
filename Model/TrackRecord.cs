using System;
using System.Collections.Generic;
namespace My.Model
{   
    /// <summary>
    /// 实体-TrackRecord 
    /// </summary>
    public partial class TrackRecord    
    {    
        public Int64 SysNo { get; set; }
          public Int64 InBuildingSysNo { get; set; }
          public Int64 InCustomerSysNo { get; set; }
          public String TrackInfo { get; set; }
          public Int32 TrackType { get; set; }
          public String CreateUserName { get; set; }
          public DateTime CreateDate { get; set; }
          public String ModifyUserName { get; set; }
          public DateTime? ModifyDate { get; set; }
          public String CreateUserSysNo { get; set; }
          public String ModifyUserSysNo { get; set; }
          public Int32 Type { get; set; }
    } 
}

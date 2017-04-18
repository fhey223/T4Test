using System;
using System.Collections.Generic;
namespace My.Model
{   
    /// <summary>
    /// 实体-CustomerDemandRoom 
    /// </summary>
    public partial class CustomerDemandRoom    
    {    
        public Int64 SysNo { get; set; }
          public Int64 CustomerSysNo { get; set; }
          public Int64 RoomSysNo { get; set; }
          public Int32 DemandRoomType { get; set; }
          public String CreateUserName { get; set; }
          public DateTime CreateDate { get; set; }
          public String ModifyUserName { get; set; }
          public DateTime? ModifyDate { get; set; }
          public Boolean? IsDelete { get; set; }
          public String CreateUserSysNo { get; set; }
          public String ModifyUserSysNo { get; set; }
    } 
}

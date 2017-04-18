using System;
using System.Collections.Generic;
namespace My.Model
{   
    /// <summary>
    /// 实体-BaseHousesFloor 
    /// </summary>
    public partial class BaseHousesFloor    
    {    
        public Int64 SysNo { get; set; }
          public Int64 BuildingSysNo { get; set; }
          public Int64 SeatSysNo { get; set; }
          public String FloorNo { get; set; }
          public String FloorName { get; set; }
          public DateTime CreateDate { get; set; }
          public DateTime? ModifyDate { get; set; }
          public Boolean IsDelete { get; set; }
          public String CreateUserSysNo { get; set; }
          public String ModifyUserSysNo { get; set; }
    } 
}

using System;
using System.Collections.Generic;
namespace My.Model
{   
    /// <summary>
    /// 实体-BaseHousesUnit 
    /// </summary>
    public partial class BaseHousesUnit    
    {    
        public Int64 SysNo { get; set; }
          public String UnitNo { get; set; }
          public String UnitName { get; set; }
          public Int32? UnitDoorNum { get; set; }
          public Int32? UnitFloorNum { get; set; }
          public Boolean IsVirtual { get; set; }
          public DateTime CreateDate { get; set; }
          public DateTime? ModifyDate { get; set; }
          public Boolean IsDelete { get; set; }
          public String CreateUserSysNo { get; set; }
          public String ModifyUserSysNo { get; set; }
    } 
}

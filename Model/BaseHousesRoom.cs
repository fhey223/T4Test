using System;
using System.Collections.Generic;
namespace My.Model
{   
    /// <summary>
    /// 实体-BaseHousesRoom 
    /// </summary>
    public partial class BaseHousesRoom    
    {    
        public Int64 SysNo { get; set; }
          public Int64? SeatSysNo { get; set; }
          public Int64? UnitSysNo { get; set; }
          public Int32? FloorNum { get; set; }
          public String RoomNo { get; set; }
          public String RoomNoRules { get; set; }
          public Boolean? IsSales { get; set; }
          public String RoomName { get; set; }
          public Boolean IsCaseConfirm { get; set; }
          public Boolean IsFinanceConfirm { get; set; }
          public Boolean IsLock { get; set; }
          public Boolean IsPreLock { get; set; }
          public Boolean IsSold { get; set; }
          public Boolean IsHidden { get; set; }
          public Boolean IsVirtual { get; set; }
          public Int64? HousesTypeSysNo { get; set; }
          public Int32? PreSellCount { get; set; }
          public Int32? PreThirdSellCount { get; set; }
          public DateTime CreateDate { get; set; }
          public DateTime? ModifyDate { get; set; }
          public Boolean IsDelete { get; set; }
          public Decimal? HousesPrice { get; set; }
          public Decimal? HousesArea { get; set; }
          public String CreateUserSysNo { get; set; }
          public String ModifyUserSysNo { get; set; }
          public String PropertyType { get; set; }
    } 
}

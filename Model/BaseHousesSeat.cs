using System;
using System.Collections.Generic;
namespace My.Model
{   
    /// <summary>
    /// 实体-BaseHousesSeat 
    /// </summary>
    public partial class BaseHousesSeat    
    {    
        public Int64 SysNo { get; set; }
          public String SeatNo { get; set; }
          public String SeatName { get; set; }
          public String SeatInfo { get; set; }
          public String SeatType { get; set; }
          public String PropertyType { get; set; }
          public String BuildingStructure { get; set; }
          public Decimal? ManagermentFee { get; set; }
          public Int32? UnitNum { get; set; }
          public Int32 FloorNum { get; set; }
          public Int32? DoorNum { get; set; }
          public String HousesTypeName { get; set; }
          public DateTime CreateDate { get; set; }
          public DateTime? ModifyDate { get; set; }
          public Boolean IsDelete { get; set; }
          public Int32? Sort { get; set; }
          public String CreateUserSysNo { get; set; }
          public String ModifyUserSysNo { get; set; }
    } 
}

using System;
using System.Collections.Generic;
namespace My.Model
{   
    /// <summary>
    /// 实体-BaseHousesType 
    /// </summary>
    public partial class BaseHousesType    
    {    
        public Int64 SysNo { get; set; }
          public Int64 BuildingSysNo { get; set; }
          public String HousesTypeNo { get; set; }
          public String HousesTypeName { get; set; }
          public Int32 RoomNum { get; set; }
          public Int32 HallNum { get; set; }
          public Int32 ToiletNum { get; set; }
          public Int32? BalconyNum { get; set; }
          public Int32? GardenNum { get; set; }
          public Decimal? BuiltUpArea { get; set; }
          public Decimal? UseArea { get; set; }
          public Decimal? ShareArea { get; set; }
          public Decimal? GuidingPrice { get; set; }
          public String Orientation { get; set; }
          public String Picture { get; set; }
          public DateTime CreateDate { get; set; }
          public DateTime? ModifyDate { get; set; }
          public Boolean IsDelete { get; set; }
          public String CreateUserSysNo { get; set; }
          public String ModifyUserSysNo { get; set; }
    } 
}

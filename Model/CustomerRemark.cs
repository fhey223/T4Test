using System;
using System.Collections.Generic;
namespace My.Model
{   
    /// <summary>
    /// 实体-CustomerRemark 
    /// </summary>
    public partial class CustomerRemark    
    {    
        public Int64 SysNo { get; set; }
          public Int64 CustomerSysNo { get; set; }
          public Int32? Level { get; set; }
          public Int32? CustomerStatus { get; set; }
          public DateTime? VisitTime { get; set; }
          public Int32? AccompaniedType { get; set; }
          public String AccompaniedInformation { get; set; }
          public String DemandRoomType { get; set; }
          public Decimal? DemandPrice { get; set; }
          public Decimal? DemandTotalPrice { get; set; }
          public Decimal? DemandArea { get; set; }
          public Int32? HousesAge { get; set; }
          public Boolean IsDelete { get; set; }
          public String CreateUserName { get; set; }
          public DateTime CreateDate { get; set; }
          public String ModifyUserName { get; set; }
          public DateTime? ModifyDate { get; set; }
          public String Remark { get; set; }
          public Decimal? AreaSum { get; set; }
          public Int32? HallSum { get; set; }
          public Int32? RoomSum { get; set; }
          public Int32? ToiletSum { get; set; }
          public String CreateUserSysNo { get; set; }
          public String ModifyUserSysNo { get; set; }
          public String CustomerTag { get; set; }
    } 
}

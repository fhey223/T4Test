using System;
using System.Collections.Generic;
namespace My.Model
{   
    /// <summary>
    /// 实体-CustomerDemand 
    /// </summary>
    public partial class CustomerDemand    
    {    
        public Int64 SysNo { get; set; }
          public Int64? CustomerSysNo { get; set; }
          public String DemandRoomType { get; set; }
          public Decimal? DemandPrice { get; set; }
          public Decimal? DemandTotalPrice { get; set; }
          public Decimal? DemandArea { get; set; }
          public Int32? HousesAge { get; set; }
          public String CreateUserName { get; set; }
          public DateTime CreateDate { get; set; }
          public String ModifyUserName { get; set; }
          public DateTime? ModifyDate { get; set; }
          public String CreateUserSysNo { get; set; }
          public String ModifyUserSysNo { get; set; }
    } 
}

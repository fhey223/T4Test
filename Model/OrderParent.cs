using System;
using System.Collections.Generic;
namespace My.Model
{   
    /// <summary>
    /// 实体-OrderParent 
    /// </summary>
    public partial class OrderParent    
    {    
        public Int64 OrderParentNo { get; set; }
          public Int64 BuildingSysNo { get; set; }
          public Int64 FillingProcessSysNo { get; set; }
          public Int64 CustomerSysNo { get; set; }
          public Decimal OrderMoney { get; set; }
          public Decimal SurplusSplitMoney { get; set; }
          public Decimal PayMoney { get; set; }
          public DateTime CreateDate { get; set; }
          public String CreateUserSysNo { get; set; }
          public String CreateUserName { get; set; }
          public DateTime? ModifyDate { get; set; }
          public String ModifyUserSysNo { get; set; }
          public String ModifyUserName { get; set; }
          public Boolean IsDelete { get; set; }
    } 
}

using System;
using System.Collections.Generic;
namespace My.Model
{   
    /// <summary>
    /// 实体-Order 
    /// </summary>
    public partial class Order    
    {    
        public Int64 OrderNo { get; set; }
          public Decimal OrderMoney { get; set; }
          public Int32 PayStatus { get; set; }
          public Int32 ReceivingStatus { get; set; }
          public Int64? BillNo { get; set; }
          public Boolean IsSplit { get; set; }
          public Int64? OrderParentNo { get; set; }
          public Boolean IsCancel { get; set; }
          public String PayerName { get; set; }
          public String BankName { get; set; }
          public DateTime CreateDate { get; set; }
          public String CreateUserSysNo { get; set; }
          public String CreateUserName { get; set; }
          public DateTime? ModifyDate { get; set; }
          public String ModifyUserSysNo { get; set; }
          public String ModifyUserName { get; set; }
          public Boolean IsDelete { get; set; }
    } 
}

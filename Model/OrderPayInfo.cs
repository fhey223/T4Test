using System;
using System.Collections.Generic;
namespace My.Model
{   
    /// <summary>
    /// 实体-OrderPayInfo 
    /// </summary>
    public partial class OrderPayInfo    
    {    
        public Int64 SysNo { get; set; }
          public Int64 OrderNo { get; set; }
          public String BankCardNo { get; set; }
          public Boolean IsCCB { get; set; }
          public String CardCode { get; set; }
          public String PayWay { get; set; }
          public String TransactionType { get; set; }
          public String NetType { get; set; }
          public String POSSerialNo { get; set; }
          public String POSBatchNo { get; set; }
          public String HostSerial { get; set; }
          public String AuthCode { get; set; }
          public String MerchantNo { get; set; }
          public String POSTNo { get; set; }
          public String POSSystemSerial { get; set; }
          public DateTime TransactionTime { get; set; }
          public Decimal PayMoney { get; set; }
          public String CheckValue { get; set; }
          public DateTime CreateDate { get; set; }
          public String CreateUserSysNo { get; set; }
          public String CreateUserName { get; set; }
          public DateTime? ModifyDate { get; set; }
          public String ModifyUserSysNo { get; set; }
          public String ModifyUserName { get; set; }
          public Boolean IsDelete { get; set; }
    } 
}

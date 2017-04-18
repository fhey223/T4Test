using System;
using System.Collections.Generic;
namespace My.Model
{   
    /// <summary>
    /// 实体-POSTransaction 
    /// </summary>
    public partial class POSTransaction    
    {    
        public String SystemSerialNo { get; set; }
          public String POSSerialNo { get; set; }
          public String VersionNo { get; set; }
          public String TransactionType { get; set; }
          public String VirtualNo { get; set; }
          public String PayWay { get; set; }
          public Decimal? OrderTotalMoney { get; set; }
          public Decimal? OrderRealMoney { get; set; }
          public String MerchantNo { get; set; }
          public String POSBatchNo { get; set; }
          public String POSTNo { get; set; }
          public String AuthCode { get; set; }
          public String OperationNo { get; set; }
          public DateTime? OrderTime { get; set; }
          public DateTime? ProcessingTime { get; set; }
          public String BankCardNo { get; set; }
          public String ResponseCode { get; set; }
          public Int64? OrderNo { get; set; }
          public String CardCode { get; set; }
          public String HostNo { get; set; }
          public DateTime CreateDate { get; set; }
          public String CreateUserSysNo { get; set; }
          public String CreateUserName { get; set; }
          public DateTime? ModifyDate { get; set; }
          public String ModifyUserSysNo { get; set; }
          public String ModifyUserName { get; set; }
          public Boolean IsCheck { get; set; }
          public Boolean IsDelete { get; set; }
    } 
}

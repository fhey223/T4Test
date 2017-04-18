using System;
using System.Collections.Generic;
namespace My.Model
{   
    /// <summary>
    /// 实体-BankCardCode 
    /// </summary>
    public partial class BankCardCode    
    {    
        public Int64 SysNo { get; set; }
          public String CardPrefix { get; set; }
          public String Type { get; set; }
          public Int32? CardNoLength { get; set; }
          public String CardName { get; set; }
          public String CardCode { get; set; }
          public String BankName { get; set; }
          public Int32? CardBinLength { get; set; }
          public Boolean? IsEffective { get; set; }
    } 
}

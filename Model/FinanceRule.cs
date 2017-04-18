using System;
using System.Collections.Generic;
namespace My.Model
{   
    /// <summary>
    /// 实体-FinanceRule 
    /// </summary>
    public partial class FinanceRule    
    {    
        public Int64 SysNo { get; set; }
          public Int64 BuildingSysNo { get; set; }
          public Int32? RuleType { get; set; }
          public String RuleName { get; set; }
          public Decimal? Money { get; set; }
          public String Description { get; set; }
          public String TransactionNature { get; set; }
          public String PayWay { get; set; }
          public String PayNature { get; set; }
          public Boolean? IsFirstCheck { get; set; }
          public Boolean? IsSecondCheck { get; set; }
          public Int32? Percent { get; set; }
          public DateTime? EffectiveDate { get; set; }
          public DateTime? ExpiredDate { get; set; }
          public Boolean IsEnable { get; set; }
          public DateTime CreateDate { get; set; }
          public String CreateUserSysNo { get; set; }
          public String CreateUserName { get; set; }
          public DateTime? ModifyDate { get; set; }
          public String ModifyUserSysNo { get; set; }
          public String ModifyUserName { get; set; }
          public Boolean IsDelete { get; set; }
    } 
}

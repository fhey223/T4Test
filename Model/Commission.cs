using System;
using System.Collections.Generic;
namespace My.Model
{   
    /// <summary>
    /// 实体-Commission 
    /// </summary>
    public partial class Commission    
    {    
        public Int64 CommissionNo { get; set; }
          public Int64 BuildingSysNo { get; set; }
          public Decimal Money { get; set; }
          public Int32 ReviewStatus { get; set; }
          public Int32 Amount { get; set; }
          public Int32 CommissionStatus { get; set; }
          public DateTime CreateDate { get; set; }
          public String CreateUserSysNo { get; set; }
          public String CreateUserName { get; set; }
          public DateTime? ModifyDate { get; set; }
          public String ModifyUserSysNo { get; set; }
          public String ModifyUserName { get; set; }
          public Boolean IsDelete { get; set; }
    } 
}

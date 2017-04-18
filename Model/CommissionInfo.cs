using System;
using System.Collections.Generic;
namespace My.Model
{   
    /// <summary>
    /// 实体-CommissionInfo 
    /// </summary>
    public partial class CommissionInfo    
    {    
        public Int64 SysNo { get; set; }
          public Int64 CommissionNo { get; set; }
          public Int64 OrderParentNo { get; set; }
          public Decimal Money { get; set; }
          public Int64 FillingProcessSysNo { get; set; }
          public Int64 CustomerSysNo { get; set; }
    } 
}

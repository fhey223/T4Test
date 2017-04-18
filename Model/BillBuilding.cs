using System;
using System.Collections.Generic;
namespace My.Model
{   
    /// <summary>
    /// 实体-BillBuilding 
    /// </summary>
    public partial class BillBuilding   
    {    
        public Int64 SysNo { get; set; }
          public Int64 BuildingSysNo { get; set; }
          public Int64 BillNo { get; set; }
          public Decimal? Money { get; set; }
          public String ReceiveSysNo { get; set; }
          public String ReceiveName { get; set; }
          public Int32 UseStatus { get; set; }
          public DateTime? UseDate { get; set; }
          public Boolean IsRecovery { get; set; }
          public String ReturnUserSysNo { get; set; }
          public String ReturnUserName { get; set; }
          public DateTime? RecoveryDate { get; set; }
          public String RecoverySysNo { get; set; }
          public String RecoveryName { get; set; }
          public DateTime CreateDate { get; set; }
          public String CreateUserSysNo { get; set; }
          public String CreateUserName { get; set; }
          public DateTime? ModifyDate { get; set; }
          public String ModifyUserSysNo { get; set; }
          public String ModifyUserName { get; set; }
          public Boolean IsDelete { get; set; }
    } 
}

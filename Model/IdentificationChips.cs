using System;
using System.Collections.Generic;
namespace My.Model
{   
    /// <summary>
    /// 实体-IdentificationChips 
    /// </summary>
    public partial class IdentificationChips    
    {    
        public Int64 SysNo { get; set; }
          public String IdentificationChipsNo { get; set; }
          public Int64 PersonNo { get; set; }
          public Int64 BuildingSysNo { get; set; }
          public Int64 EmployeeSysNo { get; set; }
          public DateTime IdentificationChipsDate { get; set; }
          public Decimal IdentificationChipsMoney { get; set; }
          public Boolean IsUsed { get; set; }
          public String FileListStr { get; set; }
          public Int64 CreateUserSysNo { get; set; }
          public String CreateUserName { get; set; }
          public DateTime? CreateDate { get; set; }
          public Int64? ModifyUserSysNo { get; set; }
          public String ModifyUserName { get; set; }
          public DateTime? ModifyDate { get; set; }
          public Boolean IsDelete { get; set; }
    } 
}

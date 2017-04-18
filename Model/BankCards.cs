using System;
using System.Collections.Generic;
namespace My.Model
{   
    /// <summary>
    /// 实体-BankCards 
    /// </summary>
    public partial class BankCards    
    {    
        public Int64 SysNo { get; set; }
          public Int64 PersonNo { get; set; }
          public String BankCardNo { get; set; }
          public Int32? BankCardType { get; set; }
          public DateTime AcquisitionTime { get; set; }
          public String IssuingBank { get; set; }
          public Int64 OperatorEmployeesSysNo { get; set; }
          public String CreateUserName { get; set; }
          public DateTime? CreateDate { get; set; }
          public String ModifyUserName { get; set; }
          public DateTime? ModifyDate { get; set; }
          public Boolean IsDelete { get; set; }
          public String CreateUserSysNo { get; set; }
          public String ModifyUserSysNo { get; set; }
    } 
}

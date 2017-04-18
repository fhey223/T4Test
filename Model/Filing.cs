using System;
using System.Collections.Generic;
namespace My.Model
{   
    /// <summary>
    /// 实体-Filing 
    /// </summary>
    public partial class Filing    
    {    
        public Int64 SysNo { get; set; }
          public String FilingNo { get; set; }
          public Int64 InCustomerSysNo { get; set; }
          public Int64? InPersonSysNo { get; set; }
          public Int64 InBuildingSysNo { get; set; }
          public Int32 FilingType { get; set; }
          public Boolean FilingStatus { get; set; }
          public Boolean Binding { get; set; }
          public String CreateUserName { get; set; }
          public DateTime CreateDate { get; set; }
          public String ModifyUserName { get; set; }
          public DateTime? ModifyDate { get; set; }
          public String CreateUserSysNo { get; set; }
          public String ModifyUserSysNo { get; set; }
          public String InEmployeesSysNo { get; set; }
          public String InDepartmentNo { get; set; }
    } 
}

using System;
using System.Collections.Generic;
namespace My.Model
{   
    /// <summary>
    /// 实体-ReviewStaff 
    /// </summary>
    public partial class ReviewStaff    
    {    
        public Decimal SysNo { get; set; }
          public Int64 BuildingSysNo { get; set; }
          public String StaffNo { get; set; }
          public String StaffName { get; set; }
          public Int32 ReviewLevel { get; set; }
          public DateTime CreateDate { get; set; }
          public String CreateUserSysNo { get; set; }
          public String CreateUserName { get; set; }
          public DateTime? ModifyDate { get; set; }
          public String ModifyUserSysNo { get; set; }
          public String ModifyUserName { get; set; }
          public Boolean IsDelete { get; set; }
    } 
}

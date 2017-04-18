using System;
using System.Collections.Generic;
namespace My.Model
{   
    /// <summary>
    /// 实体-Bill 
    /// </summary>
    public partial class Bill    
    {    
        public Int64 BillNo { get; set; }
          public Int32 Status { get; set; }
          public DateTime CreateDate { get; set; }
          public String CreateUserSysNo { get; set; }
          public String CreateUserName { get; set; }
          public DateTime? ModifyDate { get; set; }
          public String ModifyUserSysNo { get; set; }
          public String ModifyUserName { get; set; }
          public Boolean IsDelete { get; set; }
    } 
}

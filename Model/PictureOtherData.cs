using System;
using System.Collections.Generic;
namespace My.Model
{   
    /// <summary>
    /// 实体-PictureOtherData 
    /// </summary>
    public partial class PictureOtherData    
    {    
        public Int64 SysNo { get; set; }
          public String PID { get; set; }
          public String PName { get; set; }
          public String Affiliation { get; set; }
          public String Remark { get; set; }
          public DateTime? ModifyDate { get; set; }
          public DateTime CreateDate { get; set; }
          public Int32 IsDeleted { get; set; }
          public Int32 IsNewObject { get; set; }
          public String CreateUserSysNo { get; set; }
          public String ModifyUserSysNo { get; set; }
          public String OperationSysNo { get; set; }
    } 
}

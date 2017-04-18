using System;
using System.Collections.Generic;
namespace My.Model
{   
    /// <summary>
    /// 实体-RelationRequestSN 
    /// </summary>
    public partial class RelationRequestSN    
    {    
        public Int64 SysNo { get; set; }
          public String RequestSN { get; set; }
          public Int64 RelationSysNo { get; set; }
          public DateTime CreateDate { get; set; }
    } 
}

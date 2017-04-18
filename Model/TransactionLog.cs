using System;
using System.Collections.Generic;
namespace My.Model
{   
    /// <summary>
    /// 实体-TransactionLog 
    /// </summary>
    public partial class TransactionLog    
    {    
        public Int64 LogId { get; set; }
          public Int64? RelationNo { get; set; }
          public Int32? Type { get; set; }
          public String RequestContent { get; set; }
          public String ResponseContent { get; set; }
          public DateTime CreateDate { get; set; }
          public String CreateUserSysNo { get; set; }
          public String CreateUserName { get; set; }
          public Boolean IsDelete { get; set; }
    } 
}

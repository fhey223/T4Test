using System;
using System.Collections.Generic;
namespace My.Model
{   
    /// <summary>
    /// 实体-Sequences 
    /// </summary>
    public partial class Sequences    
    {    
        public Int64 ID { get; set; }
          public String SeqName { get; set; }
          public Int64? SeqID { get; set; }
          public Int64? Times { get; set; }
    } 
}

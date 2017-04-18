using System;
using System.Collections.Generic;
namespace My.Model
{   
    /// <summary>
    /// 实体-CustomerSource 
    /// </summary>
    public partial class CustomerSource    
    {    
        public String Name { get; set; }
          public String Telephone { get; set; }
          public String EmpNo { get; set; }
          public Int32 FilingType { get; set; }
          public Int32 IsSuccess { get; set; }
    } 
}

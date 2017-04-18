using System;
using System.Collections.Generic;
namespace My.Model
{   
    /// <summary>
    /// 实体-Person 
    /// </summary>
    public partial class Person    
    {    
        public Int64 SysNo { get; set; }
          public String MD5 { get; set; }
          public String PersonNo { get; set; }
          public String CredentialsName { get; set; }
          public Int32? Gender { get; set; }
          public String CredentialsNumber { get; set; }
          public Int32? CredentialsType { get; set; }
          public String CreateUserName { get; set; }
          public DateTime CreateDate { get; set; }
          public String ModifyUserName { get; set; }
          public DateTime? ModifyDate { get; set; }
          public String CreateUserSysNo { get; set; }
          public String ModifyUserSysNo { get; set; }
    } 
}

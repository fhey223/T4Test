using System;
using System.Collections.Generic;
namespace My.Model
{   
    /// <summary>
    /// 实体-IdCardDetails 
    /// </summary>
    public partial class IdCardDetails    
    {    
        public Int64 SysNo { get; set; }
          public String CardNo { get; set; }
          public Int32 CredentialsType { get; set; }
          public String Name { get; set; }
          public Int32 Gender { get; set; }
          public DateTime Birthday { get; set; }
          public String Address { get; set; }
          public String VisaAgency { get; set; }
          public DateTime? EffectiveDate { get; set; }
          public DateTime? ExpiryDate { get; set; }
          public Boolean IsTrusted { get; set; }
          public Byte[]? CardImage { get; set; }
          public DateTime CreateDate { get; set; }
          public String CreateUserName { get; set; }
          public DateTime? ModifyDate { get; set; }
          public String ModifyUserName { get; set; }
          public Boolean IsDelete { get; set; }
          public String CreateUserSysNo { get; set; }
          public String ModifyUserSysNo { get; set; }
          public String Nation { get; set; }
    } 
}

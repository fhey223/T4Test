using System;
using System.Collections.Generic;
namespace My.Model
{   
    /// <summary>
    /// 实体-Customer 
    /// </summary>
    public partial class Customer    
    {    
        public Int64 SysNo { get; set; }
          public Int64 PersonSysNo { get; set; }
          public String CustomerName { get; set; }
          public String MobilePhone { get; set; }
          public String Telephone { get; set; }
          public Int32? Gender { get; set; }
          public String IdentityCardNumber { get; set; }
          public Int32? CredentialsType { get; set; }
          public String EmailAddress { get; set; }
          public Int32? Age { get; set; }
          public String Profession { get; set; }
          public String Postcode { get; set; }
          public String Post { get; set; }
          public String CarType { get; set; }
          public String CarNo { get; set; }
          public Int32? VisitorsNum { get; set; }
          public Int32? FamilyNum { get; set; }
          public String Province { get; set; }
          public String City { get; set; }
          public String District { get; set; }
          public String Address { get; set; }
          public String Census { get; set; }
          public String LifeCondition { get; set; }
          public Int32? LivingCondition { get; set; }
          public Int32? EconomicCapacity { get; set; }
          public Int32? MaritalStatus { get; set; }
          public Int32? Motivation { get; set; }
          public String CreateUserName { get; set; }
          public DateTime CreateDate { get; set; }
          public String ModifyUserName { get; set; }
          public DateTime? ModifyDate { get; set; }
          public Boolean IsDelete { get; set; }
          public Decimal? HouseholdIncome { get; set; }
          public Int32? PropertyNum { get; set; }
          public DateTime? Time { get; set; }
          public String CreateUserSysNo { get; set; }
          public String ModifyUserSysNo { get; set; }
          public DateTime RefreshDate { get; set; }
          public Int32 IsAttention { get; set; }
          public Int32 Source { get; set; }
    } 
}

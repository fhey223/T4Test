using System;
using System.Collections.Generic;
namespace My.Model
{   
    /// <summary>
    /// 实体-RelationEntity 
    /// </summary>
    public partial class RelationEntity    
    {    
        public Int64 SysNo { get; set; }
          public Int64? RelationParentSysNo { get; set; }
          public Int32 EntityType { get; set; }
          public Int64? RelationSonSysNo { get; set; }
          public Int32? RelationDepth { get; set; }
          public String Attribute1 { get; set; }
          public String Attribute2 { get; set; }
          public String Attribute3 { get; set; }
          public String Attribute4 { get; set; }
          public String Attribute5 { get; set; }
          public Int32 VestingSource { get; set; }
          public String VestingNote { get; set; }
          public String CreateUserName { get; set; }
          public DateTime CreateDate { get; set; }
          public String ModifyUserName { get; set; }
          public DateTime? ModifyDate { get; set; }
          public Boolean IsDelete { get; set; }
          public String Path { get; set; }
          public String CreateUserSysNo { get; set; }
          public String ModifyUserSysNo { get; set; }
          public String EntityId { get; set; }
    } 
}

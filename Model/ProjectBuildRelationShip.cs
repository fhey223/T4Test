using System;
using System.Collections.Generic;
namespace My.Model
{   
    /// <summary>
    /// 实体-ProjectBuildRelationShip 
    /// </summary>
    public partial class ProjectBuildRelationShip    
    {    
        public Int64 SysNo { get; set; }
          public Int64? Key { get; set; }
          public Int64? ParentKey { get; set; }
          public String Name { get; set; }
          public String ParentName { get; set; }
          public DateTime? CreateDate { get; set; }
          public String CreateUserSysNo { get; set; }
          public String ModifyUserSysNo { get; set; }
          public DateTime? ModifyDate { get; set; }
          public Int32? IsDel { get; set; }
          public String Type { get; set; }
    } 
}

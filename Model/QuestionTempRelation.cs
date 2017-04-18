using System;
using System.Collections.Generic;
namespace My.Model
{   
    /// <summary>
    /// 实体-QuestionTempRelation 
    /// </summary>
    public partial class QuestionTempRelation    
    {    
        public Int64 SysNo { get; set; }
          public Int64 TemplateSysNo { get; set; }
          public Int32 TemplateType { get; set; }
          public Int64 BuildingSysNo { get; set; }
          public DateTime CreateDate { get; set; }
          public Int64? CreateUserSysNo { get; set; }
          public String CreateUserName { get; set; }
          public DateTime? ModifyDate { get; set; }
          public Int64? ModifyUserSysNo { get; set; }
          public String ModifyUserName { get; set; }
          public Boolean IsDelete { get; set; }
    } 
}

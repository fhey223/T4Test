using System;
using System.Collections.Generic;
namespace My.Model
{   
    /// <summary>
    /// 实体-QuestionTemplate 
    /// </summary>
    public partial class QuestionTemplate    
    {    
        public Int64 SysNo { get; set; }
          public String TemplateName { get; set; }
          public Int32? TemplateVersion { get; set; }
          public Int32? TemplateType { get; set; }
          public String QuestionStringList { get; set; }
          public String QuestionMd5 { get; set; }
          public Boolean IsEnable { get; set; }
          public DateTime CreateDate { get; set; }
          public String CreateUserName { get; set; }
          public DateTime? ModifyDate { get; set; }
          public String ModifyUserName { get; set; }
          public Boolean IsDelete { get; set; }
          public Int64? BuildingSysNo { get; set; }
          public String CreateUserSysNo { get; set; }
          public String ModifyUserSysNo { get; set; }
    } 
}

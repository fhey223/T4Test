using System;
using System.Collections.Generic;
namespace My.Model
{   
    /// <summary>
    /// 实体-QuestionAnswerStatistics 
    /// </summary>
    public partial class QuestionAnswerStatistics    
    {    
        public Int64 SysNo { get; set; }
          public Int64 BuildingSysNo { get; set; }
          public Int64 TemplateSysNo { get; set; }
          public String QuestionName { get; set; }
          public String AnswerOption { get; set; }
          public Int32 Count { get; set; }
          public String CreateUserName { get; set; }
          public DateTime CreateDate { get; set; }
          public String ModifyUserName { get; set; }
          public DateTime? ModifyDate { get; set; }
          public String CreateUserSysNo { get; set; }
          public String ModifyUserSysNo { get; set; }
    } 
}

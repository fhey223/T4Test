using System;
using System.Collections.Generic;
namespace My.Model
{   
    /// <summary>
    /// 实体-QuestionValues 
    /// </summary>
    public partial class QuestionValues    
    {    
        public Int64 SysNo { get; set; }
          public Int64 TemplateSysNo { get; set; }
          public Int64? BuildingSysNo { get; set; }
          public Int64 AnswerSysNo { get; set; }
          public Int32 QuestionIndex { get; set; }
          public Int32 OptionsIndex { get; set; }
          public String QuestionAnswer { get; set; }
          public DateTime AnswerTime { get; set; }
          public DateTime CreateDate { get; set; }
          public String CreateUserName { get; set; }
          public DateTime? ModifyDate { get; set; }
          public String ModifyUserName { get; set; }
          public Boolean IsDelete { get; set; }
          public String CreateUserSysNo { get; set; }
          public String ModifyUserSysNo { get; set; }
    } 
}

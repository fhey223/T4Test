using System;
using System.Collections.Generic;
namespace My.Model
{   
    /// <summary>
    /// 实体-QuestionAnswer 
    /// </summary>
    public partial class QuestionAnswer    
    {    
        public Int64 SysNo { get; set; }
          public Int64 InTemplateSysNo { get; set; }
          public Int64 BuildingSysNo { get; set; }
          public Int64 AnswerSysNo { get; set; }
          public String AnswerName { get; set; }
          public DateTime AnswerTime { get; set; }
          public String AnswerStringList { get; set; }
          public DateTime CreateDate { get; set; }
          public String CreateUserName { get; set; }
          public DateTime? ModifyDate { get; set; }
          public String ModifyUserName { get; set; }
          public Boolean IsDelete { get; set; }
          public String CreateUserSysNo { get; set; }
          public String ModifyUserSysNo { get; set; }
    } 
}

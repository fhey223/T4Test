//------------------------------------------------------------------------------
// <auto-generated>
//     此代码由T4模板自动生成
//	   生成时间 2016-08-03 13:50:23 by jie
//     对此文件的更改可能会导致不正确的行为，并且如果
//     重新生成代码，这些更改将会丢失。
// </auto-generated>
//------------------------------------------------------------------------------

using System;
namespace T4ConsoleApplication.Entities
{	
    /// <summary>
    /// 实体-FilingProcess 
    /// </summary>
	public partial class FilingProcess
    {
		
		/// <summary>
		/// 
		/// </summary>		
		public long SysNo { get; set; }
		
		/// <summary>
		/// 客户业务编号
		/// </summary>		
		public long? FilingSysNo { get; set; }
		
		/// <summary>
		/// 保护时间
		/// </summary>		
		public int? ProtectionTime { get; set; }
		
		/// <summary>
		/// 报备类型(1:报备保护期;2:来电保护期;3:报备成功未到访保护期;4:来访保护期;5:客户跟进保护期;6:公客分配保护期;)
		/// </summary>		
		public int? ProtectionType { get; set; }
		
		/// <summary>
		/// 报备进程状态(1:成功;2:进行中;3:失败)
		/// </summary>		
		public int FilingProcessStatus { get; set; }
		
		/// <summary>
		/// 删除标记
		/// </summary>		
		public bool IsDelete { get; set; }
		
		/// <summary>
		/// 来电时间,来访时间
		/// </summary>		
		public DateTime? Time { get; set; }
		
		/// <summary>
		/// 来电时间,来访时间备注
		/// </summary>		
		public string TimeRemarks { get; set; }
		
		/// <summary>
		/// 
		/// </summary>		
		public string CreateUserName { get; set; }
		
		/// <summary>
		/// 
		/// </summary>		
		public DateTime CreateDate { get; set; }
		
		/// <summary>
		/// 
		/// </summary>		
		public string ModifyUserName { get; set; }
		
		/// <summary>
		/// 
		/// </summary>		
		public DateTime? ModifyDate { get; set; }
		
		/// <summary>
		/// 
		/// </summary>		
		public int Attribute11 { get; set; }
		
		/// <summary>
		/// 
		/// </summary>		
		public int Attribute12 { get; set; }
		
		/// <summary>
		/// 
		/// </summary>		
		public int Attribute13 { get; set; }
		
		/// <summary>
		/// 
		/// </summary>		
		public DateTime Attribute16 { get; set; }
		
		/// <summary>
		/// 
		/// </summary>		
		public string Attribute1 { get; set; }
		
		/// <summary>
		/// 
		/// </summary>		
		public string Attribute2 { get; set; }
		
		/// <summary>
		/// 
		/// </summary>		
		public string Attribute3 { get; set; }
		
		/// <summary>
		/// 
		/// </summary>		
		public string Attribute4 { get; set; }
		
		/// <summary>
		/// 
		/// </summary>		
		public string Attribute5 { get; set; }
		
		/// <summary>
		/// 
		/// </summary>		
		public string Attribute6 { get; set; }
		
		/// <summary>
		/// 
		/// </summary>		
		public string Attribute7 { get; set; }
		
		/// <summary>
		/// 
		/// </summary>		
		public string Attribute8 { get; set; }
		
		/// <summary>
		/// 
		/// </summary>		
		public string Attribute9 { get; set; }
		
		/// <summary>
		/// 
		/// </summary>		
		public string Attribute10 { get; set; }
		
		/// <summary>
		/// 
		/// </summary>		
		public DateTime Attribute17 { get; set; }
		
		/// <summary>
		/// 
		/// </summary>		
		public DateTime Attribute18 { get; set; }
		
		/// <summary>
		/// 
		/// </summary>		
		public DateTime Attribute19 { get; set; }
		
		/// <summary>
		/// 
		/// </summary>		
		public DateTime Attribute20 { get; set; }
		
		/// <summary>
		/// 
		/// </summary>		
		public decimal? Attribute21 { get; set; }
		
		/// <summary>
		/// 
		/// </summary>		
		public decimal? Attribute22 { get; set; }
		
		/// <summary>
		/// 
		/// </summary>		
		public decimal? Attribute23 { get; set; }
		
		/// <summary>
		/// 
		/// </summary>		
		public decimal? Attribute24 { get; set; }
		
		/// <summary>
		/// 
		/// </summary>		
		public decimal? Attribute25 { get; set; }
		
		/// <summary>
		/// 
		/// </summary>		
		public long Attribute14 { get; set; }
		
		/// <summary>
		/// 
		/// </summary>		
		public long Attribute15 { get; set; }
		
		/// <summary>
		/// 
		/// </summary>		
		public double Attribute26 { get; set; }
		
		/// <summary>
		/// 
		/// </summary>		
		public double Attribute27 { get; set; }
		
		/// <summary>
		/// 
		/// </summary>		
		public string CreateUserSysNo { get; set; }
		
		/// <summary>
		/// 
		/// </summary>		
		public string ModifyUserSysNo { get; set; }
		
		/// <summary>
		/// 
		/// </summary>		
		public string InEmployeesSysNo { get; set; }
		
		/// <summary>
		/// 
		/// </summary>		
		public long RelationSysNo { get; set; }
		
		/// <summary>
		/// 
		/// </summary>		
		public long OrderParentNo { get; set; }
		  
    }
}
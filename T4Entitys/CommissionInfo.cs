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
    /// 实体-CommissionInfo 
    /// </summary>
	public partial class CommissionInfo
    {
		
		/// <summary>
		/// 
		/// </summary>		
		public long SysNo { get; set; }
		
		/// <summary>
		/// 转佣系统编号
		/// </summary>		
		public long CommissionNo { get; set; }
		
		/// <summary>
		/// 订单编号
		/// </summary>		
		public long OrderParentNo { get; set; }
		
		/// <summary>
		/// 订单金额
		/// </summary>		
		public decimal Money { get; set; }
		
		/// <summary>
		/// 案件编号
		/// </summary>		
		public long FillingProcessSysNo { get; set; }
		
		/// <summary>
		/// 客户编号
		/// </summary>		
		public long CustomerSysNo { get; set; }
		  
    }
}
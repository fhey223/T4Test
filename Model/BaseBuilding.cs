using System;
using System.Collections.Generic;
namespace My.Model
{   
    /// <summary>
    /// 实体-BaseBuilding 
    /// </summary>
    public partial class BaseBuilding    
    {    
        public Int64 SysNo { get; set; }
          public String BuildNo { get; set; }
          public String BuildName { get; set; }
          public String PropertyRights { get; set; }
          public Decimal? BuiltUpArea { get; set; }
          public String Address { get; set; }
          public String Province { get; set; }
          public String City { get; set; }
          public String District { get; set; }
          public String InDepartment { get; set; }
          public String TotalMatter { get; set; }
          public String Developer { get; set; }
          public String TransactionPrefix { get; set; }
          public DateTime? EntryDate { get; set; }
          public String PreLicenseNo { get; set; }
          public String PropertyType { get; set; }
          public String ConstructionCategory { get; set; }
          public String PropertyCompany { get; set; }
          public Decimal? ManagermentFee { get; set; }
          public String RenovatedState { get; set; }
          public String DesignUnits { get; set; }
          public DateTime? HandoverDate { get; set; }
          public String InBusinessCircle { get; set; }
          public String AdvertDesign { get; set; }
          public DateTime? OpeningTime { get; set; }
          public Int32? ParkingNum { get; set; }
          public String Builders { get; set; }
          public Int32? BuildingStatus { get; set; }
          public String ParcelNo { get; set; }
          public Decimal? GreeningRate { get; set; }
          public Decimal? VolumeRate { get; set; }
          public String ContractNo { get; set; }
          public DateTime? GrantDate { get; set; }
          public Decimal? AgentPoint { get; set; }
          public String Features { get; set; }
          public Decimal? Covers { get; set; }
          public String UseLife { get; set; }
          public String SalesAddress { get; set; }
          public String SalesTel { get; set; }
          public DateTime? SalesCompletionDate { get; set; }
          public Decimal? AveragePrice { get; set; }
          public Boolean? IsRecommend { get; set; }
          public String BuildingIntroduction { get; set; }
          public String AreaIntroduction { get; set; }
          public String TrafficIntroduction { get; set; }
          public String OtherNote { get; set; }
          public Boolean? IsReceivables { get; set; }
          public String Longitude { get; set; }
          public String Dimensions { get; set; }
          public Int32 ResidentCount { get; set; }
          public DateTime CreateDate { get; set; }
          public DateTime? ModifyDate { get; set; }
          public Boolean IsDelete { get; set; }
          public String CreateUserSysNo { get; set; }
          public String ModifyUserSysNo { get; set; }
          public Decimal? ManagermentFeeLimit { get; set; }
          public Decimal? VolumeRateLimit { get; set; }
    } 
}

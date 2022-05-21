using System;
using System.Collections.Generic;
using System.Runtime.Serialization;

#nullable disable

namespace FarmerSchemeProject.Models
{
    [DataContract]
    public partial class Insurance
    {
        [DataMember]
        public string InsuranceCompany { get; set; }
        [DataMember]
        public int SumInsuredperhectar { get; set; }
        [DataMember]
        public int SharePremium { get; set; }
        [DataMember]
        public int PremiumAmmount { get; set; }
        [DataMember]
        public string CropName { get; set; }
        [DataMember]
        public string Area { get; set; }
        [DataMember]
        public int? SumInsured { get; set; }
        [DataMember]
        public int UserId { get; set; }
        [DataMember]
        public string Season { get; set; }
        [DataMember]
        public string Year { get; set; }
        [DataMember]
        public int? PolicyNo { get; set; }
        [DataMember]
        public int InsuranceId { get; set; }
        
        public virtual ClaimInsurance PolicyNoNavigation { get; set; }
        public virtual Roletable User { get; set; }
    }
}

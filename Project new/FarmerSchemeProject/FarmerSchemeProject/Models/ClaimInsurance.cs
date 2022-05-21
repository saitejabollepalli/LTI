using System;
using System.Collections.Generic;
using System.Runtime.Serialization;

#nullable disable

namespace FarmerSchemeProject.Models
{
    [DataContract]
    public partial class ClaimInsurance
    {
      
        public ClaimInsurance()
        {
            Insurances = new HashSet<Insurance>();
        }
        [DataMember]

        public int PolicyNo { get; set; }
        [DataMember]
        public string NameofInsure { get; set; }
        [DataMember]
        public DateTime DateOfLoss { get; set; }
        [DataMember]
        public string CauseofLoss { get; set; }

        public virtual ICollection<Insurance> Insurances { get; set; }
    }
}

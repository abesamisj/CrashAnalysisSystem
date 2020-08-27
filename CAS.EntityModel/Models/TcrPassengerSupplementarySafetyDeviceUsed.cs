namespace CAS.EntityModel.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("TcrPassengerSupplementarySafetyDeviceUsed")]
    public partial class TcrPassengerSupplementarySafetyDeviceUsed
    {
        public int tcrPassengerSupplementarySafetyDeviceUsedid { get; set; }

        public int tcrPassengerid { get; set; }

        public int supplementarySafetyDeviceTypeid { get; set; }

        [StringLength(50)]
        public string otherSupplementaryDevice { get; set; }

        public virtual SupplementarySafetyDeviceType SupplementarySafetyDeviceType { get; set; }

        public virtual TcrPassenger TcrPassenger { get; set; }
    }
}

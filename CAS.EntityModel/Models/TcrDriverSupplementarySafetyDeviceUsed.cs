namespace CAS.EntityModel.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("TcrDriverSupplementarySafetyDeviceUsed")]
    public partial class TcrDriverSupplementarySafetyDeviceUsed
    {
        public int tcrDriverSupplementarySafetyDeviceUsedid { get; set; }

        public int tcrDriverid { get; set; }

        public int supplementarySafetyDeviceTypeid { get; set; }

        [StringLength(50)]
        public string otherSupplementaryDevice { get; set; }

        public virtual SupplementarySafetyDeviceType SupplementarySafetyDeviceType { get; set; }

        public virtual TcrDriver TcrDriver { get; set; }
    }
}

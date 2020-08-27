namespace CAS.EntityModel.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("CodedCrashDriverSupplementarySafetyDeviceUsed")]
    public partial class CodedCrashDriverSupplementarySafetyDeviceUsed
    {
        public int codedCrashDriverSupplementarySafetyDeviceUsedid { get; set; }

        public int codedCrashDriverid { get; set; }

        public int supplementarySafetyDeviceTypeid { get; set; }

        [StringLength(50)]
        public string otherSupplementarySafetyDevice { get; set; }

        public virtual CodedCrashDriver CodedCrashDriver { get; set; }

        public virtual SupplementarySafetyDeviceType SupplementarySafetyDeviceType { get; set; }
    }
}

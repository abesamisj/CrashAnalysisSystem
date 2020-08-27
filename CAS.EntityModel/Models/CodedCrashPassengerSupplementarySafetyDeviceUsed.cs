namespace CAS.EntityModel.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("CodedCrashPassengerSupplementarySafetyDeviceUsed")]
    public partial class CodedCrashPassengerSupplementarySafetyDeviceUsed
    {
        public int codedCrashPassengerSupplementarySafetyDeviceUsedid { get; set; }

        public int codedCrashPassengerid { get; set; }

        public int supplementarySafetyDeviceTypeid { get; set; }

        [StringLength(50)]
        public string otherSupplementarySafetyDevice { get; set; }

        public virtual CodedCrashPassenger CodedCrashPassenger { get; set; }

        public virtual SupplementarySafetyDeviceType SupplementarySafetyDeviceType { get; set; }
    }
}

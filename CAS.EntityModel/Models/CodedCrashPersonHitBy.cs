namespace CAS.EntityModel.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("CodedCrashPersonHitBy")]
    public partial class CodedCrashPersonHitBy
    {
        public int codedCrashPersonHitByid { get; set; }

        public int codedCrashPersonid { get; set; }

        public int codedCrashVehicleid { get; set; }

        public virtual CodedCrashPerson CodedCrashPerson { get; set; }

        public virtual CodedCrashVehicle CodedCrashVehicle { get; set; }
    }
}

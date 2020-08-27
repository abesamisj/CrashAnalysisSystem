namespace CAS.EntityModel.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("CodedCrashVehicleObjectsStruck")]
    public partial class CodedCrashVehicleObjectsStruck
    {
        [Key]
        public int codedCrashvehicleObjectStruckid { get; set; }

        public int codedCrashVehicleid { get; set; }

        public int? struckObjectTypeid { get; set; }

        public int? sequence { get; set; }

        public virtual CodedCrashVehicle CodedCrashVehicle { get; set; }

        public virtual StruckObjectType StruckObjectType { get; set; }
    }
}

namespace CAS.EntityModel.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("CodedCrashVehiclePermit")]
    public partial class CodedCrashVehiclePermit
    {
        public int codedCrashVehiclePermitid { get; set; }

        public int codedCrashVehicleid { get; set; }

        public int vehiclePermitTypeTypeid { get; set; }

        [StringLength(50)]
        public string vehiclePermitNumber { get; set; }

        public int isCompliantYesNoUnknownTypeid { get; set; }

        public virtual CodedCrashVehicle CodedCrashVehicle { get; set; }

        public virtual VehiclePermitTypeType VehiclePermitTypeType { get; set; }

        public virtual YesNoUnknownType YesNoUnknownType { get; set; }
    }
}

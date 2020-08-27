namespace CAS.EntityModel.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("TcrVehiclePermit")]
    public partial class TcrVehiclePermit
    {
        public int tcrVehiclePermitid { get; set; }

        public int tcrVehicleid { get; set; }

        [StringLength(50)]
        public string vehiclePermitNumber { get; set; }

        public int vehiclePermitTypeTypeid { get; set; }

        public int isCompliantYesNoUnknownTypeid { get; set; }

        public virtual TcrVehicle TcrVehicle { get; set; }

        public virtual VehiclePermitTypeType VehiclePermitTypeType { get; set; }

        public virtual YesNoUnknownType YesNoUnknownType { get; set; }
    }
}

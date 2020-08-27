namespace CAS.EntityModel.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("CodedCrashVehicleDevice")]
    public partial class CodedCrashVehicleDevice
    {
        public int codedCrashVehicleDeviceid { get; set; }

        public int codedCrashVehicleid { get; set; }

        public int? vehicleDeviceTypeid { get; set; }

        public virtual CodedCrashVehicle CodedCrashVehicle { get; set; }

        public virtual VehicleDeviceType VehicleDeviceType { get; set; }
    }
}

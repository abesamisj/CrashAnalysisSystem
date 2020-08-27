namespace CAS.EntityModel.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("TcrVehicleDevice")]
    public partial class TcrVehicleDevice
    {
        public int tcrVehicleDeviceid { get; set; }

        public int tcrVehicleid { get; set; }

        public int vehicleDeviceTypeid { get; set; }

        public virtual TcrVehicle TcrVehicle { get; set; }

        public virtual VehicleDeviceType VehicleDeviceType { get; set; }
    }
}

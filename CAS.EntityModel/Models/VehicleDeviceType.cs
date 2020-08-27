namespace CAS.EntityModel.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("VehicleDeviceType")]
    public partial class VehicleDeviceType
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public VehicleDeviceType()
        {
            CodedCrashVehicleDevices = new HashSet<CodedCrashVehicleDevice>();
            TcrVehicleDevices = new HashSet<TcrVehicleDevice>();
        }

        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int vehicleDeviceTypeid { get; set; }

        [StringLength(50)]
        public string vehicleDeviceTypeName { get; set; }

        [StringLength(100)]
        public string vehicleDeviceTypeCode { get; set; }

        [StringLength(1000)]
        public string vehicleDeviceTypeDescription { get; set; }

        public DateTime? whenEffective { get; set; }

        public DateTime? whenIneffective { get; set; }

        public DateTime? whenWritten { get; set; }

        public int? displaySequence { get; set; }

        public bool? isNullPlaceholder { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<CodedCrashVehicleDevice> CodedCrashVehicleDevices { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<TcrVehicleDevice> TcrVehicleDevices { get; set; }
    }
}

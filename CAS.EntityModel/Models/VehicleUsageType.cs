namespace CAS.EntityModel.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("VehicleUsageType")]
    public partial class VehicleUsageType
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public VehicleUsageType()
        {
            CodedCrashVehicles = new HashSet<CodedCrashVehicle>();
            TcrVehicles = new HashSet<TcrVehicle>();
        }

        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int vehicleUsageTypeid { get; set; }

        [StringLength(50)]
        public string vehicleUsageTypeName { get; set; }

        [StringLength(100)]
        public string vehicleUsageTypeCode { get; set; }

        [StringLength(1000)]
        public string vehicleUsageTypeDescription { get; set; }

        public DateTime? whenEffective { get; set; }

        public DateTime? whenIneffective { get; set; }

        public DateTime? whenWritten { get; set; }

        public int? displaySequence { get; set; }

        public bool? isNullPlaceholder { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<CodedCrashVehicle> CodedCrashVehicles { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<TcrVehicle> TcrVehicles { get; set; }
    }
}

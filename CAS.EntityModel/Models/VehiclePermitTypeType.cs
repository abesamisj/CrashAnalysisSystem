namespace CAS.EntityModel.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("VehiclePermitTypeType")]
    public partial class VehiclePermitTypeType
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public VehiclePermitTypeType()
        {
            CodedCrashVehiclePermits = new HashSet<CodedCrashVehiclePermit>();
            TcrVehiclePermits = new HashSet<TcrVehiclePermit>();
        }

        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int vehiclePermitTypeTypeid { get; set; }

        [StringLength(50)]
        public string vehiclePermitTypeTypeName { get; set; }

        [StringLength(100)]
        public string vehiclePermitTypeTypeCode { get; set; }

        [StringLength(1000)]
        public string vehiclePermitTypeTypeDescription { get; set; }

        public DateTime? whenEffective { get; set; }

        public DateTime? whenIneffective { get; set; }

        public DateTime? whenWritten { get; set; }

        public int? displaySequence { get; set; }

        public bool? isNullPlaceholder { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<CodedCrashVehiclePermit> CodedCrashVehiclePermits { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<TcrVehiclePermit> TcrVehiclePermits { get; set; }
    }
}

namespace CAS.EntityModel.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("DirectionType")]
    public partial class DirectionType
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public DirectionType()
        {
            CodedCrashLocations = new HashSet<CodedCrashLocation>();
            CodedCrashVehicles = new HashSet<CodedCrashVehicle>();
            TcrLocations = new HashSet<TcrLocation>();
            TcrVehicles = new HashSet<TcrVehicle>();
        }

        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int directionTypeid { get; set; }

        [StringLength(50)]
        public string directionTypeName { get; set; }

        [StringLength(100)]
        public string directionTypeCode { get; set; }

        [StringLength(1000)]
        public string directionTypeDescription { get; set; }

        public DateTime? whenEffective { get; set; }

        public DateTime? whenIneffective { get; set; }

        public DateTime? whenWritten { get; set; }

        public int? displaySequence { get; set; }

        public bool? isNullPlaceholder { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<CodedCrashLocation> CodedCrashLocations { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<CodedCrashVehicle> CodedCrashVehicles { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<TcrLocation> TcrLocations { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<TcrVehicle> TcrVehicles { get; set; }
    }
}

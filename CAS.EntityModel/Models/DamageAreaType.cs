namespace CAS.EntityModel.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("DamageAreaType")]
    public partial class DamageAreaType
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public DamageAreaType()
        {
            CodedCrashTowedVehicles = new HashSet<CodedCrashTowedVehicle>();
            CodedCrashVehicles = new HashSet<CodedCrashVehicle>();
            TcrTowedVehicles = new HashSet<TcrTowedVehicle>();
            TcrVehicles = new HashSet<TcrVehicle>();
        }

        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int damageAreaTypeid { get; set; }

        [StringLength(50)]
        public string damageAreaTypeName { get; set; }

        [StringLength(100)]
        public string damageAreaTypeCode { get; set; }

        [StringLength(1000)]
        public string damageAreaTypeDescription { get; set; }

        public DateTime? whenEffective { get; set; }

        public DateTime? whenIneffective { get; set; }

        public DateTime? whenWritten { get; set; }

        public int? displaySequence { get; set; }

        [StringLength(50)]
        public string vehicleClass { get; set; }

        public bool? isNullPlaceholder { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<CodedCrashTowedVehicle> CodedCrashTowedVehicles { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<CodedCrashVehicle> CodedCrashVehicles { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<TcrTowedVehicle> TcrTowedVehicles { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<TcrVehicle> TcrVehicles { get; set; }
    }
}

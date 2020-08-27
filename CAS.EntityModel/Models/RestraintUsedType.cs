namespace CAS.EntityModel.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("RestraintUsedType")]
    public partial class RestraintUsedType
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public RestraintUsedType()
        {
            CodedCrashDrivers = new HashSet<CodedCrashDriver>();
            CodedCrashPassengers = new HashSet<CodedCrashPassenger>();
            TcrDrivers = new HashSet<TcrDriver>();
            TcrPassengers = new HashSet<TcrPassenger>();
        }

        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int restraintUsedTypeid { get; set; }

        [StringLength(50)]
        public string restraintUsedTypeName { get; set; }

        [StringLength(100)]
        public string restraintUsedTypeCode { get; set; }

        [StringLength(1000)]
        public string restraintUsedTypeDescription { get; set; }

        public DateTime? whenEffective { get; set; }

        public DateTime? whenIneffective { get; set; }

        public DateTime? whenWritten { get; set; }

        public int? displaySequence { get; set; }

        public bool? isNullPlaceholder { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<CodedCrashDriver> CodedCrashDrivers { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<CodedCrashPassenger> CodedCrashPassengers { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<TcrDriver> TcrDrivers { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<TcrPassenger> TcrPassengers { get; set; }
    }
}

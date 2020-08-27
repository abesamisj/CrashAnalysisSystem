namespace CAS.EntityModel.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("PrimarySurfaceConditionType")]
    public partial class PrimarySurfaceConditionType
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public PrimarySurfaceConditionType()
        {
            CodedCrashes = new HashSet<CodedCrash>();
            TcrCrashes = new HashSet<TcrCrash>();
        }

        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int primarySurfaceConditionTypeid { get; set; }

        [StringLength(50)]
        public string primarySurfaceConditionTypeName { get; set; }

        [StringLength(10)]
        public string primarySurfaceConditionTypeCode { get; set; }

        [StringLength(1000)]
        public string primarySurfaceConditionTypeDescription { get; set; }

        public DateTime whenEffective { get; set; }

        public DateTime? WhenIneffective { get; set; }

        public DateTime whenWritten { get; set; }

        public int? displaySequence { get; set; }

        public bool? isNullPlaceholder { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<CodedCrash> CodedCrashes { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<TcrCrash> TcrCrashes { get; set; }
    }
}

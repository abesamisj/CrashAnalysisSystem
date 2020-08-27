namespace CAS.EntityModel.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("BarrierType")]
    public partial class BarrierType
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public BarrierType()
        {
            CodedCrashBarriers = new HashSet<CodedCrashBarrier>();
            TcrBarriers = new HashSet<TcrBarrier>();
        }

        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int barrierTypeid { get; set; }

        [StringLength(50)]
        public string barrierTypeName { get; set; }

        [StringLength(100)]
        public string barrierTypeCode { get; set; }

        [StringLength(1000)]
        public string barrierTypeDescription { get; set; }

        public DateTime? whenEffective { get; set; }

        public DateTime? whenIneffective { get; set; }

        public DateTime? whenWritten { get; set; }

        public int? displaySequence { get; set; }

        public bool? isNullPlaceholder { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<CodedCrashBarrier> CodedCrashBarriers { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<TcrBarrier> TcrBarriers { get; set; }
    }
}

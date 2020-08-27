namespace CAS.EntityModel.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("BarrierLocationType")]
    public partial class BarrierLocationType
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public BarrierLocationType()
        {
            CodedCrashBarriers = new HashSet<CodedCrashBarrier>();
            TcrBarriers = new HashSet<TcrBarrier>();
        }

        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int barrierLocationTypeid { get; set; }

        [StringLength(50)]
        public string barrierLocationTypeName { get; set; }

        [StringLength(100)]
        public string barrierLocationTypeCode { get; set; }

        [StringLength(1000)]
        public string barrierLocationTypeDescription { get; set; }

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

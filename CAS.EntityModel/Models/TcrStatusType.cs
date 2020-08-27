namespace CAS.EntityModel.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("TcrStatusType")]
    public partial class TcrStatusType
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public TcrStatusType()
        {
            TcrCrashes = new HashSet<TcrCrash>();
            TcrProcessingStatus = new HashSet<TcrProcessingStatu>();
        }

        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int tcrStatusTypeid { get; set; }

        [StringLength(50)]
        public string tcrStatusTypeName { get; set; }

        [StringLength(100)]
        public string tcrStatusTypeCode { get; set; }

        [StringLength(1000)]
        public string tcrStatusTypeDescription { get; set; }

        public DateTime? whenEffective { get; set; }

        public DateTime? whenIneffective { get; set; }

        public DateTime? whenWritten { get; set; }

        public int? displaySequence { get; set; }

        public bool? isNullPlaceholder { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<TcrCrash> TcrCrashes { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<TcrProcessingStatu> TcrProcessingStatus { get; set; }
    }
}

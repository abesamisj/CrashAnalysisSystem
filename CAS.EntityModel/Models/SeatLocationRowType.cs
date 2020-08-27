namespace CAS.EntityModel.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("SeatLocationRowType")]
    public partial class SeatLocationRowType
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public SeatLocationRowType()
        {
            CodedCrashPassengers = new HashSet<CodedCrashPassenger>();
            TcrPassengers = new HashSet<TcrPassenger>();
        }

        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int seatLocationRowTypeid { get; set; }

        [StringLength(50)]
        public string seatLocationRowTypeName { get; set; }

        [StringLength(100)]
        public string seatLocationRowTypeCode { get; set; }

        [StringLength(1000)]
        public string seatLocationRowTypeDescription { get; set; }

        public DateTime? whenEffective { get; set; }

        public DateTime? whenIneffective { get; set; }

        public DateTime? whenWritten { get; set; }

        public int? displaySequence { get; set; }

        public bool? isNullPlaceholder { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<CodedCrashPassenger> CodedCrashPassengers { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<TcrPassenger> TcrPassengers { get; set; }
    }
}

namespace CAS.EntityModel.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("SeatLocationPositionType")]
    public partial class SeatLocationPositionType
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public SeatLocationPositionType()
        {
            CodedCrashPassengers = new HashSet<CodedCrashPassenger>();
            TcrPassengers = new HashSet<TcrPassenger>();
        }

        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int seatLocationPositionTypeid { get; set; }

        [StringLength(50)]
        public string seatLocationPositionTypeName { get; set; }

        [StringLength(100)]
        public string seatLocationPositionTypeCode { get; set; }

        [StringLength(1000)]
        public string seatLocationPositionTypeDescription { get; set; }

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

namespace CAS.EntityModel.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("OtherPassengerLocationType")]
    public partial class OtherPassengerLocationType
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public OtherPassengerLocationType()
        {
            CodedCrashPassengers = new HashSet<CodedCrashPassenger>();
            TcrPassengers = new HashSet<TcrPassenger>();
        }

        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int otherPassengerLocationTypeid { get; set; }

        [StringLength(50)]
        public string otherPassengerLocationTypeName { get; set; }

        [StringLength(100)]
        public string otherPassengerLocationTypeCode { get; set; }

        [StringLength(1000)]
        public string otherPassengerLocationTypeDescription { get; set; }

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

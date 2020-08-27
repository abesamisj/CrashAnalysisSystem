namespace CAS.EntityModel.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("IntersectionMidblockType")]
    public partial class IntersectionMidblockType
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public IntersectionMidblockType()
        {
            CodedCrashLocations = new HashSet<CodedCrashLocation>();
        }

        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int intersectionMidblockTypeid { get; set; }

        [StringLength(50)]
        public string intersectionMidblockTypename { get; set; }

        [StringLength(100)]
        public string intersectionMidblockTypeCode { get; set; }

        [StringLength(1000)]
        public string intersectionMidblockTypeDescription { get; set; }

        public DateTime? whenEffective { get; set; }

        public DateTime? whenIneffective { get; set; }

        public DateTime? whenWritten { get; set; }

        public int? displaySequence { get; set; }

        public bool? isNullPlaceholder { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<CodedCrashLocation> CodedCrashLocations { get; set; }
    }
}

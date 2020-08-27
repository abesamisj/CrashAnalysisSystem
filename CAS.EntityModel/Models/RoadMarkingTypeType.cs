namespace CAS.EntityModel.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("RoadMarkingTypeType")]
    public partial class RoadMarkingTypeType
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public RoadMarkingTypeType()
        {
            CodedCrashRoadMarkings = new HashSet<CodedCrashRoadMarking>();
            TcrRoadMarkings = new HashSet<TcrRoadMarking>();
        }

        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int roadMarkingTypeTypeid { get; set; }

        [StringLength(50)]
        public string roadMarkingTypeTypeName { get; set; }

        [StringLength(100)]
        public string roadMarkingTypeTypeCode { get; set; }

        [StringLength(1000)]
        public string roadMarkingTypeTypeDescription { get; set; }

        public DateTime? whenEffective { get; set; }

        public DateTime? whenIneffective { get; set; }

        public DateTime? whenWritten { get; set; }

        public int? displaySequence { get; set; }

        public bool? isNullPlaceholder { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<CodedCrashRoadMarking> CodedCrashRoadMarkings { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<TcrRoadMarking> TcrRoadMarkings { get; set; }
    }
}

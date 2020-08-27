namespace CAS.EntityModel.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("AdditionalRoadSurfaceConditionType")]
    public partial class AdditionalRoadSurfaceConditionType
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public AdditionalRoadSurfaceConditionType()
        {
            CodedCrashAdditionalRoadSurfaceConditions = new HashSet<CodedCrashAdditionalRoadSurfaceCondition>();
            TcrAdditionalRoadSurfaceConditions = new HashSet<TcrAdditionalRoadSurfaceCondition>();
        }

        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int additionalRoadSurfaceConditionTypeid { get; set; }

        [StringLength(50)]
        public string additionalRoadSurfaceConditionTypeName { get; set; }

        [StringLength(100)]
        public string additionalRoadSurfaceConditionTypeCode { get; set; }

        [StringLength(1000)]
        public string additionalRoadSurfaceConditionTypeDescription { get; set; }

        public DateTime? whenEffective { get; set; }

        public DateTime? whenIneffective { get; set; }

        public DateTime? whenWritten { get; set; }

        public int? displaySequence { get; set; }

        public bool? isNullPlaceholder { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<CodedCrashAdditionalRoadSurfaceCondition> CodedCrashAdditionalRoadSurfaceConditions { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<TcrAdditionalRoadSurfaceCondition> TcrAdditionalRoadSurfaceConditions { get; set; }
    }
}

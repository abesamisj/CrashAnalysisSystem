namespace CAS.EntityModel.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("CodedCrashUpdateReasonType")]
    public partial class CodedCrashUpdateReasonType
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public CodedCrashUpdateReasonType()
        {
            CodedCrashProcessingStatus = new HashSet<CodedCrashProcessingStatu>();
        }

        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int codedCrashUpdateReasonTypeid { get; set; }

        [StringLength(50)]
        public string codedCrashUpdateReasonTypeName { get; set; }

        [StringLength(100)]
        public string codedCrashUpdateReasonTypeCode { get; set; }

        [StringLength(1000)]
        public string codedCrashUpdateReasonTypeDescription { get; set; }

        public DateTime? whenEffective { get; set; }

        public DateTime? whenIneffective { get; set; }

        public DateTime? whenWritten { get; set; }

        public int? displaySequence { get; set; }

        public bool? isNullPlaceholder { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<CodedCrashProcessingStatu> CodedCrashProcessingStatus { get; set; }
    }
}

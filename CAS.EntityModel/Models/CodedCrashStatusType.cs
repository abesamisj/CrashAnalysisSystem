namespace CAS.EntityModel.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("CodedCrashStatusType")]
    public partial class CodedCrashStatusType
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public CodedCrashStatusType()
        {
            ArbitrationControls = new HashSet<ArbitrationControl>();
            CodedCrashes = new HashSet<CodedCrash>();
            CodedCrashProcessingStatus = new HashSet<CodedCrashProcessingStatu>();
        }

        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int codedCrashStatusTypeid { get; set; }

        [StringLength(50)]
        public string codedCrashStatusTypeName { get; set; }

        [StringLength(100)]
        public string codedCrashStatusTypeCode { get; set; }

        [StringLength(1000)]
        public string codedCrashStatusTypeDescription { get; set; }

        public DateTime? whenEffective { get; set; }

        public DateTime? whenIneffective { get; set; }

        public DateTime? whenWritten { get; set; }

        public int? displaySequence { get; set; }

        public bool? isNullPlaceholder { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<ArbitrationControl> ArbitrationControls { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<CodedCrash> CodedCrashes { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<CodedCrashProcessingStatu> CodedCrashProcessingStatus { get; set; }
    }
}

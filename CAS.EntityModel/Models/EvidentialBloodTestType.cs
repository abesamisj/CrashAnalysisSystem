namespace CAS.EntityModel.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("EvidentialBloodTestType")]
    public partial class EvidentialBloodTestType
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public EvidentialBloodTestType()
        {
            CodedCrashDrivers = new HashSet<CodedCrashDriver>();
            TcrDrivers = new HashSet<TcrDriver>();
        }

        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int evidentialBloodTestTypeid { get; set; }

        [StringLength(50)]
        public string evidentialBloodTestTypeName { get; set; }

        [StringLength(100)]
        public string evidentialBloodTestTypeCode { get; set; }

        [StringLength(1000)]
        public string evidentialBloodTestTypeDescription { get; set; }

        public DateTime? whenEffective { get; set; }

        public DateTime? whenIneffective { get; set; }

        public DateTime? whenWritten { get; set; }

        public int? displaySequence { get; set; }

        public bool? isNullPlaceholder { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<CodedCrashDriver> CodedCrashDrivers { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<TcrDriver> TcrDrivers { get; set; }
    }
}

namespace CAS.EntityModel.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("DrugsInvolvedType")]
    public partial class DrugsInvolvedType
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public DrugsInvolvedType()
        {
            CodedCrashDrivers = new HashSet<CodedCrashDriver>();
            TcrDrivers = new HashSet<TcrDriver>();
        }

        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int drugsInvolvedTypeid { get; set; }

        [StringLength(50)]
        public string drugsInvolvedTypeName { get; set; }

        [StringLength(100)]
        public string drugsInvolvedTypeCode { get; set; }

        [StringLength(1000)]
        public string drugsInvolvedTypeDescription { get; set; }

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

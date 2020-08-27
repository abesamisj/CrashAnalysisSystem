namespace CAS.EntityModel.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("AlcoholInvolvedType")]
    public partial class AlcoholInvolvedType
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public AlcoholInvolvedType()
        {
            CodedCrashDrivers = new HashSet<CodedCrashDriver>();
            TcrDrivers = new HashSet<TcrDriver>();
        }

        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int alcoholInvolvedTypeid { get; set; }

        [Required]
        [StringLength(50)]
        public string alcoholInvolvedTypeName { get; set; }

        [Required]
        [StringLength(10)]
        public string alcoholInvolvedTypeCode { get; set; }

        [StringLength(1000)]
        public string alcoholInvolvedTypeDescription { get; set; }

        public DateTime whenEffective { get; set; }

        public DateTime? whenIneffective { get; set; }

        public DateTime whenWritten { get; set; }

        public int? displaySequence { get; set; }

        public bool? isNullPlaceholder { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<CodedCrashDriver> CodedCrashDrivers { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<TcrDriver> TcrDrivers { get; set; }
    }
}

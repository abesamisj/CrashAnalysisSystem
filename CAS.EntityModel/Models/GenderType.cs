namespace CAS.EntityModel.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("GenderType")]
    public partial class GenderType
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public GenderType()
        {
            CodedCrashPersons = new HashSet<CodedCrashPerson>();
            TcrPersons = new HashSet<TcrPerson>();
        }

        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int genderTypeid { get; set; }

        [StringLength(50)]
        public string genderTypeName { get; set; }

        [StringLength(100)]
        public string genderTypeCode { get; set; }

        [StringLength(1000)]
        public string genderTypeDescription { get; set; }

        public DateTime? whenEffective { get; set; }

        public DateTime? whenIneffective { get; set; }

        public DateTime? whenWritten { get; set; }

        public int? displaySequence { get; set; }

        public bool? isNullPlaceholder { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<CodedCrashPerson> CodedCrashPersons { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<TcrPerson> TcrPersons { get; set; }
    }
}

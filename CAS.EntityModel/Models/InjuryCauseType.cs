namespace CAS.EntityModel.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("InjuryCauseType")]
    public partial class InjuryCauseType
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public InjuryCauseType()
        {
            CodedCrashPersons = new HashSet<CodedCrashPerson>();
        }

        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int injuryCauseTypeid { get; set; }

        [StringLength(50)]
        public string injuryCauseTypeName { get; set; }

        [StringLength(100)]
        public string injuryCauseTypeCode { get; set; }

        [StringLength(1000)]
        public string injuryCauseTypeDescription { get; set; }

        public DateTime? whenEffective { get; set; }

        public DateTime? whenIneffective { get; set; }

        public DateTime? whenWritten { get; set; }

        public int? displaySequence { get; set; }

        public bool? isNullPlaceholder { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<CodedCrashPerson> CodedCrashPersons { get; set; }
    }
}

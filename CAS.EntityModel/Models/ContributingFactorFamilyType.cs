namespace CAS.EntityModel.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("ContributingFactorFamilyType")]
    public partial class ContributingFactorFamilyType
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public ContributingFactorFamilyType()
        {
            ContributingFactorTypes = new HashSet<ContributingFactorType>();
            KeywordToCfHelpers = new HashSet<KeywordToCfHelper>();
        }

        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int contributingFactorFamilyTypeid { get; set; }

        [StringLength(50)]
        public string contributingFactorFamilyTypeName { get; set; }

        [StringLength(100)]
        public string contributingFactorFamilyTypeCode { get; set; }

        [StringLength(1000)]
        public string contributingFactorFamilyTypeDescription { get; set; }

        public DateTime? whenEffective { get; set; }

        public DateTime? whenIneffective { get; set; }

        public DateTime? whenWritten { get; set; }

        public int? displaySequence { get; set; }

        public bool? isNullPlaceholder { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<ContributingFactorType> ContributingFactorTypes { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<KeywordToCfHelper> KeywordToCfHelpers { get; set; }
    }
}

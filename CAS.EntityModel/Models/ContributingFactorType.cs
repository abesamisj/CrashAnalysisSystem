namespace CAS.EntityModel.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("ContributingFactorType")]
    public partial class ContributingFactorType
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public ContributingFactorType()
        {
            CodedCrashContributingFactors = new HashSet<CodedCrashContributingFactor>();
            ContributingFactorHints = new HashSet<ContributingFactorHint>();
            ContributingFactorsInExercises = new HashSet<ContributingFactorsInExercise>();
            KeywordToCfHelpers = new HashSet<KeywordToCfHelper>();
        }

        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int contributingFactorTypeid { get; set; }

        [StringLength(50)]
        public string contributingFactorTypeName { get; set; }

        [StringLength(100)]
        public string contributingFactorTypeCode { get; set; }

        [StringLength(1000)]
        public string contributingFactorTypeDescription { get; set; }

        public int contributingFactorFamilyTypeid { get; set; }

        public int contributingFactorGroupTypeid { get; set; }

        public DateTime? whenEffective { get; set; }

        public DateTime? whenIneffective { get; set; }

        public DateTime? whenWritten { get; set; }

        public int? displaySequence { get; set; }

        [StringLength(50)]
        public string roadSafetyFactorGroupName { get; set; }

        public bool? isNullPlaceholder { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<CodedCrashContributingFactor> CodedCrashContributingFactors { get; set; }

        public virtual ContributingFactorFamilyType ContributingFactorFamilyType { get; set; }

        public virtual ContributingFactorGroupType ContributingFactorGroupType { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<ContributingFactorHint> ContributingFactorHints { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<ContributingFactorsInExercise> ContributingFactorsInExercises { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<KeywordToCfHelper> KeywordToCfHelpers { get; set; }
    }
}

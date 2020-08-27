namespace CAS.EntityModel.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("ContributingFactorGroupType")]
    public partial class ContributingFactorGroupType
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public ContributingFactorGroupType()
        {
            ContributingFactorTypes = new HashSet<ContributingFactorType>();
        }

        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int contributingFactorGroupTypeid { get; set; }

        [StringLength(50)]
        public string contributingFactorGroupTypeCode { get; set; }

        [StringLength(100)]
        public string contributingFactorGroupTypeName { get; set; }

        [StringLength(1000)]
        public string contributingFactorGroupTypeDescription { get; set; }

        public DateTime? whenEffective { get; set; }

        public DateTime? whenIneffective { get; set; }

        public DateTime? whenWritten { get; set; }

        public int? displaySequence { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<ContributingFactorType> ContributingFactorTypes { get; set; }
    }
}

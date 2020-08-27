namespace CAS.EntityModel.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("StruckObjectTypeType")]
    public partial class StruckObjectTypeType
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public StruckObjectTypeType()
        {
            StruckObjectTypes = new HashSet<StruckObjectType>();
        }

        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int struckObjectTypeTypeid { get; set; }

        [StringLength(50)]
        public string struckObjectTypeTypeName { get; set; }

        [StringLength(100)]
        public string struckObjectTypeTypeCode { get; set; }

        [StringLength(1000)]
        public string struckObjectTypeTypeDescription { get; set; }

        public DateTime? whenEffective { get; set; }

        public DateTime? whenIneffective { get; set; }

        public DateTime? whenWritten { get; set; }

        public int? displaySequence { get; set; }

        public bool? isNullPlaceholder { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<StruckObjectType> StruckObjectTypes { get; set; }
    }
}

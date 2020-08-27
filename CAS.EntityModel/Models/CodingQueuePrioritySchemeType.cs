namespace CAS.EntityModel.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("CodingQueuePrioritySchemeType")]
    public partial class CodingQueuePrioritySchemeType
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public CodingQueuePrioritySchemeType()
        {
            UserProfiles = new HashSet<UserProfile>();
        }

        public int codingQueuePrioritySchemeTypeid { get; set; }

        [StringLength(50)]
        public string codingQueueTypeName { get; set; }

        [StringLength(100)]
        public string codingQueueTypeCode { get; set; }

        [StringLength(1000)]
        public string codingQueueTypeDescription { get; set; }

        public DateTime? whenEffective { get; set; }

        public DateTime? whenIneffective { get; set; }

        public DateTime? whenWritten { get; set; }

        public int? displaySequence { get; set; }

        public bool? isTCRAcceptance { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<UserProfile> UserProfiles { get; set; }
    }
}

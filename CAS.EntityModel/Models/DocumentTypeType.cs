namespace CAS.EntityModel.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("DocumentTypeType")]
    public partial class DocumentTypeType
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public DocumentTypeType()
        {
            CodedCrashDocuments = new HashSet<CodedCrashDocument>();
        }

        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int documentTypeTypeid { get; set; }

        [StringLength(50)]
        public string documentTypeTypeName { get; set; }

        [StringLength(100)]
        public string documentTypeTypeCode { get; set; }

        [StringLength(1000)]
        public string documentTypeTypeDescription { get; set; }

        public DateTime? whenEffective { get; set; }

        public DateTime? whenIneffective { get; set; }

        public DateTime? whenWritten { get; set; }

        public int? displaySequence { get; set; }

        public bool? isNullPlaceholder { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<CodedCrashDocument> CodedCrashDocuments { get; set; }
    }
}

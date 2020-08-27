namespace CAS.EntityModel.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("CodedCrashDocument")]
    public partial class CodedCrashDocument
    {
        [Key]
        public int crashDocumentid { get; set; }

        public int documentTypeTypeid { get; set; }

        [StringLength(1000)]
        public string documentInfoHubURL { get; set; }

        [StringLength(1000)]
        public string legacyCASImagePath { get; set; }

        [StringLength(1000)]
        public string reviewComment { get; set; }

        public int codedCrashid { get; set; }

        [StringLength(250)]
        public string documentTitle { get; set; }

        public virtual CodedCrash CodedCrash { get; set; }

        public virtual DocumentTypeType DocumentTypeType { get; set; }
    }
}

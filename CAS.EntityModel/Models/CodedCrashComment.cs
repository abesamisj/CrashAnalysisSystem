namespace CAS.EntityModel.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class CodedCrashComment
    {
        public int codedCrashCommentid { get; set; }

        public int? codedCrashid { get; set; }

        [Column("codedCrashComment")]
        [StringLength(1000)]
        public string codedCrashComment1 { get; set; }

        [StringLength(250)]
        public string codedCrashFieldName { get; set; }

        public bool? codedCrashIsGeneralComment { get; set; }

        public int? codedCrashAuxilliaryid { get; set; }

        [StringLength(128)]
        public string codedCrashEnclosingType { get; set; }

        [StringLength(500)]
        public string codedCrashDisplayLink { get; set; }

        public virtual CodedCrash CodedCrash { get; set; }
    }
}

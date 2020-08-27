namespace CAS.EntityModel.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class TcrComment
    {
        public int tcrCommentid { get; set; }

        public int tcrCrashIdentifierid { get; set; }

        public DateTime timestamp { get; set; }

        public DateTime? createdDate { get; set; }

        [Column("tcrComment")]
        [StringLength(1000)]
        public string tcrComment1 { get; set; }

        [StringLength(250)]
        public string tcrFieldName { get; set; }

        public bool? tcrIsGeneralComment { get; set; }

        public int? tcrAuxilliaryid { get; set; }

        [StringLength(128)]
        public string tcrEnclosingType { get; set; }

        [StringLength(500)]
        public string DisplayLink { get; set; }

        public virtual TcrCrash TcrCrash { get; set; }
    }
}

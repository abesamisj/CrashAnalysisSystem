namespace CAS.EntityModel.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class CodedCrashProcessingStatu
    {
        [Key]
        public int codedCrashProcessingStatusid { get; set; }

        public int codedCrashid { get; set; }

        public DateTime processStart { get; set; }

        public DateTime? processEnd { get; set; }

        public int? codedCrashupdateReasonTypeid { get; set; }

        public int userProfileid { get; set; }

        public int CodedCrashStatusTypeid { get; set; }

        public virtual CodedCrash CodedCrash { get; set; }

        public virtual CodedCrashStatusType CodedCrashStatusType { get; set; }

        public virtual CodedCrashUpdateReasonType CodedCrashUpdateReasonType { get; set; }

        public virtual UserProfile UserProfile { get; set; }
    }
}

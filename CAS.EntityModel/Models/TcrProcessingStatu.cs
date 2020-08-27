namespace CAS.EntityModel.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class TcrProcessingStatu
    {
        [Key]
        public int tcrProcessingStatusid { get; set; }

        public int tcrCrashIdentifierid { get; set; }

        public DateTime timestamp { get; set; }

        public int tcrStatusTypeid { get; set; }

        public int statusChangedByUser { get; set; }

        public DateTime dateStatusChanged { get; set; }

        public bool? isReturnedToPolice { get; set; }

        public virtual TcrCrash TcrCrash { get; set; }

        public virtual TcrStatusType TcrStatusType { get; set; }

        public virtual UserProfile UserProfile { get; set; }
    }
}

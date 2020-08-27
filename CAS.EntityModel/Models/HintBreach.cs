namespace CAS.EntityModel.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class HintBreach
    {
        [Key]
        public int hintBreachesid { get; set; }

        public int? codedCrashid { get; set; }

        public int? hintTypeid { get; set; }

        [StringLength(2048)]
        public string hintBreachReason { get; set; }

        public virtual CodedCrash CodedCrash { get; set; }

        public virtual HintType HintType { get; set; }
    }
}

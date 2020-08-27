namespace CAS.EntityModel.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("ArbitrationControl")]
    public partial class ArbitrationControl
    {
        [Key]
        [Column(Order = 0)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int originalCodedCrashid { get; set; }

        [Key]
        [Column(Order = 1)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int reviewCodedCrashid { get; set; }

        public int? arbitratedByid { get; set; }

        public bool? originalChosen { get; set; }

        public int? finalStatusTypeid { get; set; }

        [StringLength(250)]
        public string comments { get; set; }

        public virtual CodedCrashStatusType CodedCrashStatusType { get; set; }

        public virtual CodedCrash CodedCrash { get; set; }

        public virtual CodedCrash CodedCrash1 { get; set; }

        public virtual UserProfile UserProfile { get; set; }
    }
}

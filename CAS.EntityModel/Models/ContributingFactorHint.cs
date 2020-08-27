namespace CAS.EntityModel.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("ContributingFactorHint")]
    public partial class ContributingFactorHint
    {
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int contributingFactorHintid { get; set; }

        public int? contributingFactorTypeid { get; set; }

        public DateTime? whenEffective { get; set; }

        public DateTime? whenIneffective { get; set; }

        public DateTime? whenWritten { get; set; }

        public int? displaySequence { get; set; }

        public int? hintTypeid { get; set; }

        public virtual HintType HintType { get; set; }

        public virtual ContributingFactorType ContributingFactorType { get; set; }
    }
}

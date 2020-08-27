namespace CAS.EntityModel.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("MovementCodeHint")]
    public partial class MovementCodeHint
    {
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int movementCodeHintid { get; set; }

        public int? movementCodeTypeid { get; set; }

        public DateTime? whenEffective { get; set; }

        public DateTime? whenIneffective { get; set; }

        public DateTime? whenWritten { get; set; }

        public int? displaySequence { get; set; }

        public int? hintTypeid { get; set; }

        public virtual HintType HintType { get; set; }

        public virtual MovementCodeType MovementCodeType { get; set; }
    }
}

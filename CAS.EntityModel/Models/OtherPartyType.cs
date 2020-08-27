namespace CAS.EntityModel.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("OtherPartyType")]
    public partial class OtherPartyType
    {
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int otherPartyTypeid { get; set; }

        [StringLength(50)]
        public string otherPartyTypeName { get; set; }

        [StringLength(100)]
        public string otherPartyTypeCode { get; set; }

        [StringLength(1000)]
        public string otherPartyTypeDescription { get; set; }

        public DateTime? whenEffective { get; set; }

        public DateTime? whenIneffective { get; set; }

        public DateTime? whenWritten { get; set; }

        public int? displaySequence { get; set; }

        public bool? isNullPlaceholder { get; set; }
    }
}

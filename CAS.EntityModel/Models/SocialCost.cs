namespace CAS.EntityModel.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("SocialCost")]
    public partial class SocialCost
    {
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int socialCostid { get; set; }

        public int? regionid { get; set; }

        public bool? currentPeriod { get; set; }

        [Column(TypeName = "money")]
        public decimal? averageUrbanCost { get; set; }

        [Column(TypeName = "money")]
        public decimal? averageRuralCost { get; set; }

        [Column(TypeName = "money")]
        public decimal? fatalUrbanCost { get; set; }

        [Column(TypeName = "money")]
        public decimal? fatalRuralCost { get; set; }

        [Column(TypeName = "money")]
        public decimal? seriousUrbanCost { get; set; }

        [Column(TypeName = "money")]
        public decimal? seriousRuralCost { get; set; }

        [Column(TypeName = "money")]
        public decimal? minorUrbanCost { get; set; }

        [Column(TypeName = "money")]
        public decimal? minorRuralCost { get; set; }

        [Column(TypeName = "money")]
        public decimal? nonInjuryUrbanCost { get; set; }

        [Column(TypeName = "money")]
        public decimal? nonInjuryRuralCost { get; set; }
    }
}

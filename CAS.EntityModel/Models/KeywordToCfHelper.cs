namespace CAS.EntityModel.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("KeywordToCfHelper")]
    public partial class KeywordToCfHelper
    {
        public int keywordToCFHelperid { get; set; }

        [StringLength(100)]
        public string keyword { get; set; }

        public int? contributingFactorTypeid { get; set; }

        public int? contributingFactorFamilyTypeid { get; set; }

        public virtual ContributingFactorFamilyType ContributingFactorFamilyType { get; set; }

        public virtual ContributingFactorType ContributingFactorType { get; set; }
    }
}

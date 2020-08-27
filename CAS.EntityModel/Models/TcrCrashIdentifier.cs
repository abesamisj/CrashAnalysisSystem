namespace CAS.EntityModel.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("TcrCrashIdentifier")]
    public partial class TcrCrashIdentifier
    {
        public int tcrCrashIdentifierid { get; set; }

        public DateTime generatedDateTime { get; set; }

        [StringLength(11)]
        public string computedCrashIdentifier { get; set; }
    }
}

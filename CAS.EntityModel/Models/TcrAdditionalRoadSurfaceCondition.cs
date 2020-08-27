namespace CAS.EntityModel.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("TcrAdditionalRoadSurfaceCondition")]
    public partial class TcrAdditionalRoadSurfaceCondition
    {
        [Key]
        public int tcrAddtionalRoadSurfaceConditionid { get; set; }

        public int tcrCrashIdentifierid { get; set; }

        public DateTime timestamp { get; set; }

        public int additionalRoadSurfaceConditionTypeid { get; set; }

        public virtual AdditionalRoadSurfaceConditionType AdditionalRoadSurfaceConditionType { get; set; }

        public virtual TcrCrash TcrCrash { get; set; }
    }
}

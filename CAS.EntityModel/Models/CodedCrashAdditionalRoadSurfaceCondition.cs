namespace CAS.EntityModel.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("CodedCrashAdditionalRoadSurfaceCondition")]
    public partial class CodedCrashAdditionalRoadSurfaceCondition
    {
        [Key]
        public int codedCrashAddtionalRoadSurfaceConditionid { get; set; }

        public int additionalRoadSurfaceConditionTypeid { get; set; }

        public int codedCrashid { get; set; }

        public virtual AdditionalRoadSurfaceConditionType AdditionalRoadSurfaceConditionType { get; set; }

        public virtual CodedCrash CodedCrash { get; set; }
    }
}

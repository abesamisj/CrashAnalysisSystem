namespace CAS.EntityModel.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("CodedCrashRoadMarking")]
    public partial class CodedCrashRoadMarking
    {
        public int codedCrashRoadMarkingid { get; set; }

        public int codedCrashid { get; set; }

        public int roadMarkingTypeTypeid { get; set; }

        public virtual CodedCrash CodedCrash { get; set; }

        public virtual RoadMarkingTypeType RoadMarkingTypeType { get; set; }
    }
}

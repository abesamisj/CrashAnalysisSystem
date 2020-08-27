namespace CAS.EntityModel.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("TcrRoadMarking")]
    public partial class TcrRoadMarking
    {
        public int tcrRoadMarkingid { get; set; }

        public int roadMarkingTypeTypeid { get; set; }

        public int tcrCrashIdentifierid { get; set; }

        public DateTime timestamp { get; set; }

        public virtual RoadMarkingTypeType RoadMarkingTypeType { get; set; }

        public virtual TcrCrash TcrCrash { get; set; }
    }
}

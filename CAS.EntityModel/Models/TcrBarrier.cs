namespace CAS.EntityModel.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("TcrBarrier")]
    public partial class TcrBarrier
    {
        public int tcrBarrierid { get; set; }

        public int barrierTypeid { get; set; }

        public int barrierLocationTypeid { get; set; }

        public int tcrCrashIdentifierid { get; set; }

        public DateTime timestamp { get; set; }

        public virtual BarrierLocationType BarrierLocationType { get; set; }

        public virtual BarrierType BarrierType { get; set; }

        public virtual TcrCrash TcrCrash { get; set; }
    }
}

namespace CAS.EntityModel.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("CodedCrashBarrier")]
    public partial class CodedCrashBarrier
    {
        public int codedCrashBarrierid { get; set; }

        public int barrierTypeid { get; set; }

        public int barrierLocationTypeid { get; set; }

        public int codedCrashid { get; set; }

        public virtual BarrierLocationType BarrierLocationType { get; set; }

        public virtual BarrierType BarrierType { get; set; }

        public virtual CodedCrash CodedCrash { get; set; }
    }
}

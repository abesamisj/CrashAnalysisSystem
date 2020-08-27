namespace CAS.EntityModel.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("TcrCrashDiagram")]
    public partial class TcrCrashDiagram
    {
        public int tcrCrashDiagramid { get; set; }

        public int tcrCrashIdentifierid { get; set; }

        public DateTime timestamp { get; set; }

        public byte[] diagram { get; set; }

        public virtual TcrCrash TcrCrash { get; set; }
    }
}

namespace CAS.EntityModel.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("CodedCrashDiagram")]
    public partial class CodedCrashDiagram
    {
        public int codedCrashDiagramid { get; set; }

        public int codedCrashId { get; set; }

        public byte[] diagram { get; set; }

        public virtual CodedCrash CodedCrash { get; set; }
    }
}

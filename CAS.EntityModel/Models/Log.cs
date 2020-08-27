namespace CAS.EntityModel.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class Log
    {
        public int Id { get; set; }

        public string Message { get; set; }

        public string MessageTemplate { get; set; }

        [StringLength(128)]
        public string Level { get; set; }

        public DateTimeOffset TimeStamp { get; set; }

        public string Exception { get; set; }

        [Column(TypeName = "xml")]
        public string Properties { get; set; }

        public string LogEvent { get; set; }

        public string User { get; set; }

        public string Caller { get; set; }

        public int? AutoSessionId { get; set; }
    }
}

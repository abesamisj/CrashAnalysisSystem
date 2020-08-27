namespace CAS.EntityModel.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("DeleteAuditStaging")]
    public partial class DeleteAuditStaging
    {
        public int id { get; set; }

        [StringLength(255)]
        public string tableName { get; set; }

        public int? recordKey { get; set; }

        public DateTime? deleteDate { get; set; }

        public int? parentStatus { get; set; }
    }
}

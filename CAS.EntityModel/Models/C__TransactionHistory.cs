namespace CAS.EntityModel.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("__TransactionHistory")]
    public partial class C__TransactionHistory
    {
        public Guid Id { get; set; }

        public DateTime CreationTime { get; set; }
    }
}

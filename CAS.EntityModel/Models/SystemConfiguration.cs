namespace CAS.EntityModel.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("SystemConfiguration")]
    public partial class SystemConfiguration
    {
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int systemConfigurationid { get; set; }

        [StringLength(100)]
        public string configurationName { get; set; }

        public string configurationValue { get; set; }

        [StringLength(512)]
        public string Comments { get; set; }
    }
}

namespace CAS.EntityModel.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("ApplicationConfiguration")]
    public partial class ApplicationConfiguration
    {
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int applicationConfigurationid { get; set; }

        [StringLength(50)]
        public string applicationConfigurationName { get; set; }

        public string applicationConfigurationValue { get; set; }
    }
}

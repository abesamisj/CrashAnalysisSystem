namespace CAS.EntityModel.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("TcrPdfPrintingConfiguration")]
    public partial class TcrPdfPrintingConfiguration
    {
        [StringLength(100)]
        public string tcrPDFPrintingConfigurationid { get; set; }

        [Required]
        [StringLength(255)]
        public string tcrPDFPrintingConfigurationValue { get; set; }
    }
}

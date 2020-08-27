namespace CAS.EntityModel.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("DriverContributionType")]
    public partial class DriverContributionType
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public DriverContributionType()
        {
            CodedCrashDrivers = new HashSet<CodedCrashDriver>();
        }

        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int driverContributionTypeid { get; set; }

        [StringLength(50)]
        public string driverContributionTypeName { get; set; }

        [StringLength(100)]
        public string driverContributionTypeCode { get; set; }

        [StringLength(1000)]
        public string driverContributionTypeDescription { get; set; }

        public DateTime? whenEffective { get; set; }

        public DateTime? whenIneffective { get; set; }

        public DateTime? whenWritten { get; set; }

        public int? displaySequence { get; set; }

        public bool? isNullPlaceholder { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<CodedCrashDriver> CodedCrashDrivers { get; set; }
    }
}

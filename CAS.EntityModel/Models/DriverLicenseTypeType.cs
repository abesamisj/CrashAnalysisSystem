namespace CAS.EntityModel.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("DriverLicenseTypeType")]
    public partial class DriverLicenseTypeType
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public DriverLicenseTypeType()
        {
            CodedCrashDrivers = new HashSet<CodedCrashDriver>();
            TcrDrivers = new HashSet<TcrDriver>();
        }

        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int driverLicenseTypeTypeid { get; set; }

        [StringLength(50)]
        public string driverLicenseTypeTypeName { get; set; }

        [StringLength(100)]
        public string driverLicenseTypeTypeCode { get; set; }

        [StringLength(1000)]
        public string driverLicenseTypeTypeDescription { get; set; }

        public DateTime? whenEffective { get; set; }

        public DateTime? whenIneffective { get; set; }

        public DateTime? whenWritten { get; set; }

        public int? displaySequence { get; set; }

        public bool? isNullPlaceholder { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<CodedCrashDriver> CodedCrashDrivers { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<TcrDriver> TcrDrivers { get; set; }
    }
}

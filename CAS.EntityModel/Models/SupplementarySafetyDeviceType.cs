namespace CAS.EntityModel.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("SupplementarySafetyDeviceType")]
    public partial class SupplementarySafetyDeviceType
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public SupplementarySafetyDeviceType()
        {
            CodedCrashDriverSupplementarySafetyDeviceUseds = new HashSet<CodedCrashDriverSupplementarySafetyDeviceUsed>();
            CodedCrashPassengerSupplementarySafetyDeviceUseds = new HashSet<CodedCrashPassengerSupplementarySafetyDeviceUsed>();
            TcrDriverSupplementarySafetyDeviceUseds = new HashSet<TcrDriverSupplementarySafetyDeviceUsed>();
            TcrPassengerSupplementarySafetyDeviceUseds = new HashSet<TcrPassengerSupplementarySafetyDeviceUsed>();
        }

        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int supplementarySafetyDeviceTypeid { get; set; }

        [StringLength(50)]
        public string supplementarySafetyDeviceTypeName { get; set; }

        [StringLength(100)]
        public string supplementarySafetyDeviceTypeCode { get; set; }

        [StringLength(1000)]
        public string supplementarySafetyDeviceTypeDescription { get; set; }

        public DateTime? whenEffective { get; set; }

        public DateTime? whenIneffective { get; set; }

        public DateTime? whenWritten { get; set; }

        public int? displaySequence { get; set; }

        public bool? isNullPlaceholder { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<CodedCrashDriverSupplementarySafetyDeviceUsed> CodedCrashDriverSupplementarySafetyDeviceUseds { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<CodedCrashPassengerSupplementarySafetyDeviceUsed> CodedCrashPassengerSupplementarySafetyDeviceUseds { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<TcrDriverSupplementarySafetyDeviceUsed> TcrDriverSupplementarySafetyDeviceUseds { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<TcrPassengerSupplementarySafetyDeviceUsed> TcrPassengerSupplementarySafetyDeviceUseds { get; set; }
    }
}

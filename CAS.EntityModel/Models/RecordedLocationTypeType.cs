namespace CAS.EntityModel.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("RecordedLocationTypeType")]
    public partial class RecordedLocationTypeType
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public RecordedLocationTypeType()
        {
            CodedCrashLocations = new HashSet<CodedCrashLocation>();
            TcrLocations = new HashSet<TcrLocation>();
        }

        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int recordedLocationTypeTypeid { get; set; }

        [StringLength(50)]
        public string recordedLocationTypeTypeName { get; set; }

        [StringLength(100)]
        public string recordedLocationTypeTypeCode { get; set; }

        [StringLength(1000)]
        public string recordedLocationTypeTypeDescription { get; set; }

        public DateTime? whenEffective { get; set; }

        public DateTime? whenIneffective { get; set; }

        public DateTime? whenWritten { get; set; }

        public int? displaySequence { get; set; }

        public bool? isNullPlaceholder { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<CodedCrashLocation> CodedCrashLocations { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<TcrLocation> TcrLocations { get; set; }
    }
}

namespace CAS.EntityModel.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("StruckObjectType")]
    public partial class StruckObjectType
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public StruckObjectType()
        {
            CodedCrashVehicleObjectsStrucks = new HashSet<CodedCrashVehicleObjectsStruck>();
        }

        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int struckObjectTypeid { get; set; }

        [StringLength(50)]
        public string struckObjectTypeName { get; set; }

        [StringLength(100)]
        public string struckObjectTypeCode { get; set; }

        [StringLength(1000)]
        public string struckObjectTypeDescription { get; set; }

        public DateTime? whenEffective { get; set; }

        public DateTime? whenIneffective { get; set; }

        public DateTime? whenWritten { get; set; }

        public int? displaySequence { get; set; }

        public int? struckObjectTypeTypeid { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<CodedCrashVehicleObjectsStruck> CodedCrashVehicleObjectsStrucks { get; set; }

        public virtual StruckObjectTypeType StruckObjectTypeType { get; set; }
    }
}

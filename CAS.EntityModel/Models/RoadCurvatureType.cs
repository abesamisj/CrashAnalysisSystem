namespace CAS.EntityModel.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("RoadCurvatureType")]
    public partial class RoadCurvatureType
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public RoadCurvatureType()
        {
            CodedCrashes = new HashSet<CodedCrash>();
            TcrCrashes = new HashSet<TcrCrash>();
        }

        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int roadCurvatureTypeid { get; set; }

        [StringLength(50)]
        public string roadCurvatureTypeName { get; set; }

        [StringLength(100)]
        public string roadCurvatureTypeCode { get; set; }

        [StringLength(1000)]
        public string roadCurvatureTypeDescription { get; set; }

        public DateTime whenEffective { get; set; }

        public DateTime? whenIneffective { get; set; }

        public DateTime whenWritten { get; set; }

        public int? displaySequence { get; set; }

        public bool? isNullPlaceholder { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<CodedCrash> CodedCrashes { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<TcrCrash> TcrCrashes { get; set; }
    }
}
